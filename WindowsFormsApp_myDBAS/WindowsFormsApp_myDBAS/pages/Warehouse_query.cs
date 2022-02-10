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
    public partial class Warehouse_query : Form
    {
        public Warehouse_query()
        {
            InitializeComponent();
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql;
                if (txtCar_name.Text == "" & txtCar_num.Text == "")
                {
                    sql = "select car_info.car_num,Warehouse_innum,car_name,car_price,car_type,car_color,amount,Warehouse_indate from car_info, Warehouse_in where car_info.car_num = Warehouse_in.car_num ";
                }
                else if (txtCar_name.Text != "" & txtCar_num.Text == "")
                {
                    sql = "select car_info.car_num,Warehouse_innum,car_name,car_price,car_type,car_color,amount,Warehouse_indate from car_info, Warehouse_in where car_info.car_num = Warehouse_in.car_num and car_name='" + txtCar_name.Text + "'";
                }
                else if (txtCar_name.Text == "" & txtCar_num.Text != "")
                {
                    sql = "select car_info.car_num,Warehouse_innum,car_name,car_price,car_type,car_color,amount,Warehouse_indate from car_info, Warehouse_in where car_info.car_num = Warehouse_in.car_num and  car_info.car_num='" + txtCar_num.Text + "'";
                }

                else
                {
                    sql = "select car_info.car_num,Warehouse_innum,car_name,car_price,car_type,car_color,amount,Warehouse_indate from car_info, Warehouse_in where car_info.car_num = Warehouse_in.car_num and car_name='" + txtCar_name.Text + "' and car_num ='" + txtCar_num.Text + "'";
                }

                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                sda.Fill(ds);//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象ds中
                dataGridViewcar_info.DataSource = ds.Tables[0];//设置表格控件的DataSource属性,自定义datagridview
                dataGridViewcar_info.Columns[0].HeaderText = "轿车编号";
                dataGridViewcar_info.Columns[1].HeaderText = "入库编号";
                dataGridViewcar_info.Columns[2].HeaderText = "轿车名字";
                dataGridViewcar_info.Columns[3].HeaderText = "价格";
                dataGridViewcar_info.Columns[4].HeaderText = "类型";
                dataGridViewcar_info.Columns[5].HeaderText = "颜色";
                dataGridViewcar_info.Columns[6].HeaderText = "库存";
                dataGridViewcar_info.Columns[7].HeaderText = "入库日期";
                dataGridViewcar_info.ReadOnly = true;
                dataGridViewcar_info.AllowUserToAddRows = false;
                dataGridViewcar_info.BackgroundColor = Color.White;
                dataGridViewcar_info.MultiSelect = false;
                dataGridViewcar_info.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//整行选中
                txtCar_num.Clear();
                txtCar_name.Clear();
            }
            catch
            {
                MessageBox.Show("查询出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        
        private void Warehouse_query_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
    }
}
