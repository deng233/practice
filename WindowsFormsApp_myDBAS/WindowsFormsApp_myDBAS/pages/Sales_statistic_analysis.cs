using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp_myDBAS
{
    public partial class Sales_statistic_analysis : Form
    {
        public static string conn = "Data Source = (Local); Pooling=False;Max Pool Size = 1024;Initial Catalog = mycarsystem_DB; Persist Security Info=True;User ID = sa; Password=sa";
        DataSet dataSet = new DataSet(); //定义一个数据集
        public Sales_statistic_analysis()
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
        public void Bindyear()
        {
            dataSet.Tables.Clear();
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select distinct YEAR(carsales_date) 年 from carsales_info ";
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
                string sql = "select distinct Month(carsales_date) 月 from carsales_info where  Year(carsales_date)='" + cboYear.Text + "'";
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
                MessageBox.Show("绑定月份出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void Bindemployee_name()
        {
            SqlConnection conn = new SqlLink().OpenSql();
            try
            {
                string sql = "select distinct employee_name 名字 from carsales_info,employee_info where  carsales_info.carsales_handlernum=employee_info.employee_num and Year(carsales_date)='" + cboYear.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                //处理刷新
                if (dataSet.Tables.Count == 3)
                {
                    dataSet.Tables["employee_name"].Clear();
                }
                sda.Fill(dataSet, "employee_name");//使用SqlDataAdapter对象sda将查询结果填充到DataSet对象dataset中
                cboEmployee_name_annual.DataSource = dataSet.Tables["employee_name"];
                cboEmployee_name_annual.DisplayMember = "名字";
                cboEmployee_name_monthly.DataSource = dataSet.Tables["employee_name"];
                cboEmployee_name_monthly.DisplayMember = "名字";
            }
            catch
            {
                MessageBox.Show("绑定职工名字出错！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Close();
        }

        private void btnSale_good_Click(object sender, EventArgs e)
        {

            tabContro_Sales_statistic_analysis.Visible = true;
            tabContro_Sales_statistic_analysis.TabPages.Clear();
            tabContro_Sales_statistic_analysis.TabPages.Add(tabPage_brand);
            tabContro_Sales_statistic_analysis.TabPages.Add(tabPage_cartype);
            tabContro_Sales_statistic_analysis.TabPages.Add(tabPage_color);

        }

        private void cboYear_Enter(object sender, EventArgs e)
        {
            Bindyear();
        }

        private void cboYear_Leave(object sender, EventArgs e)
        {
            Bindmonth();
        }


        private void Sales_statistic_analysis_Load(object sender, EventArgs e)
        {
            tabContro_Sales_statistic_analysis.Visible = false;
            this.MaximizeBox = false;
            txtPath.Text = "d:/统计数据";
        }

        private void tabControl_salesgood_Enter(object sender, EventArgs e)//热销趋势的页面
        {

            //热销趋势的品牌的圆环图
                //一年
            string sql1 = "select distinct car_name 车名,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "' group by car_name";
            DataTable dt_pie_Yearsalesgooddata = CreatData(sql1);
            List<string> xData_year = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_year = new List<int>();
            for (int i = 0; i < dt_pie_Yearsalesgooddata.Rows.Count; i++)
            {
                xData_year.Add(Convert.ToString(dt_pie_Yearsalesgooddata.Rows[i]["车名"]));
                yData_year.Add(Convert.ToInt32(dt_pie_Yearsalesgooddata.Rows[i]["数量"]));
            }
            chart_pie_brand_Yearsalesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_brand_Yearsalesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_brand_Yearsalesgood.Series[0].Points.DataBindXY(xData_year, yData_year);
            //半年
            int minmonth = 0;
            int maxmonth = 0;
            /*解决没有选定年份和月份*/
            try
            {
                 minmonth = Convert.ToInt32(cboMonth.Text) - 6;//算出近半年的最小月
                 maxmonth = Convert.ToInt32(cboYear.Text);//默认为选定值
            }
            catch
            {
                 MessageBox.Show("请先选定年份和月份！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return;
            }

            if (cboMonth.Text == "")
            {
                MessageBox.Show("请先选定月份！");
            }
            if (Convert.ToInt32(cboMonth.Text) <=6)
            {
                minmonth = 1;
                maxmonth = 6;

            }
            //类型转换
            string minmonths = Convert.ToString(minmonth);
            string maxmonths = Convert.ToString(maxmonth);
            string sql2 = "select distinct car_name 车名,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "'and month(carsales_date)>'" + minmonths + "' and month(carsales_date)<'" + maxmonths + "' group by car_name";
            DataTable dt_pie_Halfyearsalesgooddata = CreatData(sql2);
            List<string> xData_halfyear = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_halfyear = new List<int>();
            for (int i = 0; i < dt_pie_Halfyearsalesgooddata.Rows.Count; i++)
            {
                xData_halfyear.Add(Convert.ToString(dt_pie_Halfyearsalesgooddata.Rows[i]["车名"]));
                yData_halfyear.Add(Convert.ToInt32(dt_pie_Halfyearsalesgooddata.Rows[i]["数量"]));
            }
            chart_pie_brand_Halfyear_salesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_brand_Halfyear_salesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_brand_Halfyear_salesgood.Series[0].Points.DataBindXY(xData_halfyear, yData_halfyear);
                //近三个月
            minmonth = Convert.ToInt32(cboMonth.Text) - 3;//算出近三个月的最小月
            maxmonth = Convert.ToInt32(cboYear.Text);//默认为选定值
            if (cboMonth.Text == "")
            {
                MessageBox.Show("请先选定月份！");
            }
            if (Convert.ToInt32(cboMonth.Text) <=3)
            {
                minmonth = 1;
                maxmonth = 3;

            }
            //类型转换
            minmonths = Convert.ToString(minmonth);
            maxmonths = Convert.ToString(maxmonth);
            string sql3 = "select distinct car_name 车名,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "'and month(carsales_date)>'" + minmonths + "' and month(carsales_date)<'" + maxmonths + "' group by car_name";
            DataTable dt_pie_Threemonthsalesgooddata = CreatData(sql3);
            List<string> xData_Threemonth = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_Threemonth = new List<int>();
            for (int i = 0; i < dt_pie_Threemonthsalesgooddata.Rows.Count; i++)
            {
                xData_Threemonth.Add(Convert.ToString(dt_pie_Threemonthsalesgooddata.Rows[i]["车名"]));
                yData_Threemonth.Add(Convert.ToInt32(dt_pie_Threemonthsalesgooddata.Rows[i]["数量"]));
            }
            chart_pie_brand_Threemonth_salesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_brand_Threemonth_salesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_brand_Threemonth_salesgood.Series[0].Points.DataBindXY(xData_Threemonth, yData_Threemonth);
            //热销趋势的能源类型的圆环图
                //一年
            string sqlpie_cartype_Yearsalesgood = "select distinct carsales_type 类型,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "' group by carsales_type";
            DataTable dt_pie_cartype_Yearsalesgood = CreatData(sqlpie_cartype_Yearsalesgood);
            List<string> xData_pie_cartype_Yearsalesgood = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_pie_cartype_Yearsalesgood = new List<int>();
            for (int i = 0; i < dt_pie_cartype_Yearsalesgood.Rows.Count; i++)
            {
                xData_pie_cartype_Yearsalesgood.Add(Convert.ToString(dt_pie_cartype_Yearsalesgood.Rows[i]["类型"]));
                yData_pie_cartype_Yearsalesgood.Add(Convert.ToInt32(dt_pie_cartype_Yearsalesgood.Rows[i]["数量"]));
            }
            chart_pie_cartype_Yearsalesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_cartype_Yearsalesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_cartype_Yearsalesgood.Series[0].Points.DataBindXY(xData_pie_cartype_Yearsalesgood, yData_pie_cartype_Yearsalesgood);
                //近半年
            minmonth = Convert.ToInt32(cboMonth.Text) - 6;//算出近半年的最小月
            maxmonth = Convert.ToInt32(cboYear.Text);//默认为选定值
            if (cboMonth.Text == "")
            {
                MessageBox.Show("请先选定月份！");
            }
            if (Convert.ToInt32(cboMonth.Text) <=6)
            {
                minmonth = 1;
                maxmonth = 6;

            }
            //类型转换
            minmonths = Convert.ToString(minmonth);
            maxmonths = Convert.ToString(maxmonth);
            string sql_cartype_Halfyearsalesgood = "select distinct carsales_type 类型,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "'and month(carsales_date) > '" + minmonths + "' and month(carsales_date) < '" + maxmonths + "' group by carsales_type";
            DataTable dt_cartype_Halfyearsalesgood = CreatData(sql_cartype_Halfyearsalesgood);
            List<string> xData_cartype_Halfyearsalesgood = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_cartype_Halfyearsalesgood = new List<int>();
            for (int i = 0; i < dt_cartype_Halfyearsalesgood.Rows.Count; i++)
            {
                xData_cartype_Halfyearsalesgood.Add(Convert.ToString(dt_cartype_Halfyearsalesgood.Rows[i]["类型"]));
                yData_cartype_Halfyearsalesgood.Add(Convert.ToInt32(dt_cartype_Halfyearsalesgood.Rows[i]["数量"]));
            }
            chart_pie_cartype_Halfyearsalesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_cartype_Halfyearsalesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_cartype_Halfyearsalesgood.Series[0].Points.DataBindXY(xData_cartype_Halfyearsalesgood, yData_cartype_Halfyearsalesgood);
                //近三个月
            int minmonth_pie_cartype_Threemonthsalesgood = Convert.ToInt32(cboMonth.Text) - 3;//算出近三个月的最小月
            int maxmonth_pie_cartype_Threemonthsalesgood = Convert.ToInt32(cboYear.Text);//默认为选定值
            if (cboMonth.Text == "")
            {
                MessageBox.Show("请先选定月份！");
            }
            if (Convert.ToInt32(cboMonth.Text) <=3)
            {
                minmonth_pie_cartype_Threemonthsalesgood = 1;
                maxmonth_pie_cartype_Threemonthsalesgood = 3;

            }
            //类型转换
            minmonths = Convert.ToString(minmonth_pie_cartype_Threemonthsalesgood);
            maxmonths = Convert.ToString(maxmonth_pie_cartype_Threemonthsalesgood);
            string sql_cartype_Threemonthsalesgood = "select distinct carsales_type 类型,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "'and month(carsales_date)>'" + minmonths + "' and month(carsales_date)<'" + maxmonths + "' group by carsales_type";
            DataTable dt_cartype_Threemonthsalesgood = CreatData(sql_cartype_Threemonthsalesgood);
            List<string> xData_cartype_Threemonthsalesgood = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_cartype_Threemonthsalesgood = new List<int>();
            for (int i = 0; i < dt_cartype_Threemonthsalesgood.Rows.Count; i++)
            {
                xData_cartype_Threemonthsalesgood.Add(Convert.ToString(dt_cartype_Threemonthsalesgood.Rows[i]["类型"]));
                yData_cartype_Threemonthsalesgood.Add(Convert.ToInt32(dt_cartype_Threemonthsalesgood.Rows[i]["数量"]));
            }
            chart_pie_cartype_Threemonthsalesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_cartype_Threemonthsalesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_cartype_Threemonthsalesgood.Series[0].Points.DataBindXY(xData_cartype_Threemonthsalesgood, yData_cartype_Threemonthsalesgood);
            //热销趋势的颜色的圆环图
                //一年
            string sqlpie_color_Yearsalesgood = "select distinct carsales_color 颜色,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "' group by carsales_color";
            DataTable dt_pie_color_Yearsalesgood = CreatData(sqlpie_color_Yearsalesgood);
            List<string> xData_pie_color_Yearsalesgood = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_pie_color_Yearsalesgood = new List<int>();
            for (int i = 0; i < dt_pie_color_Yearsalesgood.Rows.Count; i++)
            {
                xData_pie_color_Yearsalesgood.Add(Convert.ToString(dt_pie_color_Yearsalesgood.Rows[i]["颜色"]));
                yData_pie_color_Yearsalesgood.Add(Convert.ToInt32(dt_pie_color_Yearsalesgood.Rows[i]["数量"]));
            }
            chart_pie_color_Yearsalesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_color_Yearsalesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线 
            chart_pie_color_Yearsalesgood.Series[0].Points.DataBindXY(xData_pie_color_Yearsalesgood, yData_pie_color_Yearsalesgood);
            //近半年
            minmonth = Convert.ToInt32(cboMonth.Text) - 6;//算出近半年的最小月
            maxmonth = Convert.ToInt32(cboYear.Text);//默认为选定值
            if (cboMonth.Text == "")
            {
                MessageBox.Show("请先选定月份！");
            }
            if (Convert.ToInt32(cboMonth.Text) <= 6)
            {
                minmonth = 1;
                maxmonth = 6;

            }
            //类型转换
            minmonths = Convert.ToString(minmonth);
            maxmonths = Convert.ToString(maxmonth);
            string sql_color_Halfyearsalesgood = "select distinct carsales_color 颜色,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "'and month(carsales_date) > '" + minmonths + "' and month(carsales_date) < '" + maxmonths + "' group by carsales_color";
            DataTable dt_color_Halfyearsalesgood = CreatData(sql_color_Halfyearsalesgood);
            List<string> xData_color_Halfyearsalesgood = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_color_Halfyearsalesgood = new List<int>();
            for (int i = 0; i < dt_color_Halfyearsalesgood.Rows.Count; i++)
            {
                xData_color_Halfyearsalesgood.Add(Convert.ToString(dt_color_Halfyearsalesgood.Rows[i]["颜色"]));
                yData_color_Halfyearsalesgood.Add(Convert.ToInt32(dt_color_Halfyearsalesgood.Rows[i]["数量"]));
            }
            chart_pie_color_Halfyearsalesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_color_Halfyearsalesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_color_Halfyearsalesgood.Series[0].Points.DataBindXY(xData_color_Halfyearsalesgood, yData_color_Halfyearsalesgood);
            //近三个月
            int minmonth_pie_color_Threemonthsalesgood = Convert.ToInt32(cboMonth.Text) - 3;//算出近三个月的最小月
            int maxmonth_pie_color_Threemonthsalesgood = Convert.ToInt32(cboYear.Text);//默认为选定值
            if (cboMonth.Text == "")
            {
                MessageBox.Show("请先选定月份！");
            }
            if (Convert.ToInt32(cboMonth.Text) <= 3)
            {
                minmonth_pie_color_Threemonthsalesgood = 1;
                maxmonth_pie_color_Threemonthsalesgood = 3;

            }
            //类型转换
            minmonths = Convert.ToString(minmonth_pie_color_Threemonthsalesgood);
            maxmonths = Convert.ToString(maxmonth_pie_color_Threemonthsalesgood);
            string sql_color_Threemonthsalesgood = "select distinct carsales_color 颜色,SUM(amount)数量 from carsales_info where YEAR(carsales_date) ='" + cboYear.Text + "'and month(carsales_date)>'" + minmonths + "' and month(carsales_date)<'" + maxmonths + "' group by carsales_color";
            DataTable dt_color_Threemonthsalesgood = CreatData(sql_color_Threemonthsalesgood);
            List<string> xData_color_Threemonthsalesgood = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData_color_Threemonthsalesgood = new List<int>();
            for (int i = 0; i < dt_color_Threemonthsalesgood.Rows.Count; i++)
            {
                xData_color_Threemonthsalesgood.Add(Convert.ToString(dt_color_Threemonthsalesgood.Rows[i]["颜色"]));
                yData_color_Threemonthsalesgood.Add(Convert.ToInt32(dt_color_Threemonthsalesgood.Rows[i]["数量"]));
            }
            chart_pie_color_Threemonthsalesgood.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_color_Threemonthsalesgood.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_color_Threemonthsalesgood.Series[0].Points.DataBindXY(xData_color_Threemonthsalesgood, yData_color_Threemonthsalesgood);
            
            //盈利情况的销售量、利润与销售额的柱状图、折线图
            /*年度销量*/
            string sql_Column_annual_sales = "select month(carsales_date) 月份, sum(amount) 数量,cast(sum(caesales_salesamount)/10000 as decimal(10,2)) 销售额 ,cast(sum(caesales_salesamount)/10000 as decimal(10,2))-cast(sum(car_price*amount)/10000 as decimal(10,2))利润 from carsales_info,car_info where carsales_info.car_num=car_info.car_num and YEAR(carsales_date)= '" + cboYear.Text + "' group by MONTH(carsales_date)";
            DataTable dt_Column_annual_sales = CreatData(sql_Column_annual_sales);
            chart_Column_annual_sales.DataSource = dt_Column_annual_sales;//绑定数据
            chart_Column_annual_sales.Series[0].XValueMember = "月份";//X轴数据成员列
            chart_Column_annual_sales.Series[0].YValueMembers = "数量";//Y轴数据成员列
            chart_Column_annual_sales.Series[1].XValueMember = "月份";//X轴数据成员列
            chart_Column_annual_sales.Series[1].YValueMembers = "数量";//Y轴数据成员列
            chart_Column_annual_sales.ChartAreas["ChartArea1"].AxisX.Title = "月份";//X轴标题
            chart_Column_annual_sales.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Column_annual_sales.ChartAreas["ChartArea1"].AxisY.Title = "数量(辆)";//Y轴标题
            chart_Column_annual_sales.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Column_annual_sales.ChartAreas["ChartArea1"].AxisX.Interval = 1;//X轴数据的间距
            chart_Column_annual_sales.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_Column_annual_sales.Series[0].IsValueShownAsLabel = true;//显示坐标值
            chart_Column_annual_sales.ChartAreas[0].AxisX.Minimum = 0;
            chart_Column_annual_sales.ChartAreas[0].AxisX.Maximum = 13;
                /*年度销售额*/
            chart_Column_annual_sales.Series[2].XValueMember = "月份";//X轴数据成员列
            chart_Column_annual_sales.Series[2].YValueMembers = "销售额";//Y轴数据成员列
            chart_Column_annual_sales.Series[3].XValueMember = "月份";//X轴数据成员列
            chart_Column_annual_sales.Series[3].YValueMembers = "销售额";//Y轴数据成员列
            chart_Column_annual_sales.Series[4].XValueMember = "月份";//X轴数据成员列
            chart_Column_annual_sales.Series[4].YValueMembers = "利润";//Y轴数据成员列
            chart_Column_annual_sales.ChartAreas["ChartArea2"].AxisX.Title = "月份";//X轴标题
            chart_Column_annual_sales.ChartAreas["ChartArea2"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Column_annual_sales.ChartAreas["ChartArea2"].AxisY.Title = "数额(万元)";//Y轴标题
            chart_Column_annual_sales.ChartAreas["ChartArea2"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Column_annual_sales.ChartAreas["ChartArea2"].AxisX.Interval = 1;//X轴数据的间距
            chart_Column_annual_sales.ChartAreas["ChartArea2"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_Column_annual_sales.Series[2].IsValueShownAsLabel = true;//显示坐标值
            chart_Column_annual_sales.Series[4].IsValueShownAsLabel = true;//显示坐标值
            chart_Column_annual_sales.ChartAreas[1].AxisX.Minimum = 0;
            chart_Column_annual_sales.ChartAreas[1].AxisX.Maximum = 13;
                /*季度销量*/
            string sql_Column_quarter_sales = "select datename(q, carsales_date) 季度,sum(amount) 数量,cast(sum(caesales_salesamount)/10000 as decimal(10,2)) 销售额 ,cast(sum(caesales_salesamount)/10000 as decimal(10,2))-cast(sum(car_price*amount)/10000 as decimal(10,2))利润 from carsales_info,car_info where carsales_info.car_num=car_info.car_num and YEAR(carsales_date)= '" + cboYear.Text + "' group by datename(q, carsales_date)";
            DataTable dt_Column_quarter_sales = CreatData(sql_Column_quarter_sales);
            chart_Column_quarter_sales.DataSource = dt_Column_quarter_sales;//绑定数据
            chart_Column_quarter_sales.Series[0].XValueMember = "季度";//X轴数据成员列
            chart_Column_quarter_sales.Series[0].YValueMembers = "数量";//Y轴数据成员列
            chart_Column_quarter_sales.Series[1].XValueMember = "季度";//X轴数据成员列
            chart_Column_quarter_sales.Series[1].YValueMembers = "数量";//Y轴数据成员列
            chart_Column_quarter_sales.ChartAreas["ChartArea1"].AxisX.Title = "季度";//X轴标题
            chart_Column_quarter_sales.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Column_quarter_sales.ChartAreas["ChartArea1"].AxisY.Title = "数量(辆)";//Y轴标题
            chart_Column_quarter_sales.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Column_quarter_sales.ChartAreas["ChartArea1"].AxisX.Interval = 1;//X轴数据的间距
            chart_Column_quarter_sales.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_Column_quarter_sales.Series[0].IsValueShownAsLabel = true;//显示坐标值
            chart_Column_quarter_sales.ChartAreas[0].AxisX.Minimum = 0;
            chart_Column_quarter_sales.ChartAreas[0].AxisX.Maximum = 5;
                /*季度销售额*/
            chart_Column_quarter_sales.Series[2].XValueMember = "季度";//X轴数据成员列
            chart_Column_quarter_sales.Series[2].YValueMembers = "销售额";//Y轴数据成员列
            chart_Column_quarter_sales.Series[3].XValueMember = "季度";//X轴数据成员列
            chart_Column_quarter_sales.Series[3].YValueMembers = "销售额";//Y轴数据成员列
            chart_Column_quarter_sales.Series[4].XValueMember = "季度";//X轴数据成员列
            chart_Column_quarter_sales.Series[4].YValueMembers = "利润";//Y轴数据成员列
            chart_Column_quarter_sales.ChartAreas["ChartArea2"].AxisX.Title = "季度";//X轴标题
            chart_Column_quarter_sales.ChartAreas["ChartArea2"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Column_quarter_sales.ChartAreas["ChartArea2"].AxisY.Title = "数额(万元)";//Y轴标题
            chart_Column_quarter_sales.ChartAreas["ChartArea2"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_Column_quarter_sales.ChartAreas["ChartArea2"].AxisX.Interval = 1;//X轴数据的间距
            chart_Column_quarter_sales.ChartAreas["ChartArea2"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_Column_quarter_sales.Series[2].IsValueShownAsLabel = true;//显示坐标值
            chart_Column_quarter_sales.Series[4].IsValueShownAsLabel = true;//显示坐标值
            chart_Column_quarter_sales.ChartAreas[1].AxisX.Minimum = 0;
            chart_Column_quarter_sales.ChartAreas[1].AxisX.Maximum = 5;
            //职工表表现的bar图、圆环图
            Bindemployee_name();//绑定要用的职工名字
            string sql_bar_annual_performance = "select distinct employee_name 职工姓名,sum(amount) 数量,cast(sum(caesales_salesamount)/10000 as decimal(10,2))销售额 from carsales_info, employee_info where carsales_info.carsales_handlernum = employee_info.employee_num and YEAR(carsales_date)= '"+cboYear.Text+"'group by employee_name";
            DataTable dt_bar_annual_performance = CreatData(sql_bar_annual_performance);
            chart_bar_annual_performance.DataSource = dt_bar_annual_performance;//绑定数据
            chart_bar_annual_performance.Series[0].XValueMember = "职工姓名";//X轴数据成员列
            chart_bar_annual_performance.Series[0].YValueMembers = "数量";//Y轴数据成员列
            chart_bar_annual_performance.Series[1].XValueMember = "职工姓名";//X轴数据成员列
            chart_bar_annual_performance.Series[1].YValueMembers = "销售额";//Y轴数据成员列
            chart_bar_annual_performance.ChartAreas["ChartArea1"].AxisX.Title = "职工姓名";//X轴标题
            chart_bar_annual_performance.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Far;//设置X轴标题的名称所在位置位远
            chart_bar_annual_performance.ChartAreas["ChartArea1"].AxisY.Title = "数量（辆）";//Y轴标题
            chart_bar_annual_performance.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_bar_annual_performance.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_bar_annual_performance.Series[0].IsValueShownAsLabel = true;//显示坐标值
            chart_bar_annual_performance.ChartAreas["ChartArea2"].AxisX.Title = "职工姓名";//X轴标题
            chart_bar_annual_performance.ChartAreas["ChartArea2"].AxisX.TitleAlignment = StringAlignment.Far;//设置X轴标题的名称所在位置位远
            chart_bar_annual_performance.ChartAreas["ChartArea2"].AxisY.Title = "数额（万元）";//Y轴标题
            chart_bar_annual_performance.ChartAreas["ChartArea2"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_bar_annual_performance.ChartAreas["ChartArea2"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_bar_annual_performance.Series[1].IsValueShownAsLabel = true;//显示坐标值
            Display_pie_employee_salecarname();//加载具体职工本年所卖车辆构成的饼图
            Display_column_monthly_employee_performance();//加载具体职工月度表现
        }
        public void Display_pie_employee_salecarname()//加载具体职工本年所卖车辆构成的饼图
        {
            string sqlpie_pie_employee_salecarname = "select distinct car_name 车名, sum(amount) 数量 from carsales_info, employee_info where carsales_info.carsales_handlernum = employee_info.employee_num and YEAR(carsales_date) = '"+cboYear.Text+"' and employee_name = '"+cboEmployee_name_annual.Text+"' group by car_name";
            DataTable dt__pie_employee_salecarname = CreatData(sqlpie_pie_employee_salecarname);
            List<string> xData__pie_employee_salecarname = new List<string>();//声明两个集合将数据先放在集合中
            List<int> yData__pie_employee_salecarname = new List<int>();
            for (int i = 0; i < dt__pie_employee_salecarname.Rows.Count; i++)
            {
                xData__pie_employee_salecarname.Add(Convert.ToString(dt__pie_employee_salecarname.Rows[i]["车名"]));
                yData__pie_employee_salecarname.Add(Convert.ToInt32(dt__pie_employee_salecarname.Rows[i]["数量"]));
            }
            chart_pie_employee_salecarname.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧 
            chart_pie_employee_salecarname.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。 
            chart_pie_employee_salecarname.Series[0].Points.DataBindXY(xData__pie_employee_salecarname, yData__pie_employee_salecarname);
        }

        private void btnProfit_Click(object sender, EventArgs e)//盈利情况
        {
 
            tabContro_Sales_statistic_analysis.Visible = true;
            tabContro_Sales_statistic_analysis.TabPages.Clear();
            tabContro_Sales_statistic_analysis.TabPages.Add(tabPage_Salesdetails);
        }

        private void btnEmployee_performance_Click(object sender, EventArgs e)//职工表现
        {

            tabContro_Sales_statistic_analysis.Visible = true;
            tabContro_Sales_statistic_analysis.TabPages.Clear();
            tabContro_Sales_statistic_analysis.TabPages.Add(tabPage_employee_annual_performance);
            tabContro_Sales_statistic_analysis.TabPages.Add(tabPage_employee_monthly_performance);

        }

        private void cboEmployee_name_annual_Leave(object sender, EventArgs e)
        {
            Display_pie_employee_salecarname();//加载具体职工本年所卖车辆构成的饼图
        }

        public void Display_column_monthly_employee_performance()//加载具体职工月度表现
        {
            SqlConnection connection = new SqlConnection(conn);
            /*月度绩效*/
            string sql1 = "select month(carsales_date) 月份, sum(amount) 数量,cast(sum(caesales_salesamount)/10000 as decimal(10,2)) 销售额 from carsales_info,employee_info  where YEAR(carsales_date)= '" + cboYear.Text + "'and carsales_info.carsales_handlernum=employee_info.employee_num and employee_name='"+cboEmployee_name_monthly.Text+"' group by MONTH(carsales_date)";
            DataTable dt_year = CreatData(sql1);
            chart_column_monthly_employee_performance.DataSource = dt_year;//绑定数据
            chart_column_monthly_employee_performance.Series[0].XValueMember = "月份";//X轴数据成员列
            chart_column_monthly_employee_performance.Series[0].YValueMembers = "数量";//Y轴数据成员列
            chart_column_monthly_employee_performance.Series[1].XValueMember = "月份";//X轴数据成员列
            chart_column_monthly_employee_performance.Series[1].YValueMembers = "数量";//Y轴数据成员列
            chart_column_monthly_employee_performance.ChartAreas["ChartArea1"].AxisX.Title = "月份";//X轴标题
            chart_column_monthly_employee_performance.ChartAreas["ChartArea1"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_column_monthly_employee_performance.ChartAreas["ChartArea1"].AxisY.Title = "数量(辆)";//Y轴标题
            chart_column_monthly_employee_performance.ChartAreas["ChartArea1"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_column_monthly_employee_performance.ChartAreas["ChartArea1"].AxisX.Interval = 1;//X轴数据的间距
            chart_column_monthly_employee_performance.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_column_monthly_employee_performance.Series[0].IsValueShownAsLabel = true;//显示坐标值
            chart_column_monthly_employee_performance.ChartAreas[0].AxisX.Minimum = 0;
            chart_column_monthly_employee_performance.ChartAreas[0].AxisX.Maximum = 13;
            /*月度销售额*/
            chart_column_monthly_employee_performance.Series[2].XValueMember = "月份";//X轴数据成员列
            chart_column_monthly_employee_performance.Series[2].YValueMembers = "销售额";//Y轴数据成员列
            chart_column_monthly_employee_performance.Series[3].XValueMember = "月份";//X轴数据成员列
            chart_column_monthly_employee_performance.Series[3].YValueMembers = "销售额";//Y轴数据成员列
            chart_column_monthly_employee_performance.ChartAreas["ChartArea2"].AxisX.Title = "月份";//X轴标题
            chart_column_monthly_employee_performance.ChartAreas["ChartArea2"].AxisX.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_column_monthly_employee_performance.ChartAreas["ChartArea2"].AxisY.Title = "销售额(万元)";//Y轴标题
            chart_column_monthly_employee_performance.ChartAreas["ChartArea2"].AxisY.TitleAlignment = StringAlignment.Far;//设置Y轴标题的名称所在位置位远
            chart_column_monthly_employee_performance.ChartAreas["ChartArea2"].AxisX.Interval = 1;//X轴数据的间距
            chart_column_monthly_employee_performance.ChartAreas["ChartArea2"].AxisX.MajorGrid.Enabled = false;//不显示竖着的分割线
            chart_column_monthly_employee_performance.Series[2].IsValueShownAsLabel = true;//显示坐标值
            chart_column_monthly_employee_performance.ChartAreas[1].AxisX.Minimum = 0;
            chart_column_monthly_employee_performance.ChartAreas[1].AxisX.Maximum = 13;
          
        }
        private void cboEmployee_name_monthly_Leave(object sender, EventArgs e)//职工表现的月度的combobox选定离开就触发
        {
            Display_column_monthly_employee_performance();//加载具体职工月度表现
        }

        private void btnSave_Click(object sender, EventArgs e)//保存相应的图表
        {
            string filename;//路径
            if (txtPath.Text=="")
            {
                MessageBox.Show("请填写保存路径！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                filename = txtPath.Text;
                if (!Directory.Exists(filename))
                {
                    // Create the directory it does not exist.
                    Directory.CreateDirectory(filename);
                }

            }
            try
            {
                if (tabContro_Sales_statistic_analysis.SelectedTab.Equals(tabPage_brand))
                {
                    filename += "/趋势";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    filename += "/品牌";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    string filename1 = filename + "/"+cboYear.Text+"_一年内品牌的趋势_圆环图.jpg";
                    string month = "";//文件名的时间戳——月份
                    chart_pie_brand_Yearsalesgood.SaveImage(filename1, ChartImageFormat.Jpeg);
                    if(Convert.ToInt32(cboMonth.Text)<=6)
                    {
                        month = "6";
                    }
                    else
                    {
                        month = cboMonth.Text;
                    }
                    string filename2 = filename + "/距离" + cboYear.Text + "-"+ month + "_半年内品牌的趋势_圆环图.jpg";
                    chart_pie_brand_Halfyear_salesgood.SaveImage(filename2, ChartImageFormat.Jpeg);
                    if (Convert.ToInt32(cboMonth.Text) <= 3)
                    {
                        month = "3";
                    }
                    else
                    {
                        month = cboMonth.Text;
                    }
                    string filename3 = filename + "/距离" + cboYear.Text + "-" + month + "_三个月内品牌的趋势_圆环图.jpg";
                    chart_pie_brand_Threemonth_salesgood.SaveImage(filename3, ChartImageFormat.Jpeg);
                    MessageBox.Show("保存成功！请到相应路径下查看！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tabContro_Sales_statistic_analysis.SelectedTab.Equals(tabPage_cartype))
                {
                    filename += "/趋势";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    filename += "/能源类型";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    string filename1 = filename + "/一年内能源类型的趋势_圆环图.jpg";
                    string month = "";//文件名的时间戳——月份
                    if (Convert.ToInt32(cboMonth.Text) <= 6)
                    {
                        month = "6";
                    }
                    else
                    {
                        month = cboMonth.Text;
                    }
                    chart_pie_cartype_Yearsalesgood.SaveImage(filename1, ChartImageFormat.Jpeg);
                    string filename2 = filename + "/距离" + cboYear.Text + "-" + month + "_半年内能源类型的趋势_圆环图.jpg";
                    chart_pie_cartype_Halfyearsalesgood.SaveImage(filename2, ChartImageFormat.Jpeg);
                    if (Convert.ToInt32(cboMonth.Text) <= 3)
                    {
                        month = "3";
                    }
                    else
                    {
                        month = cboMonth.Text;
                    }
                    string filename3 = filename + "/距离" + cboYear.Text + "-" + month + "_三个月内能源类型的趋势_圆环图.jpg";
                    chart_pie_cartype_Threemonthsalesgood.SaveImage(filename3, ChartImageFormat.Jpeg);
                    MessageBox.Show("保存成功！请到相应路径下查看！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tabContro_Sales_statistic_analysis.SelectedTab.Equals(tabPage_color))
                {
                    filename += "/趋势";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    filename += "/颜色";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    string filename1 = filename + "/一年内颜色的趋势_圆环图.jpg";
                    chart_pie_color_Yearsalesgood.SaveImage(filename1, ChartImageFormat.Jpeg);
                    string month = "";//文件名的时间戳——月份
                    if (Convert.ToInt32(cboMonth.Text) <= 6)
                    {
                        month = "6";
                    }
                    else
                    {
                        month = cboMonth.Text;
                    }
                    string filename2 = filename + "/距离" + cboYear.Text + "-" + month + "_半年内颜色的趋势_圆环图.jpg";
                    chart_pie_color_Halfyearsalesgood.SaveImage(filename2, ChartImageFormat.Jpeg);
                    if (Convert.ToInt32(cboMonth.Text) <= 3)
                    {
                        month = "3";
                    }
                    else
                    {
                        month = cboMonth.Text;
                    }
                    string filename3 = filename + "/距离" + cboYear.Text + "-" + month + "_三个月内颜色的趋势_圆环图.jpg";
                    chart_pie_color_Threemonthsalesgood.SaveImage(filename3, ChartImageFormat.Jpeg);
                    MessageBox.Show("保存成功！请到相应路径下查看！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tabContro_Sales_statistic_analysis.SelectedTab.Equals(tabPage_Salesdetails))
                {
                    filename += "/盈利情况";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    string filename1 = filename + "/年度盈利情况_柱状图.jpg";
                    chart_Column_annual_sales.SaveImage(filename1, ChartImageFormat.Jpeg);
                    string filename2 = filename + "/季度盈利情况_柱状图.jpg";
                    chart_Column_quarter_sales.SaveImage(filename2, ChartImageFormat.Jpeg);
                    MessageBox.Show("保存成功！请到相应路径下查看！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tabContro_Sales_statistic_analysis.SelectedTab.Equals(tabPage_employee_annual_performance))
                {
                    filename += "/职工表现";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    filename += "/年度";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    string filename1 = filename + "/职工本年表现统计_柱状图.jpg";
                    chart_bar_annual_performance.SaveImage(filename1, ChartImageFormat.Jpeg);
                    string filename2 = filename + "/" + cboEmployee_name_annual.Text + "_本年所卖车辆组成_圆环图.jpg";
                    chart_pie_employee_salecarname.SaveImage(filename2, ChartImageFormat.Jpeg);
                    MessageBox.Show("保存成功！请到相应路径下查看！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (tabContro_Sales_statistic_analysis.SelectedTab.Equals(tabPage_employee_monthly_performance))
                {
                    filename += "/职工表现";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    filename += "/月度";
                    if (!Directory.Exists(filename))
                    {
                        // Create the directory it does not exist.
                        Directory.CreateDirectory(filename);
                    }
                    string filename1 = filename + "/" + cboEmployee_name_monthly.Text + "_月度表现_柱状图.jpg";
                    chart_column_monthly_employee_performance.SaveImage(filename1, ChartImageFormat.Jpeg);
                    MessageBox.Show("保存成功！请到相应路径下查看！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
