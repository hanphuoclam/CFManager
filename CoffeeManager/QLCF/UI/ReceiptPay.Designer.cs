namespace QLCF.UI
{
    partial class ReceiptPayForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListProductReceipt = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductReceipt)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dgvListProductReceipt);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 239);
            this.panel1.TabIndex = 7;
            // 
            // dgvListProductReceipt
            // 
            this.dgvListProductReceipt.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProductReceipt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListProductReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProductReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColName,
            this.ColPrice,
            this.ColCount,
            this.ColSave,
            this.ColDelete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListProductReceipt.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListProductReceipt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListProductReceipt.Location = new System.Drawing.Point(0, 6);
            this.dgvListProductReceipt.Name = "dgvListProductReceipt";
            this.dgvListProductReceipt.RowHeadersVisible = false;
            this.dgvListProductReceipt.Size = new System.Drawing.Size(576, 233);
            this.dgvListProductReceipt.TabIndex = 0;
            this.dgvListProductReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProductReceipt_CellClick);
            this.dgvListProductReceipt.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListProductReceipt_EditingControlShowing);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "ID";
            this.ColId.Name = "ColId";
            this.ColId.Width = 30;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Tên sản phẩm";
            this.ColName.Name = "ColName";
            this.ColName.Width = 210;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Đơn giá";
            this.ColPrice.Name = "ColPrice";
            // 
            // ColCount
            // 
            this.ColCount.HeaderText = "SL Mua";
            this.ColCount.Name = "ColCount";
            this.ColCount.Width = 60;
            // 
            // ColSave
            // 
            this.ColSave.FillWeight = 80F;
            this.ColSave.HeaderText = "Chỉnh sửa";
            this.ColSave.Name = "ColSave";
            this.ColSave.Text = "Sửa";
            this.ColSave.UseColumnTextForButtonValue = true;
            // 
            // ColDelete
            // 
            this.ColDelete.HeaderText = "Xóa";
            this.ColDelete.Name = "ColDelete";
            this.ColDelete.Text = "Xóa";
            this.ColDelete.UseColumnTextForButtonValue = true;
            this.ColDelete.Width = 80;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.nhậpHàngToolStripMenuItem.Text = "File";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(14, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng tiền:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtTotalPrice.Location = new System.Drawing.Point(151, 281);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(223, 35);
            this.txtTotalPrice.TabIndex = 9;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Black;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(409, 278);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(149, 39);
            this.btnBuy.TabIndex = 8;
            this.btnBuy.Text = "Thanh toán";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // ReceiptPayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources._616x364;
            this.ClientSize = new System.Drawing.Size(600, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btnBuy);
            this.MaximizeBox = false;
            this.Name = "ReceiptPayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Các nhận nhập hàng";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductReceipt)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.DataGridView dgvListProductReceipt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCount;
        private System.Windows.Forms.DataGridViewButtonColumn ColSave;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
    }
}