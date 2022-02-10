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
    public partial class Warehouse_out : Form
    {
        DataSet dataSet = new DataSet(); //定义一个数据集
        int counter = 0;//标志是否第一次加载
        public Warehouse_out()
        {
            InitializeComponent();
        }

        private void Warehouse_out_Load(object sender, EventArgs e)
        {
            Display();
            panelwaitfor_out.Visible = false;
            btnUpdate.Enabled = false;//一开始默认使更新按钮不可用
            this.MaximizeBox = false;
        }
        public void Display()//加载出库记录表
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select distinct Warehouse_in.Warehouse_innum, carsales_info.car_num,carsales_info.amount,carsales_info.carsales_num from Warehouse_in,carsales_info,warehouse_out where carsales_info.car_num = Warehouse_in.car_num and carsales_info.carsales_num in (select carsales_num from carsales_info except select carsales_num from Warehouse_out)";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "comfirm_info");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名comfirm_info
                dgvWarehouse_out_confirm.DataSource = dataSet.Tables["comfirm_info"];
                if (dataSet.Tables["comfirm_info"].Rows.Count == 0 & counter != 0)
                {
                    MessageBox.Show("已经处理完待出库的记录了！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelwaitfor_out.Visible = false;
                }
                string sql1 = "select * from warehouse_out";
                SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn);
                sda1.Fill(dataSet, "warehouse_out");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名comfirm_info
                dgvWarehouse_out.DataSource = dataSet.Tables["warehouse_out"];
                for (int i = 0; i < dataSet.Tables["warehouse_out"].Rows.Count; i++)
                {
                    dgvWarehouse_out.Rows[i].ReadOnly = true;
                }
                counter += 1;
            }
            catch
            {
                MessageBox.Show("加载出库记录表出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnQuery_Click(object sender, EventArgs e)//查看待出库记录
        {
            if(dataSet.Tables["comfirm_info"].Rows.Count==0)
            {
                MessageBox.Show("没有待出库的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelwaitfor_out.Visible = false;
                return;

            }
            panelwaitfor_out.Visible = true;
            lblSales_num.Visible = false;
            txtSales_num.Visible = false;
            btnSearch.Visible = false;
            lblWaite_tips.Visible = true;
            dgvWarehouse_out_confirm.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)//更新
        {

            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                //判断是不是新添加的记录
                if (dgvWarehouse_out.CurrentRow.Index + 2 <= dataSet.Tables["warehouse_out"].Rows.Count)
                {
                    MessageBox.Show("只能用来插入新数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string sql = "select * from warehouse_out";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet, "warehouse_out");
                dataSet.Tables["warehouse_out"].Clear();
                dataSet.Tables["comfirm_info"].Clear();
                MessageBox.Show("操作成功！", "提示");
                Display();
            }
            catch
            {
                MessageBox.Show("请填写完整！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelwaitfor_out.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
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

        private void dgvWarehouse_out_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)//增加新行时自动设默认值
        {
            try
            {
                int index = dataSet.Tables["warehouse_out"].Rows.Count;
                e.Row.Cells["Warehouse_outnum"].Value = Convert.ToInt32(dgvWarehouse_out.Rows[index - 1].Cells["Warehouse_outnum"].Value) + 1;
                e.Row.Cells["date"].Value = DateTime.Now.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("不允许此时对表操作");
            }
            
            
        }

        private void dgvWarehouse_out_RowEnter(object sender, DataGridViewCellEventArgs e)//有待出库的记录时启用更新按钮
        {
            if (dataSet.Tables["comfirm_info"].Rows.Count == 0 & counter != 0)
            {
                btnUpdate.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
            }
        }

        private void btnQuerybynum_Click(object sender, EventArgs e)
        {
            panelwaitfor_out.Visible = true;
            lblSales_num.Visible = true;
            txtSales_num.Visible = true;
            btnSearch.Visible = true;
            lblWaite_tips.Visible = false;
            dgvWarehouse_out_confirm.Visible = false;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "";
                if (txtSales_num.Text == "")
                {
                    sql = "select * from  warehouse_out";
                }
                else
                {
                    sql = "select * from warehouse_out where carsales_num = '" + txtSales_num.Text + "'";
                }
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                if (dataSet.Tables.Count == 3)
                {
                    dataSet.Tables["warehouse_out_query"].Clear();
                }
                sda.Fill(dataSet, "warehouse_out_query");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名Customer_infoname
                dgvWarehouse_out.DataSource = dataSet.Tables["warehouse_out_query"];
                txtSales_num.Text = "";
            }
            catch
            {
                MessageBox.Show("查询失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
