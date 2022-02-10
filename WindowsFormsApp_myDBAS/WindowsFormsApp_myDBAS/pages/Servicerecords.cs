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
    public partial class Servicerecords : Form
    {

        DataSet dataSet = new DataSet(); //定义一个数据集
        public Servicerecords()
        {
            InitializeComponent();
        }

        private void dgvAftersales_servicerecords_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int index = dataSet.Tables["Aftersales_Servicerecords"].Rows.Count;
                e.Row.Cells["record_num"].Value = Convert.ToInt32(dgvAftersales_servicerecords.Rows[index - 1].Cells["record_num"].Value) + 1;
                e.Row.Cells["add_date"].Value = DateTime.Now.ToString("yyyy-MM-dd");//默认为当前系统日期yyyy/mm/dd的样式
            }
            catch
            {
                MessageBox.Show("不允许此时对表操作！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        public void Display()
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select * from Aftersales_Servicerecords";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "Aftersales_Servicerecords");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名comfirm_info
                dgvAftersales_servicerecords.DataSource = dataSet.Tables["Aftersales_Servicerecords"];
                for (int i = 0; i < dataSet.Tables["Aftersales_Servicerecords"].Rows.Count; i++)
                {
                    dgvAftersales_servicerecords.Rows[i].ReadOnly = true;
                }
            }
            catch
            {
                MessageBox.Show("初始加载服务记录表出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Servicerecords_Load(object sender, EventArgs e)
        {
            Display();
            this.MaximizeBox = false;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                for (int i = 0; i < dataSet.Tables["Aftersales_Servicerecords"].Rows.Count; i++)
                {
                    if (Convert.ToString(dataSet.Tables["Aftersales_Servicerecords"].Rows[i]["customer_num"]) == "")
                    {
                        MessageBox.Show("客户编号没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Convert.ToString(dataSet.Tables["Aftersales_Servicerecords"].Rows[i]["customer_name"]) == "")
                    {
                        MessageBox.Show("客户姓名没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (Convert.ToString(dataSet.Tables["Aftersales_Servicerecords"].Rows[i]["memo"]) == "")
                    {
                        MessageBox.Show("服务内容没填写！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                string sql = "select * from Aftersales_Servicerecords";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet, "Aftersales_Servicerecords");
                dataSet.Tables["Aftersales_Servicerecords"].Clear();
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                if (txtCustomer_name.Text == "")
                {
                    MessageBox.Show("请先输入客户姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string sql = "select * from Aftersales_Servicerecords where customer_name like '%" + txtCustomer_name.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                if(dataSet.Tables.Count==2)
                {
                    dataSet.Tables["Aftersales_Servicerecordsbyname"].Clear();
                }
                sda.Fill(dataSet, "Aftersales_Servicerecordsbyname");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中,并取名Customer_infoname
                dataSet.Tables["Aftersales_Servicerecords"].Clear();
                dgvAftersales_servicerecords.DataSource = dataSet.Tables["Aftersales_Servicerecordsbyname"];
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataSet.Tables["Aftersales_Servicerecords"].Clear();
            Display();
            txtCustomer_name.Text = "";
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
