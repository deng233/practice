
namespace WindowsFormsApp_myDBAS
{
    partial class Sales_record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_record));
            this.dgvCarsales_info = new System.Windows.Forms.DataGridView();
            this.carsales_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsales_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsales_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsales_salesamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsales_handlernum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsales_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCarsales_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarsales_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsales_info)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCarsales_info
            // 
            this.dgvCarsales_info.AllowUserToDeleteRows = false;
            this.dgvCarsales_info.AllowUserToResizeColumns = false;
            this.dgvCarsales_info.AllowUserToResizeRows = false;
            this.dgvCarsales_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarsales_info.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarsales_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarsales_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carsales_num,
            this.car_num,
            this.car_name,
            this.carsales_type,
            this.carsales_color,
            this.customer_name,
            this.customer_num,
            this.amount,
            this.carsales_salesamount,
            this.carsales_handlernum,
            this.carsales_date});
            this.dgvCarsales_info.Location = new System.Drawing.Point(0, 89);
            this.dgvCarsales_info.Name = "dgvCarsales_info";
            this.dgvCarsales_info.RowHeadersWidth = 51;
            this.dgvCarsales_info.RowTemplate.Height = 27;
            this.dgvCarsales_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarsales_info.Size = new System.Drawing.Size(1428, 533);
            this.dgvCarsales_info.TabIndex = 0;
            this.dgvCarsales_info.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvCarsales_info_DefaultValuesNeeded);
            // 
            // carsales_num
            // 
            this.carsales_num.DataPropertyName = "carsales_num";
            this.carsales_num.HeaderText = "销售编号";
            this.carsales_num.MinimumWidth = 6;
            this.carsales_num.Name = "carsales_num";
            this.carsales_num.ReadOnly = true;
            // 
            // car_num
            // 
            this.car_num.DataPropertyName = "car_num";
            this.car_num.HeaderText = "轿车编号";
            this.car_num.MinimumWidth = 6;
            this.car_num.Name = "car_num";
            // 
            // car_name
            // 
            this.car_name.DataPropertyName = "car_name";
            this.car_name.HeaderText = "轿车名字";
            this.car_name.MinimumWidth = 6;
            this.car_name.Name = "car_name";
            // 
            // carsales_type
            // 
            this.carsales_type.DataPropertyName = "carsales_type";
            this.carsales_type.HeaderText = "类型";
            this.carsales_type.MinimumWidth = 6;
            this.carsales_type.Name = "carsales_type";
            // 
            // carsales_color
            // 
            this.carsales_color.DataPropertyName = "carsales_color";
            this.carsales_color.HeaderText = "颜色";
            this.carsales_color.MinimumWidth = 6;
            this.carsales_color.Name = "carsales_color";
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "客户名字";
            this.customer_name.MinimumWidth = 6;
            this.customer_name.Name = "customer_name";
            // 
            // customer_num
            // 
            this.customer_num.DataPropertyName = "customer_num";
            this.customer_num.HeaderText = "客户编号";
            this.customer_num.MinimumWidth = 6;
            this.customer_num.Name = "customer_num";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "数量";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            // 
            // carsales_salesamount
            // 
            this.carsales_salesamount.DataPropertyName = "caesales_salesamount";
            this.carsales_salesamount.HeaderText = "成交价";
            this.carsales_salesamount.MinimumWidth = 6;
            this.carsales_salesamount.Name = "carsales_salesamount";
            // 
            // carsales_handlernum
            // 
            this.carsales_handlernum.DataPropertyName = "carsales_handlernum";
            this.carsales_handlernum.HeaderText = "经手人工号";
            this.carsales_handlernum.MinimumWidth = 6;
            this.carsales_handlernum.Name = "carsales_handlernum";
            // 
            // carsales_date
            // 
            this.carsales_date.DataPropertyName = "carsales_date";
            this.carsales_date.HeaderText = "日期";
            this.carsales_date.MinimumWidth = 6;
            this.carsales_date.Name = "carsales_date";
            this.carsales_date.ReadOnly = true;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(403, 655);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 45);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(605, 655);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuery.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(145, 189);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(110, 45);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(1579, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 45);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtCarsales_name
            // 
            this.txtCarsales_name.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCarsales_name.Location = new System.Drawing.Point(195, 102);
            this.txtCarsales_name.Name = "txtCarsales_name";
            this.txtCarsales_name.Size = new System.Drawing.Size(135, 34);
            this.txtCarsales_name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "轿车名字 ：";
            // 
            // txtCarsales_num
            // 
            this.txtCarsales_num.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCarsales_num.Location = new System.Drawing.Point(195, 39);
            this.txtCarsales_num.Name = "txtCarsales_num";
            this.txtCarsales_num.Size = new System.Drawing.Size(135, 34);
            this.txtCarsales_num.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(25, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "销售编号 ：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.txtCarsales_num);
            this.groupBox1.Controls.Add(this.txtCarsales_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(1434, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 240);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "任填一项便可检索";
            // 
            // Sales_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApp_myDBAS.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 768);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvCarsales_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales_record";
            this.Text = "销售记录";
            this.Load += new System.EventHandler(this.Sales_record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsales_info)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCarsales_info;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCarsales_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarsales_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsales_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsales_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsales_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsales_salesamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsales_handlernum;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsales_date;
    }
}