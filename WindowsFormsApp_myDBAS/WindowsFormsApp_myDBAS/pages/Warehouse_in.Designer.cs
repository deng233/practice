
namespace WindowsFormsApp_myDBAS
{
    partial class Warehouse_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse_in));
            this.dgvCar_info = new System.Windows.Forms.DataGridView();
            this.car_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_dateofmanufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_innumfirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_fillingCar_info = new System.Windows.Forms.Panel();
            this.panel_Feedback = new System.Windows.Forms.Panel();
            this.btnFeedbackconfirm = new System.Windows.Forms.Button();
            this.dgvFeedbacktable = new System.Windows.Forms.DataGridView();
            this.Warehouse_innum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_inamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouse_indate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar_info)).BeginInit();
            this.panel_fillingCar_info.SuspendLayout();
            this.panel_Feedback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacktable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCar_info
            // 
            this.dgvCar_info.AllowUserToDeleteRows = false;
            this.dgvCar_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCar_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.car_num,
            this.car_name,
            this.car_type,
            this.car_color,
            this.car_manufacturer,
            this.car_dateofmanufacture,
            this.car_price,
            this.car_amount,
            this.warehouse_innumfirst});
            this.dgvCar_info.Location = new System.Drawing.Point(32, 124);
            this.dgvCar_info.Name = "dgvCar_info";
            this.dgvCar_info.RowHeadersWidth = 51;
            this.dgvCar_info.RowTemplate.Height = 27;
            this.dgvCar_info.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCar_info.Size = new System.Drawing.Size(1260, 57);
            this.dgvCar_info.TabIndex = 8;
            this.dgvCar_info.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCar_info_CellLeave);
            this.dgvCar_info.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewcar_info_DefaultValuesNeeded);
            // 
            // car_num
            // 
            this.car_num.FillWeight = 93.2063F;
            this.car_num.HeaderText = "轿车编号";
            this.car_num.MinimumWidth = 6;
            this.car_num.Name = "car_num";
            this.car_num.ReadOnly = true;
            // 
            // car_name
            // 
            this.car_name.FillWeight = 95.35007F;
            this.car_name.HeaderText = "轿车名字";
            this.car_name.MinimumWidth = 6;
            this.car_name.Name = "car_name";
            // 
            // car_type
            // 
            this.car_type.FillWeight = 97.27182F;
            this.car_type.HeaderText = "类型";
            this.car_type.MinimumWidth = 6;
            this.car_type.Name = "car_type";
            // 
            // car_color
            // 
            this.car_color.FillWeight = 98.99455F;
            this.car_color.HeaderText = "颜色";
            this.car_color.MinimumWidth = 6;
            this.car_color.Name = "car_color";
            // 
            // car_manufacturer
            // 
            this.car_manufacturer.FillWeight = 100.5389F;
            this.car_manufacturer.HeaderText = "生产厂家";
            this.car_manufacturer.MinimumWidth = 6;
            this.car_manufacturer.Name = "car_manufacturer";
            // 
            // car_dateofmanufacture
            // 
            this.car_dateofmanufacture.FillWeight = 101.9233F;
            this.car_dateofmanufacture.HeaderText = "生产日期";
            this.car_dateofmanufacture.MinimumWidth = 6;
            this.car_dateofmanufacture.Name = "car_dateofmanufacture";
            // 
            // car_price
            // 
            this.car_price.FillWeight = 103.1643F;
            this.car_price.HeaderText = "价格";
            this.car_price.MinimumWidth = 6;
            this.car_price.Name = "car_price";
            // 
            // car_amount
            // 
            this.car_amount.FillWeight = 104.2768F;
            this.car_amount.HeaderText = "数量";
            this.car_amount.MinimumWidth = 6;
            this.car_amount.Name = "car_amount";
            // 
            // warehouse_innumfirst
            // 
            this.warehouse_innumfirst.FillWeight = 105.2741F;
            this.warehouse_innumfirst.HeaderText = "入库编号";
            this.warehouse_innumfirst.MinimumWidth = 6;
            this.warehouse_innumfirst.Name = "warehouse_innumfirst";
            this.warehouse_innumfirst.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(28, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "轿车信息表 :";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(519, 510);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 45);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(801, 510);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 45);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(28, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "填表完成后，将自动创建入库记录！";
            // 
            // panel_fillingCar_info
            // 
            this.panel_fillingCar_info.BackColor = System.Drawing.Color.Transparent;
            this.panel_fillingCar_info.Controls.Add(this.panel_Feedback);
            this.panel_fillingCar_info.Controls.Add(this.label1);
            this.panel_fillingCar_info.Controls.Add(this.label2);
            this.panel_fillingCar_info.Controls.Add(this.dgvCar_info);
            this.panel_fillingCar_info.Location = new System.Drawing.Point(12, 188);
            this.panel_fillingCar_info.Name = "panel_fillingCar_info";
            this.panel_fillingCar_info.Size = new System.Drawing.Size(1377, 258);
            this.panel_fillingCar_info.TabIndex = 13;
            // 
            // panel_Feedback
            // 
            this.panel_Feedback.BackColor = System.Drawing.Color.Transparent;
            this.panel_Feedback.Controls.Add(this.btnFeedbackconfirm);
            this.panel_Feedback.Controls.Add(this.dgvFeedbacktable);
            this.panel_Feedback.Controls.Add(this.label3);
            this.panel_Feedback.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel_Feedback.Location = new System.Drawing.Point(0, 0);
            this.panel_Feedback.Name = "panel_Feedback";
            this.panel_Feedback.Size = new System.Drawing.Size(1380, 258);
            this.panel_Feedback.TabIndex = 14;
            // 
            // btnFeedbackconfirm
            // 
            this.btnFeedbackconfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFeedbackconfirm.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFeedbackconfirm.Location = new System.Drawing.Point(647, 83);
            this.btnFeedbackconfirm.Name = "btnFeedbackconfirm";
            this.btnFeedbackconfirm.Size = new System.Drawing.Size(86, 35);
            this.btnFeedbackconfirm.TabIndex = 15;
            this.btnFeedbackconfirm.Text = "确定";
            this.btnFeedbackconfirm.UseVisualStyleBackColor = false;
            this.btnFeedbackconfirm.Click += new System.EventHandler(this.btnFeedbackconfirm_Click);
            // 
            // dgvFeedbacktable
            // 
            this.dgvFeedbacktable.AllowUserToAddRows = false;
            this.dgvFeedbacktable.AllowUserToDeleteRows = false;
            this.dgvFeedbacktable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFeedbacktable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeedbacktable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Warehouse_innum,
            this.carnum,
            this.warehouse_inamount,
            this.warehouse_indate});
            this.dgvFeedbacktable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvFeedbacktable.Location = new System.Drawing.Point(33, 74);
            this.dgvFeedbacktable.Name = "dgvFeedbacktable";
            this.dgvFeedbacktable.ReadOnly = true;
            this.dgvFeedbacktable.RowHeadersVisible = false;
            this.dgvFeedbacktable.RowHeadersWidth = 51;
            this.dgvFeedbacktable.RowTemplate.Height = 27;
            this.dgvFeedbacktable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvFeedbacktable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeedbacktable.Size = new System.Drawing.Size(584, 54);
            this.dgvFeedbacktable.TabIndex = 11;
            // 
            // Warehouse_innum
            // 
            this.Warehouse_innum.DataPropertyName = "Warehouse_innum";
            this.Warehouse_innum.HeaderText = "入库编号";
            this.Warehouse_innum.MinimumWidth = 6;
            this.Warehouse_innum.Name = "Warehouse_innum";
            this.Warehouse_innum.ReadOnly = true;
            // 
            // carnum
            // 
            this.carnum.DataPropertyName = "car_num";
            this.carnum.HeaderText = "轿车编号";
            this.carnum.MinimumWidth = 6;
            this.carnum.Name = "carnum";
            this.carnum.ReadOnly = true;
            // 
            // warehouse_inamount
            // 
            this.warehouse_inamount.DataPropertyName = "amount";
            this.warehouse_inamount.HeaderText = "库存";
            this.warehouse_inamount.MinimumWidth = 6;
            this.warehouse_inamount.Name = "warehouse_inamount";
            this.warehouse_inamount.ReadOnly = true;
            // 
            // warehouse_indate
            // 
            this.warehouse_indate.DataPropertyName = "warehouse_indate";
            this.warehouse_indate.HeaderText = "日期";
            this.warehouse_indate.MinimumWidth = 6;
            this.warehouse_indate.Name = "warehouse_indate";
            this.warehouse_indate.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(29, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "成功！入库记录为：";
            // 
            // Warehouse_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_myDBAS.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1694, 768);
            this.Controls.Add(this.panel_fillingCar_info);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warehouse_in";
            this.Text = "入库管理";
            this.Load += new System.EventHandler(this.Warehouse_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar_info)).EndInit();
            this.panel_fillingCar_info.ResumeLayout(false);
            this.panel_fillingCar_info.PerformLayout();
            this.panel_Feedback.ResumeLayout(false);
            this.panel_Feedback.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedbacktable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCar_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_fillingCar_info;
        private System.Windows.Forms.Panel panel_Feedback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvFeedbacktable;
        private System.Windows.Forms.Button btnFeedbackconfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_color;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_dateofmanufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_innumfirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse_innum;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_inamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_indate;
    }
}