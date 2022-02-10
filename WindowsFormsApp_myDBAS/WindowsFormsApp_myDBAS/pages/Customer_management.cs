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
    public partial class Customer_management : Form
    {
        
        DataSet dataSet = new DataSet(); //定义一个数据集
        public Customer_management()
        {
            InitializeComponent();
        }

        private void Customer_management_Load(object sender, EventArgs e)
        {
            Display();
            btnUpdate.Enabled = false;
            this.MaximizeBox = false;
        }
        public void Display()//加载客户表
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select * from customer_info";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "Customer_info");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名Customer_info
                dgvCustomer_info.DataSource = dataSet.Tables["Customer_info"];
            }
            catch
            {
                MessageBox.Show("加载客户表出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnReturn_Click(object sender, EventArgs e)//返回
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = string.Format("delete from customer_info where customer_num='{0}'", dgvCustomer_info.SelectedRows[0].Cells[0].Value);
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("记录已从数据库删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataSet.Tables["Customer_info"].Clear();
                Display();
                txtCustomer_name.Text = "";
            }
            catch
            {
                MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRefresh_Click(object sender, EventArgs e)//刷新页面
        {
            dataSet.Tables["Customer_info"].Clear();
            Display();
            txtCustomer_name.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select * from customer_info";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet, "customer_info");
                dataSet.Tables["Customer_info"].Clear();
                MessageBox.Show("操作成功！", "提示");
                Display();
            }
            catch
            {
                MessageBox.Show("客户姓名和联系方式要填写完整！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if(txtCustomer_name.Text=="")
            {
                MessageBox.Show("请先输入客户姓名！", "提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select * from customer_info where customer_name like '%" + txtCustomer_name.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                if (dataSet.Tables.Count == 2)
                {
                    dataSet.Tables["Customer_infoname"].Clear();
                }
                sda.Fill(dataSet, "Customer_infoname");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名Customer_infoname
                dataSet.Tables["customer_info"].Clear();
                dgvCustomer_info.DataSource = dataSet.Tables["Customer_infoname"];

            }
            catch
            {
                MessageBox.Show("查询失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtCustomer_name.Text = "";
                if (conn != null)
                {
                    conn.Close();
                    //关闭数据连接对象
                }

            }
      
        }

        private void dgvCustomer_info_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int index = dataSet.Tables["Customer_info"].Rows.Count;
                e.Row.Cells["customer_num"].Value = Convert.ToInt32(dgvCustomer_info.Rows[index - 1].Cells["customer_num"].Value) + 1;
            }
            catch 
            {
                MessageBox.Show("不允许这时增加客户", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void dgvCustomer_info_CellLeave(object sender, DataGridViewCellEventArgs e)//识别编辑后才启用更新按钮
        {
            btnUpdate.Enabled = true;
        }

        private void btnQuery_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnQuery, "姓名可模糊查询！");
        }
    }
}


