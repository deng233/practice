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
    public partial class Personal_performance : Form
    {

        public static string conn = "Data Source = (Local); Pooling=False;Max Pool Size = 1024;Initial Catalog = mycarsystem_DB; Persist Security Info=True;User ID = sa; Password=sa";
        DataSet dataSet = new DataSet(); //定义一个数据集
        
        public Personal_performance()
        {
            InitializeComponent();

        }
        //创建一张二维数据表
        public DataTable CreatData(string Sql)
        {   
            DataTable dt = new DataTable();
            try
            {
                //实例化SqlConnection对象
                SqlConnection sqlCon = new SqlConnection();
                //实例化SqlConnection对象连接数据库的字符串
                sqlCon.ConnectionString = conn;
                //定义SQL语句
                //sql公用部分
                string sql = Sql;
                dt = GetDataTable(sql);
            }
            catch
            {
                MessageBox.Show("创建一张相应的二维数据表出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;

        }
        //数据库查询返回datatable
        public static DataTable GetDataTable(string Sql)
        {

            SqlConnection sqlCon = new SqlConnection();//实例化SqlConnection对象连接数据库的字符串
            DataTable dt = new DataTable();
            try
            {
                sqlCon.ConnectionString = conn;
                sqlCon.Open();
                SqlDataAdapter sda = new SqlDataAdapter(Sql, conn);
                sda.Fill(dt);
            }
            catch
            {
                MessageBox.Show("数据库查询返回datatable出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlCon.Close();
            }
            return dt;

        }

        private void Personal_performance_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }
        public void Bindyear()
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select distinct YEAR(carsales_date) 年 from carsales_info where carsales_handlernum = '" + Mycookie.usernum + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dataSet, "year");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中
                cboYear.DataSource = dataSet.Tables["year"];
                DataRow dr = dataSet.Tables["year"].NewRow();
                cboYear.DisplayMember = "年";
            }
            catch
            {
                MessageBox.Show("绑定年份出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void Bindmonth()
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select distinct Month(carsales_date) 月 from carsales_info where carsales_handlernum = '" + Mycookie.usernum + "' and Year(carsales_date)='" + cboYear.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                //处理刷新
                if (dataSet.Tables.Count == 2)
                {
                    dataSet.Tables["month"].Clear();
                }
                sda.Fill(dataSet, "month");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中
                cboMonth.DataSource = dataSet.Tables["month"];
                cboMonth.DisplayMember = "月";
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


        private void cboMonth_Leave(object sender, EventArgs e)
        {
            /*年度绩效*/
            string sql1 = "select month(carsales_date) 月份, sum(amount) 数量,cast(sum(caesales_salesamount)/10000 as decimal(10,2)) 销售额 from carsales_info where YEAR(carsales_date)= '" + cboYear.Text + "'and carsales_handlernum= '" + Mycookie.usernum + "' group by MONTH(carsales_date)";
            DataTable dt_year = CreatData(sql1);
            chart_annual_performance.DataSource = dt_year;//绑定数据
            chart_annual_performance.Series[0].XValueMember = "月份";//X轴数据成员列
            chart_annual_performance.Series[0].YValueMembers = "数量";//Y轴数据成员列
            chart_annual_performance.Series[1].XValueMember = "月份";//X轴数据成员列
            chart_annual_performance.Series[1].YValueMembers = "数量";//Y轴数据成员列
            chart_annual_performance.ChartAreas["ChartArea1"].AxisX.Title = "月份";//X轴标题
            chart_annual_performance.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_annual_performance.ChartAreas["ChartArea1"].AxisY.Title = "数量(辆)";//Y轴标题
            chart_annual_performance.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_annual_performance.ChartAreas["ChartArea1"].AxisX.Interval = 1;//X轴数据的间距
            chart_annual_performance.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_annual_performance.Series[0].IsValueShownAsLabel = true;//显示坐标值
            chart_annual_performance.ChartAreas[0].AxisX.Minimum = 0;
            chart_annual_performance.ChartAreas[0].AxisX.Maximum = 13;
            /*年度销售额*/
            chart_annual_performance.Series[2].XValueMember = "月份";//X轴数据成员列
            chart_annual_performance.Series[2].YValueMembers = "销售额";//Y轴数据成员列
            chart_annual_performance.Series[3].XValueMember = "月份";//X轴数据成员列
            chart_annual_performance.Series[3].YValueMembers = "销售额";//Y轴数据成员列
            chart_annual_performance.ChartAreas["ChartArea2"].AxisX.Title = "月份";//X轴标题
            chart_annual_performance.ChartAreas["ChartArea2"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_annual_performance.ChartAreas["ChartArea2"].AxisY.Title = "销售额(万元)";//Y轴标题
            chart_annual_performance.ChartAreas["ChartArea2"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_annual_performance.ChartAreas["ChartArea2"].AxisX.Interval = 1;//X轴数据的间距
            chart_annual_performance.ChartAreas["ChartArea2"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_annual_performance.Series[2].IsValueShownAsLabel = true;//显示坐标值
            chart_annual_performance.ChartAreas[1].AxisX.Minimum = 0;
            chart_annual_performance.ChartAreas[1].AxisX.Maximum = 13;
            /*月度绩效*/
            string sql4 = "select day(carsales_date) 日期 ,sum(amount) 数量 from carsales_info where YEAR(carsales_date) = '" + cboYear.Text + "'and MONTH(carsales_date)= '" + cboMonth.Text + "'and carsales_handlernum= '" + Mycookie.usernum + "' group by day(carsales_date)";
            DataTable dt_month = CreatData(sql4);
            chart_Monthly_performance.DataSource = dt_month;//绑定数据
            chart_Monthly_performance.Series[0].XValueMember = "日期";//X轴数据成员列
            chart_Monthly_performance.Series[0].YValueMembers = "数量";//Y轴数据成员列
            chart_Monthly_performance.ChartAreas["ChartArea1"].AxisX.Title = "日期";//X轴标题
            chart_Monthly_performance.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Monthly_performance.ChartAreas["ChartArea1"].AxisY.Title = "数量(辆)";//Y轴标题
            chart_Monthly_performance.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Monthly_performance.ChartAreas["ChartArea1"].AxisX.Interval = 1;//X轴数据的间距
            chart_Monthly_performance.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_Monthly_performance.Series[0].IsValueShownAsLabel = true;//显示坐标值

        }

        private void cboYear_Leave(object sender, EventArgs e)//选定年份后绑定相应的月份数据
        {
            Bindmonth();
        }

        private void cboYear_Enter(object sender, EventArgs e)//获得焦点便绑定年份数据
        {
            Bindyear();
        }
    }
}
