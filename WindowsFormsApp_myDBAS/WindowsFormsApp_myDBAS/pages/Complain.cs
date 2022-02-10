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
    public partial class Complain : Form
    {
        DataSet dataSet = new DataSet(); //定义一个数据集
        public Complain()
        {
            InitializeComponent();
        }

        private void Complain_Load(object sender, EventArgs e)
        {
            Display();
            this.MaximizeBox = false;
        }

        public void Display()
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select * from Aftersales_Complain";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "Aftersales_Complain");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名comfirm_info
                dgvAftersales_complain.DataSource = dataSet.Tables["Aftersales_Complain"];
                for (int i = 0; i < dataSet.Tables["Aftersales_Complain"].Rows.Count; i++)
                {
                    dgvAftersales_complain.Rows[i].ReadOnly = true;
                }
            }
            catch
            {
                MessageBox.Show("初始加载投诉反馈表出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvAftersales_complain_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int index = dataSet.Tables["Aftersales_Complain"].Rows.Count;
                e.Row.Cells["complain_num"].Value = Convert.ToInt32(dgvAftersales_complain.Rows[index - 1].Cells["complain_num"].Value) + 1;
                e.Row.Cells["add_date"].Value = DateTime.Now.ToString("yyyy-MM-dd");//默认为当前系统日期yyyy/mm/dd的样式
            }
            catch
            {
                MessageBox.Show("不允许此时对表操作！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataSet.Tables["Aftersales_Complain"].Clear();
            Display();
            txtCustomer_name.Text = "";
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                if (txtCustomer_name.Text == "")
                {
                    MessageBox.Show("请先输入客户姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string sql = "select * from Aftersales_Complain where customer_name='" + txtCustomer_name.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "Aftersales_Complainbyname");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名Customer_infoname
                dgvAftersales_complain.DataSource = dataSet.Tables["Aftersales_Complainbyname"];
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                for (int i = 0; i < dataSet.Tables["Aftersales_Complain"].Rows.Count; i++)
                {
                    if (Convert.ToString(dataSet.Tables["Aftersales_Complain"].Rows[i]["customer_num"]) == "")
                    {
                        MessageBox.Show("客户编号没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Convert.ToString(dataSet.Tables["Aftersales_Complain"].Rows[i]["customer_name"]) == "")
                    {
                        MessageBox.Show("客户姓名没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Convert.ToString(dataSet.Tables["Aftersales_Complain"].Rows[i]["complain_type"]) == "")
                    {
                        MessageBox.Show("投诉类型没选择！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Convert.ToString(dataSet.Tables["Aftersales_Complain"].Rows[i]["complainmemo"]) == "")
                    {
                        MessageBox.Show("投诉内容没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Convert.ToString(dataSet.Tables["Aftersales_Complain"].Rows[i]["solution"]) == "")
                    {
                        MessageBox.Show("解决方案没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                string sql = "select * from Aftersales_Complain";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet, "Aftersales_Complain");
                dataSet.Tables["Aftersales_Complain"].Clear();
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
