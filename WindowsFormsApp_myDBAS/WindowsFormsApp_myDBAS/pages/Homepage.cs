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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            
            InitializeComponent();
            timer1.Enabled = true;//启动计时器
            timer1.Interval = 1000;//设置time1_Tick方法执行时间间隔为1秒
        }
        private void timer1_Tick(object sender, EventArgs e)//获取时间
        {
            lblTime.Text = DateTime.Now.ToString();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

            MaximizeBox = false;        //关闭窗口的最大化功能
            WarehouseMenuItem.Visible = false;//隐藏仓库部门的功能菜单
            SaleMenuItem.Visible = false;//隐藏销售部门的功能菜单
            AftersaleMenuItem.Visible = false;//隐藏售后部门的功能菜单
            /*标识设置隐藏*/
            pictureBoxEmployee.Visible = false;
            pictureBoxHead.Visible = false;
            pictureBoxCEO.Visible = false;
            pictureBoxDepartment_warehouse.Visible = false;
            pictureBoxDepartment_sale.Visible = false;
            pictureBoxDepartment_aftersale.Visible = false;
            pictureBoxDepartment_CEO.Visible = false;
            /*隐藏部门主管功能*/
            Department_managerMenuItem.Visible = false;
            Sales_statistic_analysisMenuItem.Visible = false;
            Getnum();//获取登录用户的编号
            Getposition();//获取登录用户的具体职位
            label_temp.Text = Mycookie.username +Mycookie.position+",欢迎您使用本系统！";
            if(Mycookie.position =="CEO" | Mycookie.position =="主管")//修改用户名的功能只开放给主管和CEO
            { 
                ModifyNameMenuItem.Visible= true;
            }
            if (Mycookie.position == "主管" && Mycookie.department == "销售部门")//销售部门主管的特有功能统计数据
            {
                Sales_statistic_analysisMenuItem.Visible = true;
            }
            /*识别职位，显示对应标识*/
            if (Mycookie.position=="职工")
            {
                pictureBoxEmployee.Visible = true;
            }
            else if(Mycookie.position=="主管")
            {
                pictureBoxHead.Visible = true;
                Department_managerMenuItem.Visible = true;
            }
            else if(Mycookie.position=="CEO")
            {
                pictureBoxCEO.Visible = true;
                Department_managerMenuItem.Visible = true;
                Sales_statistic_analysisMenuItem.Visible = true;
            }
            /*识别部门，显示对应功能*/
            if (Mycookie.department == "仓库部门")
            {
                WarehouseMenuItem.Visible = true;
                pictureBoxDepartment_warehouse.Visible = true;
            }
            else if (Mycookie.department == "销售部门")
            {
                SaleMenuItem.Visible = true;
                pictureBoxDepartment_sale.Visible = true;
            }
            else if (Mycookie.department == "售后部门")
            {
                AftersaleMenuItem.Visible = true;
                pictureBoxDepartment_aftersale.Visible = true;
            }
            else
            {
                WarehouseMenuItem.Visible = true;
                SaleMenuItem.Visible = true;
                AftersaleMenuItem.Visible = true;
                pictureBoxDepartment_CEO.Visible = true;
            }

        }
        public void Getnum()//获取登录用户的编号
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                SqlCommand cmd = new SqlCommand("Getnum", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter user = new SqlParameter("@user", SqlDbType.VarChar, 30);
                user.Direction = ParameterDirection.Input;
                user.Value = Convert.ToString(Mycookie.username);
                cmd.Parameters.Add(user);
                SqlParameter password = new SqlParameter("@password", SqlDbType.VarChar, 20);
                password.Direction = ParameterDirection.Input;
                password.Value = Convert.ToString(Mycookie.password);
                cmd.Parameters.Add(password);
                SqlParameter num = new SqlParameter("@num", SqlDbType.Char, 10);
                num.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(num);
                cmd.ExecuteNonQuery();
                Mycookie.usernum = Convert.ToString(cmd.Parameters["@num"].Value);
            }
            catch
            {
                MessageBox.Show("获取登录用户的编号失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void  Getposition()//获取登录用户的具体职位
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                SqlCommand cmd = new SqlCommand("Getposition", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter num = new SqlParameter("@num", SqlDbType.Char, 10);
                num.Direction = ParameterDirection.Input;
                num.Value = Mycookie.usernum;
                cmd.Parameters.Add(num);
                SqlParameter position = new SqlParameter("@position", SqlDbType.VarChar, 15);
                position.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(position);
                cmd.ExecuteNonQuery();
                Mycookie.position = Convert.ToString(cmd.Parameters["@position"].Value);
            }
            catch
            {
                MessageBox.Show("获取登录用户的具体职位失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)//关闭所有已打开的窗口，确保完全退出系统
        {
            Application.Exit();

        }

        private void ExitpMenuItem_Click(object sender, EventArgs e)//退出系统
        {
            Close();

        }

        public Boolean ShowOpenForm(string frmName)//校验每个窗体只能打开一个
        {
            //Application .OpenForms为已打开的窗体
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == frmName)//如果传递的窗体名称参数已经存在
                {
                    frm.Activate();//激活已有窗体
                    if (frm.WindowState == FormWindowState.Minimized)//如果已有窗体被最小化了
                    {
                        frm.WindowState = FormWindowState.Normal;//恢复被最小化窗体的显示
                    }
                    return false;//返回false说明窗体已打开
                }
            }
            return true;//已打开的窗体里没有作为参数传递的窗体，则返回true
        }

        private void SetPasswordMenuItem_Click(object sender, EventArgs e)//跳转修改密码的页面
        {
            if(ShowOpenForm("Modifypassword"))
            {
                Modifypassword modifypassword = new Modifypassword();
                modifypassword.Show();
            }

        }


        private void ModifyNameMenuItem_Click(object sender, EventArgs e)//跳转修改用户名的页面
        {

            if (ShowOpenForm("ModifyName"))
            {
                ModifyName modifyName = new ModifyName();
                modifyName.Show();
            }

        }

        private void Warehouse_inMenuItem_Click(object sender, EventArgs e)//跳转入库管理的页面
        {

            if (ShowOpenForm("Warehouse_in"))
            {
                Warehouse_in warehouse_In = new Warehouse_in();
                warehouse_In.Show();
            }
          
        }

        private void Warehouse_outMenuItem_Click(object sender, EventArgs e)//跳转出库管理的页面
        {

            if (ShowOpenForm("Warehouse_out"))
            {
                Warehouse_out warehouse_out = new Warehouse_out();
                warehouse_out.Show();
            }
            
        }

        private void Warehouse_queryMenuItem_Click(object sender, EventArgs e)//跳转仓库情况的页面
        {
            if (ShowOpenForm("Warehouse_query"))
            {
                Warehouse_query warehouse_Query = new Warehouse_query();
                warehouse_Query.Show();
            }
        }

        private void Customer_managementMenuItem_Click(object sender, EventArgs e)//跳转客户管理的页面
        {
            if(ShowOpenForm("Customer_management"))
            {
                Customer_management customer_Management = new Customer_management();
                customer_Management.Show();
            }
           
        }

        private void Sales_recordMenuItem_Click(object sender, EventArgs e)//跳转销售记录的页面
        {
            if(ShowOpenForm("Sales_record"))
            {
                Sales_record sales_record = new Sales_record();
                sales_record.Show();
            }

        }

        private void 查看库存ToolStripMenuItem_Click(object sender, EventArgs e)//跳转查看库存的页面
        {
            if(ShowOpenForm("Warehouse_query"))
            {
                Warehouse_query warehouse_Query = new Warehouse_query();
                warehouse_Query.Show();
            }
            
        }

        private void Personal_performanceMenuItem_Click(object sender, EventArgs e)//跳转个人绩效的页面
        {
            if(ShowOpenForm("Personal_performance"))
            {
                Personal_performance personal_Performance = new Personal_performance();
                personal_Performance.Show();
            }
            
        }

        private void MembersMenuItem_Click(object sender, EventArgs e)//跳转售后会员管理的页面
        {
            if(ShowOpenForm("Members"))
            {
                Members members = new Members();
                members.Show();
            }

        }

        private void ServicerecordsMenuItem_Click(object sender, EventArgs e)//跳转服务记录的页面
        {
            if(ShowOpenForm("Servicerecords"))
            {
                Servicerecords servicerecords = new Servicerecords();
                servicerecords.Show();
            }
            
        }

        private void ComplainMenuItem_Click(object sender, EventArgs e)//跳转投诉反馈的页面
        {
            if(ShowOpenForm("Complain"))
            {
                Complain complain = new Complain();
                complain.Show();
            }
            
        }

        private void Employee_managementMenuItem_Click(object sender, EventArgs e)//跳转职工管理的页面
        {
            if(ShowOpenForm("Employee_management"))
            {
                Employee_management employee_Management = new Employee_management();
                employee_Management.Show();
            }

        }

        private void Sales_statistic_analysisMenuItem_Click(object sender, EventArgs e)//跳转销售--统计分析的页面
        {
            if(ShowOpenForm("Sales_statistic_analysis"))
            {
                Sales_statistic_analysis sales_Statistic_Analysis = new Sales_statistic_analysis();
                sales_Statistic_Analysis.Show();
            }
            
        }

        
    }
}
