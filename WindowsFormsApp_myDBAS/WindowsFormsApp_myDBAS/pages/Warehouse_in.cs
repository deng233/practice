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
    public partial class Warehouse_in : Form
    {
        DataSet dataSet = new DataSet(); //定义一个数据集
        public Warehouse_in()
        {
            InitializeComponent();
        }

        private void Warehouse_in_Load(object sender, EventArgs e)
        {
            panel_Feedback.Visible = false;//隐藏后续反馈
            MaximizeBox = false;        //关闭窗口的最大化功能
            btnSubmit.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)//提交
        {
            
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                for (int i = 0; i < dgvCar_info.CurrentRow.Cells.Count; i++)
                {
                    if (Convert.ToString(dgvCar_info[i, 0].Value) == "")
                    {
                        MessageBox.Show("请填写完整！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                SqlCommand cmd = new SqlCommand("car_info_insert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter car_num = new SqlParameter("@car_num", SqlDbType.Char, 10);
                car_num.Value = Convert.ToString(dgvCar_info["car_num", 0].Value);
                cmd.Parameters.Add(car_num);
                SqlParameter car_name = new SqlParameter("@car_name", SqlDbType.VarChar, 15);
                car_name.Value = Convert.ToString(dgvCar_info["car_name", 0].Value);
                cmd.Parameters.Add(car_name);
                SqlParameter car_type = new SqlParameter("@car_type", SqlDbType.Char, 15);
                car_type.Value = Convert.ToString(dgvCar_info["car_type", 0].Value);
                cmd.Parameters.Add(car_type);
                SqlParameter car_color = new SqlParameter("@car_color", SqlDbType.Char, 12);
                car_color.Value = Convert.ToString(dgvCar_info["car_color", 0].Value);
                cmd.Parameters.Add(car_color);
                SqlParameter car_manufacturer = new SqlParameter("@car_manufacturer", SqlDbType.VarChar, 30);
                car_manufacturer.Value = Convert.ToString(dgvCar_info["car_manufacturer", 0].Value);
                cmd.Parameters.Add(car_manufacturer);
                SqlParameter car_dateofmanufacture = new SqlParameter("@car_dateofmanufacture", SqlDbType.Date);
                car_dateofmanufacture.Value = Convert.ToString(dgvCar_info["car_dateofmanufacture", 0].Value);
                cmd.Parameters.Add(car_dateofmanufacture);
                SqlParameter car_price = new SqlParameter("@car_price", SqlDbType.Decimal,10);
                car_price.Precision = 10;
                car_price.Scale = 2;//相当于数据库的decimal(10,2)
                car_price.Value = Convert.ToString(dgvCar_info["car_price", 0].Value);
                cmd.Parameters.Add(car_price);
                SqlParameter car_amount = new SqlParameter("@car_amount", SqlDbType.VarChar, 30);
                car_amount.Value = Convert.ToString(dgvCar_info["car_amount", 0].Value);
                cmd.Parameters.Add(car_amount);
                if (cmd.ExecuteNonQuery()!= 0  & MessageBox.Show("提交成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information)==DialogResult.OK)
                {
                    
                    SqlCommand cmdIn = new SqlCommand("warehouse_inproc", conn);//自动入库
                    cmdIn.CommandType = CommandType.StoredProcedure;
                    SqlParameter car_numIn = new SqlParameter("@car_num", SqlDbType.Char, 10);
                    car_numIn.Value = Convert.ToString(dgvCar_info["car_num", 0].Value);
                    cmdIn.Parameters.Add(car_numIn);
                    SqlParameter car_amountIn = new SqlParameter("@amount", SqlDbType.VarChar, 30);
                    car_amountIn.Value = Convert.ToInt32(dgvCar_info["car_amount", 0].Value);
                    cmdIn.Parameters.Add(car_amountIn);
                    SqlParameter myinnum  = new SqlParameter("@myinnum", SqlDbType.Int);
                    myinnum.Value = Convert.ToString(dgvCar_info["warehouse_innumfirst", 0].Value);
                    cmdIn.Parameters.Add(myinnum);
                    cmdIn.ExecuteNonQuery();
                    SqlCommand cmdselect = new SqlCommand("Getwarehouse_innum", conn);//验证是否入库了，没有报错就确定是成功的
                    cmdselect.CommandType = CommandType.StoredProcedure;
                    SqlParameter car_numS = new SqlParameter("@car_num", SqlDbType.Char, 10);
                    car_numS.Value = Convert.ToString(dgvCar_info["car_num", 0].Value);
                    cmdselect.Parameters.Add(car_numS);
                    SqlParameter warehouse_innum = new SqlParameter("@warehouse_innum", SqlDbType.Int);
                    warehouse_innum.Direction = ParameterDirection.Output;
                    cmdselect.Parameters.Add(warehouse_innum);
                    if (cmdselect.ExecuteNonQuery() == 0)
                    { MessageBox.Show("入库记录失败"); }
                    else
                    {
                        /*反馈*/
                        string sql = "select * from Warehouse_in where car_num='"+Convert.ToString(dgvCar_info["car_num", 0].Value)+"'";
                        SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                        sda.Fill(dataSet, "warehouse_in");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中
                        dgvFeedbacktable.DataSource = dataSet.Tables["warehouse_in"];
                        dgvFeedbacktable.CurrentCell = null;
                        panel_Feedback.Visible = true;
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(panel_Feedback.Visible==true)
            {
                btnFeedbackconfirm_Click(sender, e);
            }
            else
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
            
        }

        private void btnFeedbackconfirm_Click(object sender, EventArgs e)//再次提交，清空填写的数据
        {
            dgvCar_info["car_num", 0].Value= "";
            dgvCar_info["car_name", 0].Value = "";
            dgvCar_info["car_type", 0].Value = "";
            dgvCar_info["car_color", 0].Value = "";
            dgvCar_info["car_manufacturer", 0].Value = "";
            dgvCar_info["car_dateofmanufacture", 0].Value = "";
            dgvCar_info["car_price", 0].Value = "";
            dgvCar_info["car_amount", 0].Value = "";
            dgvCar_info["warehouse_innumfirst", 0].Value = "";
            panel_Feedback.Visible = false;
        }

        private void dataGridViewcar_info_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)//增加新行时自动设默认值
        {
            SqlConnection conn = new SqlLink().OpenSql();
            string sql = "select MAX(Warehouse_innum),max(car_num) from Warehouse_in";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.Fill(dataSet, "warehouse_in_numset");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中
            e.Row.Cells["car_num"].Value = Convert.ToInt32(dataSet.Tables["warehouse_in_numset"].Rows[0][1]) + 1;
            e.Row.Cells["warehouse_innumfirst"].Value =Convert.ToInt32(dataSet.Tables["warehouse_in_numset"].Rows[0][0])+1;

            if (conn != null)
            {
                conn.Close();
                //关闭数据连接对象
            }

        }

        private void dgvCar_info_CellLeave(object sender, DataGridViewCellEventArgs e)//确认有输入后才使提交按钮可用
        {
            btnSubmit.Enabled = true;
        }
    }
}
