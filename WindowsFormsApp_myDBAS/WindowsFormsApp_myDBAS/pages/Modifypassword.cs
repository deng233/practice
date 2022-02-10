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
    public partial class Modifypassword : Form
    {
        public Modifypassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void txtConfirmpassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewpassword.Text != txtConfirmpassword.Text)
            {
                lblConfirmTips.Text = "密码前后不一致";
                txtConfirmpassword.Focus();
                btnConfirm.Enabled = false;
            }

            else
            {
                lblConfirmTips.Text = "";
                btnConfirm.Enabled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {               
                if(txtOldpassword.Text=="")
                {
                    MessageBox.Show("旧密码还未填写！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(txtOldpassword.Text != Mycookie.password)
                {
                    MessageBox.Show("旧密码不匹配！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOldpassword.Focus();

                }
                else if(txtNewpassword.Text == Mycookie.password)
                {
                    MessageBox.Show("不能与旧密码一样！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOldpassword.Focus();
                }
                else if(txtNewpassword.Text=="")
                {
                    MessageBox.Show("请设置新密码！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewpassword.Focus();
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("Setpassword", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter num = new SqlParameter("@num", SqlDbType.Char, 10);
                    num.Direction = ParameterDirection.Input;
                    num.Value = Convert.ToString(Mycookie.usernum);
                    cmd.Parameters.Add(num);                   
                    SqlParameter password = new SqlParameter("@password", SqlDbType.VarChar, 20);
                    password.Direction = ParameterDirection.Input;
                    password.Value = Convert.ToString(txtNewpassword.Text);
                    cmd.Parameters.Add(password);
                    if(cmd.ExecuteNonQuery()==0)
                    {
                        MessageBox.Show("修改失败！","系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (MessageBox.Show("修改成功！请重新登录", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Application.Restart();
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

        private void Modifypassword_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;        //关闭登录窗口的最大化功能
        }
    }
}
