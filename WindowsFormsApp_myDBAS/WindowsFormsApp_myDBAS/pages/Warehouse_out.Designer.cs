
namespace WindowsFormsApp_myDBAS
{
    partial class Warehouse_out
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse_out));
            this.dgvWarehouse_out_confirm = new System.Windows.Forms.DataGridView();
            this.Warehouse_innum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsales_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWaite_tips = new System.Windows.Forms.Label();
            this.panelwaitfor_out = new System.Windows.Forms.Panel();
            this.txtSales_num = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSales_num = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvWarehouse_out = new System.Windows.Forms.DataGridView();
            this.Warehouse_outnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warehouse_innum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsales_num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnQuerybynum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse_out_confirm)).BeginInit();
            this.panelwaitfor_out.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse_out)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWarehouse_out_confirm
            // 
            this.dgvWarehouse_out_confirm.AllowUserToAddRows = false;
            this.dgvWarehouse_out_confirm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouse_out_confirm.BackgroundColor = System.Drawing.Color.White;
            this.dgvWarehouse_out_confirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse_out_confirm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Warehouse_innum,
            this.car_num,
            this.amount,
            this.carsales_num});
            this.dgvWarehouse_out_confirm.Location = new System.Drawing.Point(167, 10);
            this.dgvWarehouse_out_confirm.Name = "dgvWarehouse_out_confirm";
            this.dgvWarehouse_out_confirm.ReadOnly = true;
            this.dgvWarehouse_out_confirm.RowHeadersVisible = false;
            this.dgvWarehouse_out_confirm.RowHeadersWidth = 51;
            this.dgvWarehouse_out_confirm.RowTemplate.Height = 27;
            this.dgvWarehouse_out_confirm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouse_out_confirm.Size = new System.Drawing.Size(898, 259);
            this.dgvWarehouse_out_confirm.TabIndex = 0;
            // 
            // Warehouse_innum
            // 
            this.Warehouse_innum.DataPropertyName = "Warehouse_innum";
            this.Warehouse_innum.HeaderText = "入库编号";
            this.Warehouse_innum.MinimumWidth = 6;
            this.Warehouse_innum.Name = "Warehouse_innum";
            this.Warehouse_innum.ReadOnly = true;
            // 
            // car_num
            // 
            this.car_num.DataPropertyName = "car_num";
            this.car_num.HeaderText = "轿车编号";
            this.car_num.MinimumWidth = 6;
            this.car_num.Name = "car_num";
            this.car_num.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "数量";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // carsales_num
            // 
            this.carsales_num.DataPropertyName = "carsales_num";
            this.carsales_num.HeaderText = "销售编号";
            this.carsales_num.MinimumWidth = 6;
            this.carsales_num.Name = "carsales_num";
            this.carsales_num.ReadOnly = true;
            // 
            // lblWaite_tips
            // 
            this.lblWaite_tips.AutoSize = true;
            this.lblWaite_tips.BackColor = System.Drawing.Color.Transparent;
            this.lblWaite_tips.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWaite_tips.Location = new System.Drawing.Point(6, 10);
            this.lblWaite_tips.Name = "lblWaite_tips";
            this.lblWaite_tips.Size = new System.Drawing.Size(118, 24);
            this.lblWaite_tips.TabIndex = 3;
            this.lblWaite_tips.Text = "待出库 ：";
            // 
            // panelwaitfor_out
            // 
            this.panelwaitfor_out.BackColor = System.Drawing.Color.Transparent;
            this.panelwaitfor_out.Controls.Add(this.txtSales_num);
            this.panelwaitfor_out.Controls.Add(this.dgvWarehouse_out_confirm);
            this.panelwaitfor_out.Controls.Add(this.btnClose);
            this.panelwaitfor_out.Controls.Add(this.lblSales_num);
            this.panelwaitfor_out.Controls.Add(this.lblWaite_tips);
            this.panelwaitfor_out.Controls.Add(this.btnSearch);
            this.panelwaitfor_out.Location = new System.Drawing.Point(98, 2);
            this.panelwaitfor_out.Name = "panelwaitfor_out";
            this.panelwaitfor_out.Size = new System.Drawing.Size(1228, 276);
            this.panelwaitfor_out.TabIndex = 4;
            // 
            // txtSales_num
            // 
            this.txtSales_num.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSales_num.Location = new System.Drawing.Point(540, 226);
            this.txtSales_num.Name = "txtSales_num";
            this.txtSales_num.Size = new System.Drawing.Size(139, 34);
            this.txtSales_num.TabIndex = 22;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(1118, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSales_num
            // 
            this.lblSales_num.AutoSize = true;
            this.lblSales_num.BackColor = System.Drawing.Color.Transparent;
            this.lblSales_num.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSales_num.Location = new System.Drawing.Point(390, 228);
            this.lblSales_num.Name = "lblSales_num";
            this.lblSales_num.Size = new System.Drawing.Size(144, 25);
            this.lblSales_num.TabIndex = 21;
            this.lblSales_num.Text = "销售编号 :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(711, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 58);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvWarehouse_out
            // 
            this.dgvWarehouse_out.AllowUserToDeleteRows = false;
            this.dgvWarehouse_out.AllowUserToResizeColumns = false;
            this.dgvWarehouse_out.AllowUserToResizeRows = false;
            this.dgvWarehouse_out.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWarehouse_out.BackgroundColor = System.Drawing.Color.White;
            this.dgvWarehouse_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouse_out.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Warehouse_outnum,
            this.Warehouse_innum1,
            this.car_num1,
            this.amount1,
            this.carsales_num1,
            this.date});
            this.dgvWarehouse_out.Location = new System.Drawing.Point(265, 284);
            this.dgvWarehouse_out.Name = "dgvWarehouse_out";
            this.dgvWarehouse_out.RowHeadersWidth = 51;
            this.dgvWarehouse_out.RowTemplate.Height = 27;
            this.dgvWarehouse_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarehouse_out.Size = new System.Drawing.Size(898, 437);
            this.dgvWarehouse_out.TabIndex = 5;
            this.dgvWarehouse_out.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvWarehouse_out_DefaultValuesNeeded);
            this.dgvWarehouse_out.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWarehouse_out_RowEnter);
            // 
            // Warehouse_outnum
            // 
            this.Warehouse_outnum.DataPropertyName = "Warehouse_outnum";
            this.Warehouse_outnum.HeaderText = "出库编号";
            this.Warehouse_outnum.MinimumWidth = 6;
            this.Warehouse_outnum.Name = "Warehouse_outnum";
            this.Warehouse_outnum.ReadOnly = true;
            // 
            // Warehouse_innum1
            // 
            this.Warehouse_innum1.DataPropertyName = "Warehouse_innum";
            this.Warehouse_innum1.HeaderText = "入库编号";
            this.Warehouse_innum1.MinimumWidth = 6;
            this.Warehouse_innum1.Name = "Warehouse_innum1";
            // 
            // car_num1
            // 
            this.car_num1.DataPropertyName = "car_num";
            this.car_num1.HeaderText = "轿车编号";
            this.car_num1.MinimumWidth = 6;
            this.car_num1.Name = "car_num1";
            // 
            // amount1
            // 
            this.amount1.DataPropertyName = "amount";
            this.amount1.HeaderText = "数量";
            this.amount1.MinimumWidth = 6;
            this.amount1.Name = "amount1";
            // 
            // carsales_num1
            // 
            this.carsales_num1.DataPropertyName = "carsales_num";
            this.carsales_num1.HeaderText = "销售编号";
            this.carsales_num1.MinimumWidth = 6;
            this.carsales_num1.Name = "carsales_num1";
            // 
            // date
            // 
            this.date.DataPropertyName = "Warehouse_outdate";
            this.date.HeaderText = "日期";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(1216, 397);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(1216, 575);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 45);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(104, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "出库记录 ：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuery.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(1216, 308);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(152, 45);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.Text = "查看待出库";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnQuerybynum
            // 
            this.btnQuerybynum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuerybynum.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuerybynum.Location = new System.Drawing.Point(1216, 480);
            this.btnQuerybynum.Name = "btnQuerybynum";
            this.btnQuerybynum.Size = new System.Drawing.Size(100, 45);
            this.btnQuerybynum.TabIndex = 23;
            this.btnQuerybynum.Text = "查询";
            this.btnQuerybynum.UseVisualStyleBackColor = false;
            this.btnQuerybynum.Click += new System.EventHandler(this.btnQuerybynum_Click);
            // 
            // Warehouse_out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_myDBAS.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1694, 768);
            this.Controls.Add(this.btnQuerybynum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.dgvWarehouse_out);
            this.Controls.Add(this.panelwaitfor_out);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warehouse_out";
            this.Text = "出库管理";
            this.Load += new System.EventHandler(this.Warehouse_out_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse_out_confirm)).EndInit();
            this.panelwaitfor_out.ResumeLayout(false);
            this.panelwaitfor_out.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouse_out)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWarehouse_out_confirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse_innum;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsales_num;
        private System.Windows.Forms.Label lblWaite_tips;
        private System.Windows.Forms.Panel panelwaitfor_out;
        private System.Windows.Forms.DataGridView dgvWarehouse_out;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse_outnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warehouse_innum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn car_num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carsales_num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.TextBox txtSales_num;
        private System.Windows.Forms.Label lblSales_num;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnQuerybynum;
    }
}