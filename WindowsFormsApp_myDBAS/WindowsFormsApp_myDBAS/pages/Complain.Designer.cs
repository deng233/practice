
namespace WindowsFormsApp_myDBAS
{
    partial class Complain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Complain));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtCustomer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvAftersales_complain = new System.Windows.Forms.DataGridView();
            this.complain_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complain_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.complainmemo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAftersales_complain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(1263, 468);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 45);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuery.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(1263, 264);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 45);
            this.btnQuery.TabIndex = 28;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            this.btnQuery.MouseHover += new System.EventHandler(this.btnQuery_MouseHover);
            // 
            // txtCustomer_name
            // 
            this.txtCustomer_name.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustomer_name.Location = new System.Drawing.Point(1350, 189);
            this.txtCustomer_name.Name = "txtCustomer_name";
            this.txtCustomer_name.Size = new System.Drawing.Size(135, 34);
            this.txtCustomer_name.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1178, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "客户名字 :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(1263, 361);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(605, 588);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(136, 59);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvAftersales_complain
            // 
            this.dgvAftersales_complain.AllowUserToResizeRows = false;
            this.dgvAftersales_complain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAftersales_complain.BackgroundColor = System.Drawing.Color.White;
            this.dgvAftersales_complain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAftersales_complain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complain_num,
            this.customer_num,
            this.customer_name1,
            this.complain_type,
            this.complainmemo,
            this.solution,
            this.add_date});
            this.dgvAftersales_complain.Location = new System.Drawing.Point(209, 121);
            this.dgvAftersales_complain.Name = "dgvAftersales_complain";
            this.dgvAftersales_complain.RowHeadersWidth = 51;
            this.dgvAftersales_complain.RowTemplate.Height = 27;
            this.dgvAftersales_complain.Size = new System.Drawing.Size(898, 437);
            this.dgvAftersales_complain.TabIndex = 23;
            this.dgvAftersales_complain.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAftersales_complain_DefaultValuesNeeded);
            // 
            // complain_num
            // 
            this.complain_num.DataPropertyName = "complain_num";
            this.complain_num.HeaderText = "投诉编号";
            this.complain_num.MinimumWidth = 6;
            this.complain_num.Name = "complain_num";
            this.complain_num.ReadOnly = true;
            this.complain_num.Width = 96;
            // 
            // customer_num
            // 
            this.customer_num.DataPropertyName = "customer_num";
            this.customer_num.HeaderText = "客户编号";
            this.customer_num.MinimumWidth = 6;
            this.customer_num.Name = "customer_num";
            this.customer_num.Width = 96;
            // 
            // customer_name1
            // 
            this.customer_name1.DataPropertyName = "customer_name";
            this.customer_name1.HeaderText = "客户姓名";
            this.customer_name1.MinimumWidth = 6;
            this.customer_name1.Name = "customer_name1";
            this.customer_name1.Width = 96;
            // 
            // complain_type
            // 
            this.complain_type.DataPropertyName = "complain_type";
            this.complain_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.complain_type.HeaderText = "投诉类型";
            this.complain_type.Items.AddRange(new object[] {
            "服务投诉",
            "价格投诉",
            "质量投诉"});
            this.complain_type.MinimumWidth = 6;
            this.complain_type.Name = "complain_type";
            this.complain_type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.complain_type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.complain_type.Width = 96;
            // 
            // complainmemo
            // 
            this.complainmemo.DataPropertyName = "complainmemo";
            this.complainmemo.HeaderText = "投诉内容";
            this.complainmemo.MinimumWidth = 6;
            this.complainmemo.Name = "complainmemo";
            this.complainmemo.Width = 96;
            // 
            // solution
            // 
            this.solution.DataPropertyName = "solution";
            this.solution.HeaderText = "解决方案";
            this.solution.MinimumWidth = 6;
            this.solution.Name = "solution";
            this.solution.Width = 96;
            // 
            // add_date
            // 
            this.add_date.DataPropertyName = "add_date";
            this.add_date.HeaderText = "创建时间";
            this.add_date.MinimumWidth = 6;
            this.add_date.Name = "add_date";
            this.add_date.ReadOnly = true;
            this.add_date.Width = 96;
            // 
            // Complain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_myDBAS.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1694, 768);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtCustomer_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dgvAftersales_complain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Complain";
            this.Text = "投诉反馈";
            this.Load += new System.EventHandler(this.Complain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAftersales_complain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtCustomer_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvAftersales_complain;
        private System.Windows.Forms.DataGridViewTextBoxColumn complain_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name1;
        private System.Windows.Forms.DataGridViewComboBoxColumn complain_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainmemo;
        private System.Windows.Forms.DataGridViewTextBoxColumn solution;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_date;
    }
}