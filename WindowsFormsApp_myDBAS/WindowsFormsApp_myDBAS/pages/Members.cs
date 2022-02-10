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
    public partial class Members : Form
    {

        DataSet dataSet = new DataSet(); //定义一个数据集
        public Members()
        {
            InitializeComponent();
        }
        public void Display()
        {
            SqlConnection conn = new SqlLink().OpenSql();
            string sql = "select distinct customer_info.customer_num,customer_info.customer_name,customer_info.customer_contact from customer_info,carsales_info where customer_info.customer_num=carsales_info.customer_num and customer_info.customer_num in(select customer_num from carsales_info except select customer_num from Aftersales_customerlist)";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(dataSet, "wait_info");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名comfirm_info
            dgvAftersales_customerwait.DataSource = dataSet.Tables["wait_info"];
            string sql1 = "select * from Aftersales_customerlist";
            SqlDataAdapter sda1 = new SqlDataAdapter(sql1, conn); 
            sda1.Fill(dataSet, "Aftersales_customerlist");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名comfirm_info
            dgvAftersales_customer.DataSource = dataSet.Tables["Aftersales_customerlist"];
            if (conn != null)
            {
                conn.Close();
                //关闭数据连接对象
            }
        }

        private void Members_Load(object sender, EventArgs e)
        {
            Display();
            panelwaitfor.Visible = false;

            this.MaximizeBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            panelwaitfor.Visible = false;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                for (int i = 0; i < dataSet.Tables["Aftersales_customerlist"].Rows.Count; i++)
                {
                    if (Convert.ToString(dataSet.Tables["Aftersales_customerlist"].Rows[i]["customer_num"]) == "")
                    {
                        MessageBox.Show("客户编号没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Convert.ToString(dataSet.Tables["Aftersales_customerlist"].Rows[i]["customer_name"]) == "")
                    {
                        MessageBox.Show("客户姓名没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Convert.ToString(dataSet.Tables["Aftersales_customerlist"].Rows[i]["customer_contact"]) == "")
                    {
                        MessageBox.Show("联系方式没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                string sql = "select * from Aftersales_customerlist";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet, "Aftersales_customerlist");
                dataSet.Tables["wait_info"].Clear();
                dataSet.Tables["Aftersales_customerlist"].Clear();
                MessageBox.Show("操作成功！", "提示");
                Display();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void dgvAftersales_customer_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["add_date"].Value = DateTime.Now.ToString("yyyy-MM-dd");//默认为当前系统日期yyyy/mm/dd的样式
            e.Row.Cells["servicetime"].Value = "2年";//默认为当前系统日期yyyy/mm/dd的样式
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {   
                string sql = "";
                if (txtCustomer_name.Text=="")
                {
                    sql = "select * from Aftersales_customerlist ";
                }
                else
                {
                    sql = "select * from Aftersales_customerlist where customer_name like '%" + txtCustomer_name.Text + "%'";
                }
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                if (dataSet.Tables.Count == 3)
                {
                    dataSet.Tables["Customer_infoname"].Clear();
                }
                sda.Fill(dataSet, "Customer_infoname");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名Customer_infoname
                dgvAftersales_customer.DataSource = dataSet.Tables["Customer_infoname"];
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
            txtCustomer_name.Text = "";
        }

        private void btnQuery_Click_1(object sender, EventArgs e)
        {
            panelwaitfor.Visible = true;
            lblWaite_tips.Visible = false;
            dgvAftersales_customerwait.Visible = false;
            lblMember.Visible = true;
            txtCustomer_name.Visible = true;
            btnSearch.Visible = true;
        }

        private void btnQuery_waite_Click(object sender, EventArgs e)
        {

            if (dataSet.Tables["wait_info"].Rows.Count == 0)
            {
                MessageBox.Show("没有待出库的记录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelwaitfor.Visible = false;
                return;

            }
            panelwaitfor.Visible = true;
            lblWaite_tips.Visible = true;
            dgvAftersales_customerwait.Visible = true;
            lblMember.Visible = false;
            txtCustomer_name.Visible = false;
            btnSearch.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = string.Format("delete from Aftersales_customerlist where customer_num='{0}'", dgvAftersales_customer.SelectedRows[0].Cells[0].Value);
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("记录已从数据库删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataSet.Tables["Aftersales_customerlist"].Clear();
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

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnSearch, "姓名可模糊查询！");
        }


    }

}
