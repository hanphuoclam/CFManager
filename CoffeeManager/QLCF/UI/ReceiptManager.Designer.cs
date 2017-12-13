namespace QLCF.UI
{
    partial class ReceiptManagerForm
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
            this.dgvListReceipt = new System.Windows.Forms.DataGridView();
            this.ColDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewList = new System.Windows.Forms.Button();
            this.dpkDateTo = new System.Windows.Forms.DateTimePicker();
            this.dpkDateFrom = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.btnTotalMoney = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReceipt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListReceipt
            // 
            this.dgvListReceipt.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDetail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListReceipt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListReceipt.Location = new System.Drawing.Point(3, 3);
            this.dgvListReceipt.Name = "dgvListReceipt";
            this.dgvListReceipt.RowHeadersVisible = false;
            this.dgvListReceipt.Size = new System.Drawing.Size(548, 541);
            this.dgvListReceipt.TabIndex = 0;
            this.dgvListReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListReceipt_CellClick);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 9;
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
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListReceipt);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 547);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnViewList);
            this.panel2.Controls.Add(this.dpkDateTo);
            this.panel2.Controls.Add(this.dpkDateFrom);
            this.panel2.Location = new System.Drawing.Point(12, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 53);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(332, 13);
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
            this.btnViewList.Size = new System.Drawing.Size(168, 38);
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
            this.dpkDateTo.Location = new System.Drawing.Point(395, 11);
            this.dpkDateTo.Name = "dpkDateTo";
            this.dpkDateTo.Size = new System.Drawing.Size(263, 30);
            this.dpkDateTo.TabIndex = 1;
            // 
            // dpkDateFrom
            // 
            this.dpkDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dpkDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dpkDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkDateFrom.Location = new System.Drawing.Point(69, 11);
            this.dpkDateFrom.Name = "dpkDateFrom";
            this.dpkDateFrom.Size = new System.Drawing.Size(257, 30);
            this.dpkDateFrom.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.txtTotalMoney);
            this.panel3.Controls.Add(this.btnTotalMoney);
            this.panel3.Location = new System.Drawing.Point(572, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 547);
            this.panel3.TabIndex = 12;
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtTotalMoney.Location = new System.Drawing.Point(23, 35);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(261, 35);
            this.txtTotalMoney.TabIndex = 5;
            // 
            // btnTotalMoney
            // 
            this.btnTotalMoney.BackColor = System.Drawing.Color.Black;
            this.btnTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTotalMoney.ForeColor = System.Drawing.Color.White;
            this.btnTotalMoney.Image = global::QLCF.Properties.Resources.viewlist1;
            this.btnTotalMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotalMoney.Location = new System.Drawing.Point(68, 97);
            this.btnTotalMoney.Name = "btnTotalMoney";
            this.btnTotalMoney.Size = new System.Drawing.Size(216, 38);
            this.btnTotalMoney.TabIndex = 4;
            this.btnTotalMoney.Text = "Tính tổng vốn";
            this.btnTotalMoney.UseVisualStyleBackColor = false;
            // 
            // ReceiptManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources._880x670;
            this.ClientSize = new System.Drawing.Size(884, 642);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "ReceiptManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê hóa đơn nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListReceipt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListReceipt;
        private System.Windows.Forms.DataGridViewButtonColumn ColDetail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.DateTimePicker dpkDateTo;
        private System.Windows.Forms.DateTimePicker dpkDateFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Button btnTotalMoney;
        private System.Windows.Forms.Label label2;
    }
}