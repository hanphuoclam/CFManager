namespace QLCF.UI
{
    partial class BillForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListBill = new System.Windows.Forms.DataGridView();
            this.ColDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewList = new System.Windows.Forms.Button();
            this.dpkDateTo = new System.Windows.Forms.DateTimePicker();
            this.dpkDateFrom = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.btnTotalRevenue = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.hóaĐơnToolStripMenuItem.Text = "File";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListBill);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 547);
            this.panel1.TabIndex = 7;
            // 
            // dgvListBill
            // 
            this.dgvListBill.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDetail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListBill.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListBill.Location = new System.Drawing.Point(3, 3);
            this.dgvListBill.Name = "dgvListBill";
            this.dgvListBill.RowHeadersVisible = false;
            this.dgvListBill.Size = new System.Drawing.Size(548, 541);
            this.dgvListBill.TabIndex = 0;
            this.dgvListBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListBill_CellClick);
            // 
            // ColDetail
            // 
            this.ColDetail.HeaderText = "Chi tiết";
            this.ColDetail.Name = "ColDetail";
            this.ColDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColDetail.Text = "Chi tiết";
            this.ColDetail.ToolTipText = "Chi tiết";
            this.ColDetail.UseColumnTextForButtonValue = true;
            this.ColDetail.Width = 70;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnViewList);
            this.panel2.Controls.Add(this.dpkDateTo);
            this.panel2.Controls.Add(this.dpkDateFrom);
            this.panel2.Location = new System.Drawing.Point(12, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 53);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(306, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đến";
            // 
            // btnViewList
            // 
            this.btnViewList.BackColor = System.Drawing.Color.Black;
            this.btnViewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnViewList.ForeColor = System.Drawing.Color.White;
            this.btnViewList.Image = global::QLCF.Properties.Resources.viewlist1;
            this.btnViewList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewList.Location = new System.Drawing.Point(676, 8);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(162, 38);
            this.btnViewList.TabIndex = 2;
            this.btnViewList.Text = "Thống kê";
            this.btnViewList.UseVisualStyleBackColor = false;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // dpkDateTo
            // 
            this.dpkDateTo.CustomFormat = "dd/MM/yyyy";
            this.dpkDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dpkDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkDateTo.Location = new System.Drawing.Point(371, 11);
            this.dpkDateTo.Name = "dpkDateTo";
            this.dpkDateTo.Size = new System.Drawing.Size(287, 30);
            this.dpkDateTo.TabIndex = 1;
            // 
            // dpkDateFrom
            // 
            this.dpkDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dpkDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dpkDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkDateFrom.Location = new System.Drawing.Point(13, 11);
            this.dpkDateFrom.Name = "dpkDateFrom";
            this.dpkDateFrom.Size = new System.Drawing.Size(287, 30);
            this.dpkDateFrom.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtTotalRevenue);
            this.panel3.Controls.Add(this.btnTotalRevenue);
            this.panel3.Location = new System.Drawing.Point(572, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 547);
            this.panel3.TabIndex = 13;
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtTotalRevenue.Location = new System.Drawing.Point(23, 35);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Size = new System.Drawing.Size(261, 35);
            this.txtTotalRevenue.TabIndex = 5;
            // 
            // btnTotalRevenue
            // 
            this.btnTotalRevenue.BackColor = System.Drawing.Color.Black;
            this.btnTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.btnTotalRevenue.Image = global::QLCF.Properties.Resources.viewlist1;
            this.btnTotalRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotalRevenue.Location = new System.Drawing.Point(68, 97);
            this.btnTotalRevenue.Name = "btnTotalRevenue";
            this.btnTotalRevenue.Size = new System.Drawing.Size(216, 38);
            this.btnTotalRevenue.TabIndex = 4;
            this.btnTotalRevenue.Text = "Tính doanh thu";
            this.btnTotalRevenue.UseVisualStyleBackColor = false;
            this.btnTotalRevenue.Click += new System.EventHandler(this.btnTotalRevenue_Click);
            // 
            // BillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources._880x670;
            this.ClientSize = new System.Drawing.Size(884, 642);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.DateTimePicker dpkDateTo;
        private System.Windows.Forms.DateTimePicker dpkDateFrom;
        private System.Windows.Forms.DataGridViewButtonColumn ColDetail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.Button btnTotalRevenue;
    }
}