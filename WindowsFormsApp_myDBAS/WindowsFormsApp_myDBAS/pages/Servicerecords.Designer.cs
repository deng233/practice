
namespace WindowsFormsApp_myDBAS
{
    partial class Servicerecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicerecords));
            this.dgvAftersales_servicerecords = new System.Windows.Forms.DataGridView();
            this.record_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtCustomer_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAftersales_servicerecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAftersales_servicerecords
            // 
            this.dgvAftersales_servicerecords.AllowUserToResizeColumns = false;
            this.dgvAftersales_servicerecords.AllowUserToResizeRows = false;
            this.dgvAftersales_servicerecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAftersales_servicerecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvAftersales_servicerecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAftersales_servicerecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.record_num,
            this.customer_num,
            this.customer_name1,
            this.memo,
            this.add_date});
            this.dgvAftersales_servicerecords.Location = new System.Drawing.Point(144, 111);
            this.dgvAftersales_servicerecords.Name = "dgvAftersales_servicerecords";
            this.dgvAftersales_servicerecords.RowHeadersWidth = 51;
            this.dgvAftersales_servicerecords.RowTemplate.Height = 27;
            this.dgvAftersales_servicerecords.Size = new System.Drawing.Size(898, 437);
            this.dgvAftersales_servicerecords.TabIndex = 14;
            this.dgvAftersales_servicerecords.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAftersales_servicerecords_DefaultValuesNeeded);
            // 
            // record_num
            // 
            this.record_num.DataPropertyName = "record_num";
            this.record_num.HeaderText = "记录编号";
            this.record_num.MinimumWidth = 6;
            this.record_num.Name = "record_num";
            this.record_num.ReadOnly = true;
            // 
            // customer_num
            // 
            this.customer_num.DataPropertyName = "customer_num";
            this.customer_num.HeaderText = "客户编号";
            this.customer_num.MinimumWidth = 6;
            this.customer_num.Name = "customer_num";
            // 
            // customer_name1
            // 
            this.customer_name1.DataPropertyName = "customer_name";
            this.customer_name1.HeaderText = "客户姓名";
            this.customer_name1.MinimumWidth = 6;
            this.customer_name1.Name = "customer_name1";
            // 
            // memo
            // 
            this.memo.DataPropertyName = "memo";
            this.memo.HeaderText = "服务内容";
            this.memo.MinimumWidth = 6;
            this.memo.Name = "memo";
            // 
            // add_date
            // 
            this.add_date.DataPropertyName = "add_date";
            this.add_date.HeaderText = "创建时间";
            this.add_date.MinimumWidth = 6;
            this.add_date.Name = "add_date";
            this.add_date.ReadOnly = true;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(540, 578);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(136, 59);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(1198, 351);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuery.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(1198, 254);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 45);
            this.btnQuery.TabIndex = 21;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            this.btnQuery.MouseHover += new System.EventHandler(this.btnQuery_MouseHover);
            // 
            // txtCustomer_name
            // 
            this.txtCustomer_name.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustomer_name.Location = new System.Drawing.Point(1285, 179);
            this.txtCustomer_name.Name = "txtCustomer_name";
            this.txtCustomer_name.Size = new System.Drawing.Size(135, 34);
            this.txtCustomer_name.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1113, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "客户名字 :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRefresh.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.Location = new System.Drawing.Point(1198, 458);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 45);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Servicerecords
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
            this.Controls.Add(this.dgvAftersales_servicerecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servicerecords";
            this.Text = "服务记录";
            this.Load += new System.EventHandler(this.Servicerecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAftersales_servicerecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAftersales_servicerecords;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtCustomer_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn record_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_date;
    }
}