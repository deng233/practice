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
    public partial class Employee_management : Form
    {
        DataSet dataSet = new DataSet(); //定义一个数据集
        public Employee_management()
        {
            InitializeComponent();
        }
        public void Display()
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "";
                if (Mycookie.department == "董事会")
                {
                    sql = "select * from employee_info where position <> 'CEO'";
                }
                else
                {
                    sql = "select * from employee_info where department ='" + Mycookie.department + "'and position='职工'";

                }
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "employee_info");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中
                Bind_data(dataSet.Tables["employee_info"]);
            }
            catch
            {
                MessageBox.Show("初始加载职工表出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Employee_management_Load(object sender, EventArgs e)
        {
            Display();

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

        private void btnRefresh_Click(object sender, EventArgs e)//刷新
        {
            
            dataSet.Tables["employee_info"].Clear();
            Display();
            txtEmployee_name.Text = "";
            txtEmployee_num.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                if(Mycookie.department!="董事会")
                {
                    for (int i = 0; i < dataSet.Tables["employee_info"].Rows.Count; i++)
                    {
                        if (Convert.ToString(dataSet.Tables["employee_info"].Rows[i]["position"]) != "主管")
                        {
                            MessageBox.Show("主管没有权限任命职工为主管！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                string sql = "select * from employee_info";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet, "employee_info");
                MessageBox.Show("操作成功！", "提示");
            }
            catch
            {
                MessageBox.Show("工号，姓名，登录密码，部门，职位和学历都不允许为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnDelete_Click(object sender, EventArgs e)//删除功能
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = string.Format("delete from employee_info where employee_num='{0}'", dgvEmployee_info.SelectedRows[0].Cells[0].Value);
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("记录已从数据库删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataSet.Tables["employee_info"].Clear();
                btnRefresh_Click(sender, e);
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
        public void Bind_data(DataTable tablename)//设置Datagridview的属性
        {
            dgvEmployee_info.DataSource =tablename;//设置表格控件的DataSource属性,自定义datagridview
            dgvEmployee_info.Columns[0].HeaderText = "工号";
            dgvEmployee_info.Columns[0].ReadOnly = true;
            dgvEmployee_info .Columns[1].HeaderText = "职工姓名";
            dgvEmployee_info.Columns[2].HeaderText = "登录密码";
            dgvEmployee_info.Columns[3].HeaderText = "年龄";
            dgvEmployee_info.Columns[4].HeaderText = "性别";
            dgvEmployee_info.Columns[5].HeaderText = "部门";
            if(Mycookie.department!="董事会")
            {
                dgvEmployee_info.Columns[5].ReadOnly = true;
            }
            dgvEmployee_info.Columns[6].HeaderText = "职位";
            dgvEmployee_info.Columns[7].HeaderText = "学历";
            dgvEmployee_info.Columns[8].HeaderText = "籍贯";
            dgvEmployee_info.BackgroundColor = Color.White;
            dgvEmployee_info.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//整行选中
        }

        private void btnQuery_Click(object sender, EventArgs e)//查询功能
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "";//定义sql语句
                if (txtEmployee_name.Text == "" && txtEmployee_num.Text == "")
                {
                    sql = "select * from employee_info where department ='" + Mycookie.department + "'and position='职工'";
                }
                else if (txtEmployee_name.Text != "" && txtEmployee_num.Text == "")
                {
                    sql = "select * from employee_info where department ='" + Mycookie.department + "'and position='职工' and employee_name like '%" + txtEmployee_name.Text + "%'";
                }
                else if (txtEmployee_name.Text == "" && txtEmployee_num.Text != "")
                {
                    sql = "select * from employee_info where department ='" + Mycookie.department + "'and position='职工' and employee_num='" + txtEmployee_num.Text + "'";
                }
                else
                {
                    sql = "select * from employee_info where department ='" + Mycookie.department + "'and position='职工' and employee_num='" + txtEmployee_num.Text + "' and employee_name='" + txtEmployee_name.Text + "'";
                }
                if (Mycookie.department == "董事会")
                {
                    if (txtEmployee_name.Text == "" && txtEmployee_num.Text == "")
                    {
                        sql = "select * from employee_info where position <> 'CEO'";
                    }
                    else
                    {
                        sql = sql.Replace("department ='" + Mycookie.department + "'and position='职工' and ", " ");
                    }

                }
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                //处理刷新问题
                if (dataSet.Tables.Count == 2)
                    dataSet.Tables["Employee_infoquery"].Clear();
                sda.Fill(dataSet, "Employee_infoquery");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中
                Bind_data(dataSet.Tables["Employee_infoquery"]);
                txtEmployee_name.Clear();
                txtEmployee_num.Clear();
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

        private void dgvEmployee_info_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)//增加新职工时设定默认值
        {
            try
            {
                if(Mycookie.department!="董事会")
                {
                    int index = dataSet.Tables["employee_info"].Rows.Count;
                    e.Row.Cells["employee_num"].Value = Convert.ToInt32(dgvEmployee_info.Rows[index - 1].Cells["employee_num"].Value) + 1;
                    e.Row.Cells["department"].Value = Mycookie.department;

                }
            }
            catch
            {
                MessageBox.Show("不允许此时增加职工！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
