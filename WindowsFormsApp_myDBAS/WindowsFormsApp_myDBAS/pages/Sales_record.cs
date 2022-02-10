using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_myDBAS
{
    public partial class Sales_record : Form
    {
        public Sales_record()
        {
            InitializeComponent();
        }
        DataSet dataSet = new DataSet(); //定义一个数据集
       
        public void Display()//一开始加载销售记录表
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select * from carsales_info";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "carsales_info");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名Customer_info
                dgvCarsales_info.DataSource = dataSet.Tables["carsales_info"];
                /*动态使读出来的数据不可修改*/
                for (int i = 0; i < dataSet.Tables["carsales_info"].Rows.Count; i++)
                {
                    dgvCarsales_info.Rows[i].ReadOnly = true;
                }
            }
            catch
            {
                MessageBox.Show("开始加载销售记录表出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    //关闭数据连接对象
                }

            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)//更新功能
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                //判断是不是新添加的记录
                if(dgvCarsales_info.CurrentRow.Index+2<=dataSet.Tables["carsales_info"].Rows.Count)
                {
                    MessageBox.Show("只能用来插入新数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }    
                //判断库存够不够 
                int index = dgvCarsales_info.CurrentRow.Index;    //取得选中行的索引  
                int sales_amount = Convert.ToInt32(dgvCarsales_info.Rows[index].Cells["amount"].Value);
                SqlCommand cmdwarehouse = new SqlCommand("Getwarehouse_amount", conn);
                cmdwarehouse.CommandType = CommandType.StoredProcedure;
                SqlParameter car_numwarehouse = new SqlParameter("@car_num", SqlDbType.Char, 10);
                car_numwarehouse.Value = Convert.ToString(dgvCarsales_info.SelectedRows[0].Cells[1].Value);
                cmdwarehouse.Parameters.Add(car_numwarehouse);
                SqlParameter warehouse_amount = new SqlParameter("@amount", SqlDbType.Int);
                warehouse_amount.Direction = ParameterDirection.Output;
                cmdwarehouse.Parameters.Add(warehouse_amount);
                cmdwarehouse.ExecuteNonQuery();
                int warehouse_amount1 = Convert.ToInt16(cmdwarehouse.Parameters["@amount"].Value);//取得库存
                if (sales_amount <= warehouse_amount1)
                {

                    //让仓库的库存减去本次销售的数量
                    SqlCommand cmd = new SqlCommand("Setwarehouse_amount", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter car_num = new SqlParameter("@car_num", SqlDbType.Char, 10);
                    car_num.Value = Convert.ToString(dgvCarsales_info.SelectedRows[0].Cells[1].Value);
                    cmd.Parameters.Add(car_num);
                    SqlParameter amount = new SqlParameter("@amount", SqlDbType.Int);
                    amount.Value = Convert.ToInt32(warehouse_amount1 - sales_amount);//减数量
                    cmd.Parameters.Add(amount);
                    cmd.ExecuteNonQuery();
                    string sql = "select * from carsales_info";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(dataSet, "carsales_info");
                    dataSet.Tables["carsales_info"].Clear();
                    MessageBox.Show("操作成功！", "提示");
                    Display();

                }
                else
                {
                    MessageBox.Show("该车库存不够！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("请把表格数据全填写完整！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    //关闭数据连接对象
                }

            }
        }

        private void Sales_record_Load(object sender, EventArgs e)
        {
            Display();
            btnUpdate.Enabled = false;
            this.MaximizeBox = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)//返回主页面
        {
            Close();
            //如果主页最小化了，就调出来
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "Homepage")//如果传递的窗体名称参数已经存在
                {
                    frm.Activate();//激活已有窗体
                    if (frm.WindowState == FormWindowState.Minimized)//如果已有窗体被最小化了
                    {
                        frm.WindowState = FormWindowState.Normal;//恢复被最小化窗体的显示
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)//刷新功能
        {
            dataSet.Tables["carsales_info"].Clear();
            Display();
        }

        private void btnQuery_Click(object sender, EventArgs e)//查询功能
        {
            SqlConnection conn = new SqlLink().OpenSql();
            
            try
            {
                string sql = "";
                if (txtCarsales_name.Text == "" & txtCarsales_num.Text == "")
                {
                    MessageBox.Show("请先输入轿车名字或销售编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCarsales_num.Focus();
                    return;
                }
                else if (txtCarsales_num.Text != "" & txtCarsales_name.Text == "")
                {
                    sql = "select * from carsales_info where carsales_num='" + txtCarsales_num.Text + "'";
                }
                else if (txtCarsales_num.Text == "" & txtCarsales_name.Text != "")
                {
                    sql = "select * from carsales_info where car_name='" + txtCarsales_name.Text + "'";
                }
                else
                {
                    sql = "select * from carsales_info where carsales_num='" + txtCarsales_num.Text + "' and car_name='" + txtCarsales_name.Text + "'";
                }

                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                if(dataSet.Tables.Count==2)
                {
                    dataSet.Tables["carsales_info_query"].Clear();
                }
                sda.Fill(dataSet, "carsales_info_query");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名carsales_info_query
                dgvCarsales_info.DataSource = dataSet.Tables["carsales_info_query"];
                txtCarsales_name.Text = "";
                txtCarsales_num.Text = "";
            }
            catch
            {
                MessageBox.Show("查询出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    //关闭数据连接对象
                }

            }

        }

        private void dgvCarsales_info_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)//添加新记录时自动给默认值
        {
            try
            {
                btnUpdate.Enabled = true;
                int index =dataSet.Tables["carsales_info"].Rows.Count;
                e.Row.Cells["carsales_num"].Value = Convert.ToInt32(dgvCarsales_info.Rows[index-1].Cells["carsales_num"].Value) + 1;
                e.Row.Cells["carsales_handlernum"].Value = Mycookie.usernum;
                e.Row.Cells["carsales_date"].Value = DateTime.Now.ToShortDateString().ToString(); 
            }
            catch
            {
                MessageBox.Show("不允许此时填表！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
