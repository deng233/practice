using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp_myDBAS
{
    public partial class Login : Form
    {
        DataSet dataSet = new DataSet();

        public Login()
        {
            InitializeComponent();
            timer1.Enabled = true;//启动计时器
            timer1.Interval = 1000;//设置time1_Tick方法执行时间间隔为1秒；
        }
        private void timer1_Tick(object sender, EventArgs e)//获取时间
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;        //关闭登录窗口的最大化功能
            lblCode.Text = Verification.Code();  //动态生成验证码
            btnLogin.Enabled = false;    //默认在不输入验证码时无法点击登录按钮
            Binddepartment();
        }
        public void Binddepartment()//绑定部门数据
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                
                string sql = "select distinct department 部门 from employee_info";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "department");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中
                cboDepartment.DataSource = dataSet.Tables["department"];
                cboDepartment.DisplayMember = "部门";
            }
            catch
            {
                MessageBox.Show("绑定部门出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnLogin_Click(object sender, EventArgs e)//进行登录操作
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {

                if (txtEmployeename.Text == "" & txtPassword.Text == "")
                {
                    MessageBox.Show("用户名和密码都没填写！！");   //为空时候给出的提示信息
                    SetCodeEmpty();
                    txtEmployeename.Focus();
                }
                else if (txtEmployeename.Text == "")    //判断输入的用户名和密码是否为空
                {
                    MessageBox.Show("用户名还没填写！！");   //为空时候给出的提示信息
                    SetCodeEmpty();
                    txtEmployeename.Focus();
                }
                
                else if (txtPassword.Text == "")
                {
                    MessageBox.Show("密码还没填写！！","提示");   //为空时候给出的提示信息
                    SetCodeEmpty();
                    txtPassword.Focus();
                }
                else
                {
                    
                    SqlCommand cmd = new SqlCommand("Login", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter user = new SqlParameter("@user", SqlDbType.VarChar, 30);
                    user.Value = Convert.ToString(txtEmployeename.Text);
                    cmd.Parameters.Add(user);
                    SqlParameter department = new SqlParameter("@department", SqlDbType.VarChar,15);
                    department.Value = Convert.ToString(cboDepartment.Text);

                    cmd.Parameters.Add(department);
                    SqlParameter password = new SqlParameter("@password", SqlDbType.VarChar, 20);
                    password.Direction = ParameterDirection.Output;//pPassword的方向为ParameterDirection.Output。
                    cmd.Parameters.Add(password);
                    cmd.ExecuteNonQuery(); 
                    if (Convert.ToString(cmd.Parameters["@password"].Value) == txtPassword.Text)
                    {
                        /*保存登录用户信息*/
                        Mycookie.username = txtEmployeename.Text;
                        Mycookie.password = txtPassword.Text;
                        Mycookie.department = cboDepartment.Text;
                        //设置当前窗口不可见
                        Homepage homepage = new Homepage();
                        homepage.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的账户,密码和部门！");
                        //抛出预设错误信息对话框
                        txtPassword.Clear();
                        SetCodeEmpty();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //抛出异常处理信息
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

        private void lblCode_Click(object sender, EventArgs e)//点击->刷新验证码
        {
            lblCode.Text = Verification.Code();
            btnLogin.Enabled = false;
            txtCode.Text = "";
            lblTips.Text = "";
        }
        public void SetCodeEmpty()//置空验证码输入框
        {
            lblCode.Text = Verification.Code();
            btnLogin.Enabled = false;
            txtCode.Text = "";
            lblTips.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)//退出
        {
            Close();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)//验证码校验
        {
            if (txtCode.Text == lblCode.Text)
            {

                lblTips.Text = "";
                btnLogin.Enabled = true;
            }
            else
            {
                lblTips.Text = "验证码错误！";
                btnLogin.Enabled = false;
            }
        }

    }

}
