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
    public partial class ModifyName : Form
    {
        public ModifyName()
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                if (txtNewname.Text == "")
                {
                    MessageBox.Show("新用户名还未填写！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewname.Focus();
                }
                else if(txtNewname.Text==Mycookie.username)
                {
                    MessageBox.Show("不能与原来的用户名一样！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNewname.Text = "";
                    txtNewname.Focus();
                }
                
                else
                {

                    SqlCommand cmd = new SqlCommand("Setname", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter num = new SqlParameter("@num", SqlDbType.Char, 10);
                    num.Direction = ParameterDirection.Input;
                    num.Value = Convert.ToString(Mycookie.usernum);
                    cmd.Parameters.Add(num);
                    SqlParameter name  = new SqlParameter("@name", SqlDbType.VarChar, 30);
                    name.Direction = ParameterDirection.Input;
                    name.Value = Convert.ToString(txtNewname.Text);
                    cmd.Parameters.Add(name);
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("修改失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if(MessageBox.Show("修改成功！请重新登录", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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

        private void ModifyName_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;        //关闭登录窗口的最大化功能
        }
    }
}
