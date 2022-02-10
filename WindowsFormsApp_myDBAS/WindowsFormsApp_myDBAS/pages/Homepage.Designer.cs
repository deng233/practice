
namespace WindowsFormsApp_myDBAS
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.label_temp = new System.Windows.Forms.Label();
            this.账户管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetPasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehouseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_inMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_outMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Warehouse_queryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Customer_managementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sales_recordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看库存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Personal_performanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AftersaleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MembersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServicerecordsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComplainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Department_managerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Employee_managementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sales_statistic_analysisMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxHead = new System.Windows.Forms.PictureBox();
            this.pictureBoxCEO = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.pictureBoxDepartment_warehouse = new System.Windows.Forms.PictureBox();
            this.pictureBoxDepartment_sale = new System.Windows.Forms.PictureBox();
            this.pictureBoxDepartment_CEO = new System.Windows.Forms.PictureBox();
            this.pictureBoxDepartment_aftersale = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment_warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment_sale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment_CEO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment_aftersale)).BeginInit();
            this.SuspendLayout();
            // 
            // label_temp
            // 
            this.label_temp.AutoSize = true;
            this.label_temp.BackColor = System.Drawing.Color.Transparent;
            this.label_temp.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_temp.ForeColor = System.Drawing.Color.Black;
            this.label_temp.Location = new System.Drawing.Point(1340, 46);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(128, 28);
            this.label_temp.TabIndex = 0;
            this.label_temp.Text = "这是主页";
            // 
            // 账户管理MToolStripMenuItem
            // 
            this.账户管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetPasswordMenuItem,
            this.ModifyNameMenuItem});
            this.账户管理MToolStripMenuItem.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.账户管理MToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.账户管理MToolStripMenuItem.Name = "账户管理MToolStripMenuItem";
            this.账户管理MToolStripMenuItem.Size = new System.Drawing.Size(99, 23);
            this.账户管理MToolStripMenuItem.Text = "账户管理";
            // 
            // SetPasswordMenuItem
            // 
            this.SetPasswordMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SetPasswordMenuItem.Name = "SetPasswordMenuItem";
            this.SetPasswordMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.SetPasswordMenuItem.ShowShortcutKeys = false;
            this.SetPasswordMenuItem.Size = new System.Drawing.Size(224, 26);
            this.SetPasswordMenuItem.Text = "修改密码(P)";
            this.SetPasswordMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SetPasswordMenuItem.Click += new System.EventHandler(this.SetPasswordMenuItem_Click);
            // 
            // ModifyNameMenuItem
            // 
            this.ModifyNameMenuItem.Name = "ModifyNameMenuItem";
            this.ModifyNameMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ModifyNameMenuItem.ShowShortcutKeys = false;
            this.ModifyNameMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ModifyNameMenuItem.Text = "修改用户名(N)";
            this.ModifyNameMenuItem.Visible = false;
            this.ModifyNameMenuItem.Click += new System.EventHandler(this.ModifyNameMenuItem_Click);
            // 
            // WarehouseMenuItem
            // 
            this.WarehouseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Warehouse_inMenuItem,
            this.Warehouse_outMenuItem,
            this.Warehouse_queryMenuItem});
            this.WarehouseMenuItem.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WarehouseMenuItem.Name = "WarehouseMenuItem";
            this.WarehouseMenuItem.Size = new System.Drawing.Size(80, 23);
            this.WarehouseMenuItem.Text = "仓库部";
            // 
            // Warehouse_inMenuItem
            // 
            this.Warehouse_inMenuItem.Name = "Warehouse_inMenuItem";
            this.Warehouse_inMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.Warehouse_inMenuItem.ShowShortcutKeys = false;
            this.Warehouse_inMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Warehouse_inMenuItem.Text = "入库管理(I)";
            this.Warehouse_inMenuItem.Click += new System.EventHandler(this.Warehouse_inMenuItem_Click);
            // 
            // Warehouse_outMenuItem
            // 
            this.Warehouse_outMenuItem.Name = "Warehouse_outMenuItem";
            this.Warehouse_outMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Warehouse_outMenuItem.ShowShortcutKeys = false;
            this.Warehouse_outMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Warehouse_outMenuItem.Text = "出库管理(O)";
            this.Warehouse_outMenuItem.Click += new System.EventHandler(this.Warehouse_outMenuItem_Click);
            // 
            // Warehouse_queryMenuItem
            // 
            this.Warehouse_queryMenuItem.Name = "Warehouse_queryMenuItem";
            this.Warehouse_queryMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.Warehouse_queryMenuItem.ShowShortcutKeys = false;
            this.Warehouse_queryMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Warehouse_queryMenuItem.Text = "仓库情况(W)";
            this.Warehouse_queryMenuItem.Click += new System.EventHandler(this.Warehouse_queryMenuItem_Click);
            // 
            // SaleMenuItem
            // 
            this.SaleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Customer_managementMenuItem,
            this.Sales_recordMenuItem,
            this.查看库存ToolStripMenuItem,
            this.Personal_performanceMenuItem});
            this.SaleMenuItem.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaleMenuItem.Name = "SaleMenuItem";
            this.SaleMenuItem.Size = new System.Drawing.Size(80, 23);
            this.SaleMenuItem.Text = "销售部";
            // 
            // Customer_managementMenuItem
            // 
            this.Customer_managementMenuItem.Name = "Customer_managementMenuItem";
            this.Customer_managementMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Customer_managementMenuItem.ShowShortcutKeys = false;
            this.Customer_managementMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Customer_managementMenuItem.Text = "客户管理(C)";
            this.Customer_managementMenuItem.Click += new System.EventHandler(this.Customer_managementMenuItem_Click);
            // 
            // Sales_recordMenuItem
            // 
            this.Sales_recordMenuItem.Name = "Sales_recordMenuItem";
            this.Sales_recordMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Sales_recordMenuItem.ShowShortcutKeys = false;
            this.Sales_recordMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Sales_recordMenuItem.Text = "销售记录(S)";
            this.Sales_recordMenuItem.Click += new System.EventHandler(this.Sales_recordMenuItem_Click);
            // 
            // 查看库存ToolStripMenuItem
            // 
            this.查看库存ToolStripMenuItem.Name = "查看库存ToolStripMenuItem";
            this.查看库存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.查看库存ToolStripMenuItem.ShowShortcutKeys = false;
            this.查看库存ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查看库存ToolStripMenuItem.Text = "查看库存(A)";
            this.查看库存ToolStripMenuItem.Click += new System.EventHandler(this.查看库存ToolStripMenuItem_Click);
            // 
            // Personal_performanceMenuItem
            // 
            this.Personal_performanceMenuItem.Name = "Personal_performanceMenuItem";
            this.Personal_performanceMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Personal_performanceMenuItem.Text = "个人业绩";
            this.Personal_performanceMenuItem.Click += new System.EventHandler(this.Personal_performanceMenuItem_Click);
            // 
            // AftersaleMenuItem
            // 
            this.AftersaleMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MembersMenuItem,
            this.ServicerecordsMenuItem,
            this.ComplainMenuItem});
            this.AftersaleMenuItem.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AftersaleMenuItem.Name = "AftersaleMenuItem";
            this.AftersaleMenuItem.Size = new System.Drawing.Size(80, 23);
            this.AftersaleMenuItem.Text = "售后部";
            // 
            // MembersMenuItem
            // 
            this.MembersMenuItem.Name = "MembersMenuItem";
            this.MembersMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.MembersMenuItem.ShowShortcutKeys = false;
            this.MembersMenuItem.Size = new System.Drawing.Size(227, 26);
            this.MembersMenuItem.Text = "会员名单管理(M)";
            this.MembersMenuItem.Click += new System.EventHandler(this.MembersMenuItem_Click);
            // 
            // ServicerecordsMenuItem
            // 
            this.ServicerecordsMenuItem.Name = "ServicerecordsMenuItem";
            this.ServicerecordsMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ServicerecordsMenuItem.Text = "服务记录";
            this.ServicerecordsMenuItem.Click += new System.EventHandler(this.ServicerecordsMenuItem_Click);
            // 
            // ComplainMenuItem
            // 
            this.ComplainMenuItem.Name = "ComplainMenuItem";
            this.ComplainMenuItem.Size = new System.Drawing.Size(227, 26);
            this.ComplainMenuItem.Text = "投诉反馈";
            this.ComplainMenuItem.Click += new System.EventHandler(this.ComplainMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem,
            this.账户管理MToolStripMenuItem,
            this.WarehouseMenuItem,
            this.SaleMenuItem,
            this.AftersaleMenuItem,
            this.Department_managerMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1694, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExitMenuItem.Size = new System.Drawing.Size(91, 23);
            this.ExitMenuItem.Text = "退出(E)";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitpMenuItem_Click);
            // 
            // Department_managerMenuItem
            // 
            this.Department_managerMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Employee_managementMenuItem,
            this.Sales_statistic_analysisMenuItem});
            this.Department_managerMenuItem.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Department_managerMenuItem.Name = "Department_managerMenuItem";
            this.Department_managerMenuItem.Size = new System.Drawing.Size(99, 23);
            this.Department_managerMenuItem.Text = "部门主管";
            // 
            // Employee_managementMenuItem
            // 
            this.Employee_managementMenuItem.Name = "Employee_managementMenuItem";
            this.Employee_managementMenuItem.ShowShortcutKeys = false;
            this.Employee_managementMenuItem.Size = new System.Drawing.Size(237, 26);
            this.Employee_managementMenuItem.Text = "职工管理";
            this.Employee_managementMenuItem.Click += new System.EventHandler(this.Employee_managementMenuItem_Click);
            // 
            // Sales_statistic_analysisMenuItem
            // 
            this.Sales_statistic_analysisMenuItem.Name = "Sales_statistic_analysisMenuItem";
            this.Sales_statistic_analysisMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.Sales_statistic_analysisMenuItem.ShowShortcutKeys = false;
            this.Sales_statistic_analysisMenuItem.Size = new System.Drawing.Size(237, 26);
            this.Sales_statistic_analysisMenuItem.Text = "销售_统计分析(S)";
            this.Sales_statistic_analysisMenuItem.Click += new System.EventHandler(this.Sales_statistic_analysisMenuItem_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTime.Location = new System.Drawing.Point(1446, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 24);
            this.lblTime.TabIndex = 15;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("隶书", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 80);
            this.label1.TabIndex = 16;
            this.label1.Text = "轿车销售管理系统";
            // 
            // pictureBoxHead
            // 
            this.pictureBoxHead.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxHead.BackgroundImage")));
            this.pictureBoxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHead.Location = new System.Drawing.Point(12, 31);
            this.pictureBoxHead.Name = "pictureBoxHead";
            this.pictureBoxHead.Size = new System.Drawing.Size(41, 43);
            this.pictureBoxHead.TabIndex = 17;
            this.pictureBoxHead.TabStop = false;
            // 
            // pictureBoxCEO
            // 
            this.pictureBoxCEO.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCEO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCEO.BackgroundImage")));
            this.pictureBoxCEO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCEO.Location = new System.Drawing.Point(12, 31);
            this.pictureBoxCEO.Name = "pictureBoxCEO";
            this.pictureBoxCEO.Size = new System.Drawing.Size(41, 43);
            this.pictureBoxCEO.TabIndex = 18;
            this.pictureBoxCEO.TabStop = false;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmployee.BackgroundImage")));
            this.pictureBoxEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(12, 31);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(41, 43);
            this.pictureBoxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmployee.TabIndex = 19;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // pictureBoxDepartment_warehouse
            // 
            this.pictureBoxDepartment_warehouse.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDepartment_warehouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDepartment_warehouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxDepartment_warehouse.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDepartment_warehouse.Image")));
            this.pictureBoxDepartment_warehouse.Location = new System.Drawing.Point(250, 416);
            this.pictureBoxDepartment_warehouse.Name = "pictureBoxDepartment_warehouse";
            this.pictureBoxDepartment_warehouse.Size = new System.Drawing.Size(209, 246);
            this.pictureBoxDepartment_warehouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDepartment_warehouse.TabIndex = 20;
            this.pictureBoxDepartment_warehouse.TabStop = false;
            // 
            // pictureBoxDepartment_sale
            // 
            this.pictureBoxDepartment_sale.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDepartment_sale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDepartment_sale.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxDepartment_sale.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDepartment_sale.Image")));
            this.pictureBoxDepartment_sale.Location = new System.Drawing.Point(250, 416);
            this.pictureBoxDepartment_sale.Name = "pictureBoxDepartment_sale";
            this.pictureBoxDepartment_sale.Size = new System.Drawing.Size(209, 261);
            this.pictureBoxDepartment_sale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDepartment_sale.TabIndex = 21;
            this.pictureBoxDepartment_sale.TabStop = false;
            // 
            // pictureBoxDepartment_CEO
            // 
            this.pictureBoxDepartment_CEO.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDepartment_CEO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDepartment_CEO.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxDepartment_CEO.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDepartment_CEO.Image")));
            this.pictureBoxDepartment_CEO.Location = new System.Drawing.Point(250, 416);
            this.pictureBoxDepartment_CEO.Name = "pictureBoxDepartment_CEO";
            this.pictureBoxDepartment_CEO.Size = new System.Drawing.Size(209, 261);
            this.pictureBoxDepartment_CEO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDepartment_CEO.TabIndex = 22;
            this.pictureBoxDepartment_CEO.TabStop = false;
            // 
            // pictureBoxDepartment_aftersale
            // 
            this.pictureBoxDepartment_aftersale.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDepartment_aftersale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDepartment_aftersale.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxDepartment_aftersale.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDepartment_aftersale.Image")));
            this.pictureBoxDepartment_aftersale.Location = new System.Drawing.Point(214, 395);
            this.pictureBoxDepartment_aftersale.Name = "pictureBoxDepartment_aftersale";
            this.pictureBoxDepartment_aftersale.Size = new System.Drawing.Size(312, 305);
            this.pictureBoxDepartment_aftersale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDepartment_aftersale.TabIndex = 23;
            this.pictureBoxDepartment_aftersale.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApp_myDBAS.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1694, 768);
            this.Controls.Add(this.pictureBoxDepartment_aftersale);
            this.Controls.Add(this.pictureBoxDepartment_CEO);
            this.Controls.Add(this.pictureBoxDepartment_sale);
            this.Controls.Add(this.pictureBoxDepartment_warehouse);
            this.Controls.Add(this.pictureBoxEmployee);
            this.Controls.Add(this.pictureBoxCEO);
            this.Controls.Add(this.pictureBoxHead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homepage";
            this.Text = "主页";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homepage_FormClosed);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment_warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment_sale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment_CEO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment_aftersale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.ToolStripMenuItem 账户管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetPasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WarehouseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaleMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AftersaleMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem Warehouse_inMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Warehouse_outMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Warehouse_queryMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem Customer_managementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sales_recordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Personal_performanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MembersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServicerecordsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComplainMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxHead;
        private System.Windows.Forms.PictureBox pictureBoxCEO;
        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.PictureBox pictureBoxDepartment_warehouse;
        private System.Windows.Forms.PictureBox pictureBoxDepartment_sale;
        private System.Windows.Forms.PictureBox pictureBoxDepartment_CEO;
        private System.Windows.Forms.PictureBox pictureBoxDepartment_aftersale;
        private System.Windows.Forms.ToolStripMenuItem Department_managerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Employee_managementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sales_statistic_analysisMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看库存ToolStripMenuItem;
    }
}