
namespace WindowsFormsApp_myDBAS
{
    partial class Warehouse_query
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warehouse_query));
            this.panelResult = new System.Windows.Forms.Panel();
            this.dataGridViewcar_info = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCar_num = new System.Windows.Forms.TextBox();
            this.txtCar_name = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcar_info)).BeginInit();
            this.groupBoxCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.Transparent;
            this.panelResult.Controls.Add(this.dataGridViewcar_info);
            this.panelResult.Controls.Add(this.label1);
            this.panelResult.Location = new System.Drawing.Point(183, 262);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(1177, 418);
            this.panelResult.TabIndex = 10;
            // 
            // dataGridViewcar_info
            // 
            this.dataGridViewcar_info.AllowUserToAddRows = false;
            this.dataGridViewcar_info.AllowUserToResizeColumns = false;
            this.dataGridViewcar_info.AllowUserToResizeRows = false;
            this.dataGridViewcar_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewcar_info.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewcar_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcar_info.Location = new System.Drawing.Point(20, 94);
            this.dataGridViewcar_info.Name = "dataGridViewcar_info";
            this.dataGridViewcar_info.RowHeadersVisible = false;
            this.dataGridViewcar_info.RowHeadersWidth = 51;
            this.dataGridViewcar_info.RowTemplate.Height = 27;
            this.dataGridViewcar_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewcar_info.Size = new System.Drawing.Size(1007, 307);
            this.dataGridViewcar_info.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "查询结果为：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(62, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "轿车编号 ：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(62, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "轿车名字  ：";
            // 
            // txtCar_num
            // 
            this.txtCar_num.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCar_num.Location = new System.Drawing.Point(218, 78);
            this.txtCar_num.Name = "txtCar_num";
            this.txtCar_num.Size = new System.Drawing.Size(148, 34);
            this.txtCar_num.TabIndex = 14;
            // 
            // txtCar_name
            // 
            this.txtCar_name.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCar_name.Location = new System.Drawing.Point(220, 148);
            this.txtCar_name.Name = "txtCar_name";
            this.txtCar_name.Size = new System.Drawing.Size(146, 34);
            this.txtCar_name.TabIndex = 15;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.Location = new System.Drawing.Point(434, 98);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(84, 74);
            this.btnQuery.TabIndex = 16;
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxCondition.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxCondition.Controls.Add(this.txtCar_num);
            this.groupBoxCondition.Controls.Add(this.btnQuery);
            this.groupBoxCondition.Controls.Add(this.label2);
            this.groupBoxCondition.Controls.Add(this.txtCar_name);
            this.groupBoxCondition.Controls.Add(this.label4);
            this.groupBoxCondition.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBoxCondition.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxCondition.Location = new System.Drawing.Point(183, 48);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(637, 208);
            this.groupBoxCondition.TabIndex = 17;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "任填一项便可检索，为空则查看所有";
            // 
            // Warehouse_query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_myDBAS.Properties.Resources.tt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1694, 768);
            this.Controls.Add(this.groupBoxCondition);
            this.Controls.Add(this.panelResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Warehouse_query";
            this.Text = "仓库情况";
            this.Load += new System.EventHandler(this.Warehouse_query_Load);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcar_info)).EndInit();
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCar_num;
        private System.Windows.Forms.TextBox txtCar_name;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.DataGridView dataGridViewcar_info;
    }
}