namespace QLCF.UI
{
    partial class HandlingMoreForm
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
            this.dgvProductChanged = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbListTable = new System.Windows.Forms.ComboBox();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNameTable = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dgvListProChoosed = new System.Windows.Forms.DataGridView();
            this.colIdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPricePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductChanged)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProChoosed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductChanged
            // 
            this.dgvProductChanged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductChanged.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdProduct,
            this.colNameProduct,
            this.colCount,
            this.colPrice,
            this.colChecked});
            this.dgvProductChanged.Location = new System.Drawing.Point(12, 63);
            this.dgvProductChanged.Name = "dgvProductChanged";
            this.dgvProductChanged.Size = new System.Drawing.Size(416, 390);
            this.dgvProductChanged.TabIndex = 0;
            this.dgvProductChanged.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductChanged_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // cmbListTable
            // 
            this.cmbListTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbListTable.FormattingEnabled = true;
            this.cmbListTable.Location = new System.Drawing.Point(3, 3);
            this.cmbListTable.Name = "cmbListTable";
            this.cmbListTable.Size = new System.Drawing.Size(194, 32);
            this.cmbListTable.TabIndex = 2;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChangeTable.Location = new System.Drawing.Point(51, 41);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(146, 36);
            this.btnChangeTable.TabIndex = 3;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbListTable);
            this.panel1.Controls.Add(this.btnChangeTable);
            this.panel1.Location = new System.Drawing.Point(434, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 82);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblNameTable);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 31);
            this.panel2.TabIndex = 6;
            // 
            // lblNameTable
            // 
            this.lblNameTable.AutoSize = true;
            this.lblNameTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNameTable.Location = new System.Drawing.Point(243, 0);
            this.lblNameTable.Name = "lblNameTable";
            this.lblNameTable.Size = new System.Drawing.Size(276, 24);
            this.lblNameTable.TabIndex = 0;
            this.lblNameTable.Text = "Bạn đang thao tác trên bàn số : ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(656, 374);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 79);
            this.panel3.TabIndex = 6;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.Location = new System.Drawing.Point(3, 3);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(206, 29);
            this.txtTotalPrice.TabIndex = 4;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOut.Location = new System.Drawing.Point(69, 38);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(140, 35);
            this.btnCheckOut.TabIndex = 3;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // dgvListProChoosed
            // 
            this.dgvListProChoosed.AllowUserToAddRows = false;
            this.dgvListProChoosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProChoosed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNamePro,
            this.colPricePro,
            this.colCountPro,
            this.colEdit});
            this.dgvListProChoosed.Location = new System.Drawing.Point(434, 64);
            this.dgvListProChoosed.Name = "dgvListProChoosed";
            this.dgvListProChoosed.Size = new System.Drawing.Size(431, 302);
            this.dgvListProChoosed.TabIndex = 7;
            this.dgvListProChoosed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProChoosed_CellClick);
            this.dgvListProChoosed.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListProChoosed_EditingControlShowing);
            // 
            // colIdProduct
            // 
            this.colIdProduct.HeaderText = "Mã BillInfo";
            this.colIdProduct.Name = "colIdProduct";
            this.colIdProduct.ReadOnly = true;
            // 
            // colNameProduct
            // 
            this.colNameProduct.HeaderText = "Tên Sản Phẩm";
            this.colNameProduct.Name = "colNameProduct";
            this.colNameProduct.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "SL";
            this.colCount.Name = "colCount";
            this.colCount.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colChecked
            // 
            this.colChecked.HeaderText = "Chọn";
            this.colChecked.Name = "colChecked";
            // 
            // colID
            // 
            this.colID.HeaderText = "Mã BillInfo";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNamePro
            // 
            this.colNamePro.HeaderText = "Tên Sản Phẩm";
            this.colNamePro.Name = "colNamePro";
            this.colNamePro.ReadOnly = true;
            // 
            // colPricePro
            // 
            this.colPricePro.HeaderText = "Đơn giá";
            this.colPricePro.Name = "colPricePro";
            this.colPricePro.ReadOnly = true;
            // 
            // colCountPro
            // 
            this.colCountPro.HeaderText = "SL";
            this.colCountPro.Name = "colCountPro";
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Chỉnh sửa";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Lưu Chỉnh Sửa";
            // 
            // HandlingMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.dgvListProChoosed);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProductChanged);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HandlingMoreForm";
            this.Text = "Chuyển bàn - Thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductChanged)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProChoosed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductChanged;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbListTable;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNameTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DataGridView dgvListProChoosed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colChecked;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPricePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountPro;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
    }
}