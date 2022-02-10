
namespace WindowsFormsApp_myDBAS
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnQuery_waite = new System.Windows.Forms.Button();
            this.dgvAftersales_customer = new System.Windows.Forms.DataGridView();
            this.customer_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_contact1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelwaitfor = new System.Windows.Forms.Panel();
            this.dgvAftersales_customerwait = new System.Windows.Forms.DataGridView();
            this.customer_num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtCustomer_name = new System.Windows.Forms.TextBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblWaite_tips = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAftersales_customer)).BeginInit();
            this.panelwaitfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAftersales_customerwait)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(84, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "会员列表 ：";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(1196, 596);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 45);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(1196, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 45);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnQuery_waite
            // 
            this.btnQuery_waite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuery_waite.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery_waite.Location = new System.Drawing.Point(1196, 287);
            this.btnQuery_waite.Name = "btnQuery_waite";
            this.btnQuery_waite.Size = new System.Drawing.Size(152, 45);
            this.btnQuery_waite.TabIndex = 14;
            this.btnQuery_waite.Text = "查看待录入";
            this.btnQuery_waite.UseVisualStyleBackColor = false;
            this.btnQuery_waite.Click += new System.EventHandler(this.btnQuery_waite_Click);
            // 
            // dgvAftersales_customer
            // 
            this.dgvAftersales_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAftersales_customer.BackgroundColor = System.Drawing.Color.White;
            this.dgvAftersales_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAftersales_customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_num,
            this.customer_name1,
            this.customer_contact1,
            this.servicetime,
            this.add_date});
            this.dgvAftersales_customer.Location = new System.Drawing.Point(245, 290);
            this.dgvAftersales_customer.Name = "dgvAftersales_customer";
            this.dgvAftersales_customer.RowHeadersWidth = 51;
            this.dgvAftersales_customer.RowTemplate.Height = 27;
            this.dgvAftersales_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAftersales_customer.Size = new System.Drawing.Size(898, 437);
            this.dgvAftersales_customer.TabIndex = 13;
            this.dgvAftersales_customer.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvAftersales_customer_DefaultValuesNeeded);
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
            // customer_contact1
            // 
            this.customer_contact1.DataPropertyName = "customer_contact";
            this.customer_contact1.HeaderText = "联系方式";
            this.customer_contact1.MinimumWidth = 6;
            this.customer_contact1.Name = "customer_contact1";
            // 
            // servicetime
            // 
            this.servicetime.DataPropertyName = "servicetime";
            this.servicetime.HeaderText = "服务时间";
            this.servicetime.MinimumWidth = 6;
            this.servicetime.Name = "servicetime";
            // 
            // add_date
            // 
            this.add_date.DataPropertyName = "add_date";
            this.add_date.HeaderText = "创建时间";
            this.add_date.MinimumWidth = 6;
            this.add_date.Name = "add_date";
            this.add_date.ReadOnly = true;
            // 
            // panelwaitfor
            // 
            this.panelwaitfor.BackColor = System.Drawing.Color.Transparent;
            this.panelwaitfor.Controls.Add(this.dgvAftersales_customerwait);
            this.panelwaitfor.Controls.Add(this.btnClose);
            this.panelwaitfor.Controls.Add(this.txtCustomer_name);
            this.panelwaitfor.Controls.Add(this.lblMember);
            this.panelwaitfor.Controls.Add(this.btnSearch);
            this.panelwaitfor.Controls.Add(this.lblWaite_tips);
            this.panelwaitfor.Location = new System.Drawing.Point(78, 8);
            this.panelwaitfor.Name = "panelwaitfor";
            this.panelwaitfor.Size = new System.Drawing.Size(1228, 245);
            this.panelwaitfor.TabIndex = 12;
            // 
            // dgvAftersales_customerwait
            // 
            this.dgvAftersales_customerwait.AllowUserToAddRows = false;
            this.dgvAftersales_customerwait.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAftersales_customerwait.BackgroundColor = System.Drawing.Color.White;
            this.dgvAftersales_customerwait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAftersales_customerwait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customer_num1,
            this.customer_name,
            this.customer_contact});
            this.dgvAftersales_customerwait.Location = new System.Drawing.Point(167, 14);
            this.dgvAftersales_customerwait.Name = "dgvAftersales_customerwait";
            this.dgvAftersales_customerwait.ReadOnly = true;
            this.dgvAftersales_customerwait.RowHeadersVisible = false;
            this.dgvAftersales_customerwait.RowHeadersWidth = 51;
            this.dgvAftersales_customerwait.RowTemplate.Height = 27;
            this.dgvAftersales_customerwait.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAftersales_customerwait.Size = new System.Drawing.Size(528, 228);
            this.dgvAftersales_customerwait.TabIndex = 0;
            // 
            // customer_num1
            // 
            this.customer_num1.DataPropertyName = "customer_num";
            this.customer_num1.HeaderText = "客户编号";
            this.customer_num1.MinimumWidth = 6;
            this.customer_num1.Name = "customer_num1";
            this.customer_num1.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "客户姓名";
            this.customer_name.MinimumWidth = 6;
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // customer_contact
            // 
            this.customer_contact.DataPropertyName = "customer_contact";
            this.customer_contact.HeaderText = "联系方式";
            this.customer_contact.MinimumWidth = 6;
            this.customer_contact.Name = "customer_contact";
            this.customer_contact.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(1118, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 45);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCustomer_name
            // 
            this.txtCustomer_name.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCustomer_name.Location = new System.Drawing.Point(576, 199);
            this.txtCustomer_name.Name = "txtCustomer_name";
            this.txtCustomer_name.Size = new System.Drawing.Size(139, 34);
            this.txtCustomer_name.TabIndex = 19;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.BackColor = System.Drawing.Color.Transparent;
            this.lblMember.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMember.Location = new System.Drawing.Point(426, 201);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(144, 25);
            this.lblMember.TabIndex = 18;
            this.lblMember.Text = "客户姓名 :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(747, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 58);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // lblWaite_tips
            // 
            this.lblWaite_tips.AutoSize = true;
            this.lblWaite_tips.BackColor = System.Drawing.Color.Transparent;
            this.lblWaite_tips.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWaite_tips.Location = new System.Drawing.Point(33, 14);
            this.lblWaite_tips.Name = "lblWaite_tips";
            this.lblWaite_tips.Size = new System.Drawing.Size(118, 24);
            this.lblWaite_tips.TabIndex = 3;
            this.lblWaite_tips.Text = "待录入 ：";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnQuery.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(1196, 448);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 45);
            this.btnQuery.TabIndex = 22;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(1196, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 45);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Members
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::WindowsFormsApp_myDBAS.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1746, 768);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnQuery_waite);
            this.Controls.Add(this.dgvAftersales_customer);
            this.Controls.Add(this.panelwaitfor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Members";
            this.Text = "会员名单管理";
            this.Load += new System.EventHandler(this.Members_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAftersales_customer)).EndInit();
            this.panelwaitfor.ResumeLayout(false);
            this.panelwaitfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAftersales_customerwait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnQuery_waite;
        private System.Windows.Forms.DataGridView dgvAftersales_customer;
        private System.Windows.Forms.Panel panelwaitfor;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvAftersales_customerwait;
        private System.Windows.Forms.Label lblWaite_tips;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_contact;
        private System.Windows.Forms.TextBox txtCustomer_name;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_contact1;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn add_date;
    }
}