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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductChanged = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.dgvListProChoosed = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.cmbListTable = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostsIncurred = new System.Windows.Forms.TextBox();
            this.btnCheckOutManyTable = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtSumTotalPrice = new System.Windows.Forms.TextBox();
            this.colIdBillInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProChoosed)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductChanged
            // 
            this.dgvProductChanged.AllowUserToAddRows = false;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductChanged.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProductChanged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductChanged.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdBillInfo,
            this.colName,
            this.colCount,
            this.colPrice,
            this.colChecked});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductChanged.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProductChanged.Location = new System.Drawing.Point(12, 81);
            this.dgvProductChanged.Name = "dgvProductChanged";
            this.dgvProductChanged.RowHeadersVisible = false;
            this.dgvProductChanged.Size = new System.Drawing.Size(513, 510);
            this.dgvProductChanged.TabIndex = 0;
            this.dgvProductChanged.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductChanged_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblHelloWorld);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 48);
            this.panel1.TabIndex = 2;
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHelloWorld.ForeColor = System.Drawing.Color.White;
            this.lblHelloWorld.Location = new System.Drawing.Point(406, 11);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(60, 24);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "label6";
            // 
            // dgvListProChoosed
            // 
            this.dgvListProChoosed.AllowUserToAddRows = false;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProChoosed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvListProChoosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProChoosed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNamePro,
            this.colPricePro,
            this.colCountPro,
            this.colEdit});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListProChoosed.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvListProChoosed.Location = new System.Drawing.Point(531, 81);
            this.dgvListProChoosed.Name = "dgvListProChoosed";
            this.dgvListProChoosed.RowHeadersVisible = false;
            this.dgvListProChoosed.Size = new System.Drawing.Size(691, 327);
            this.dgvListProChoosed.TabIndex = 3;
            this.dgvListProChoosed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProChoosed_CellClick);
            this.dgvListProChoosed.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListProChoosed_EditingControlShowing);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnChangeTable);
            this.panel2.Controls.Add(this.cmbListTable);
            this.panel2.Location = new System.Drawing.Point(531, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 177);
            this.panel2.TabIndex = 4;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChangeTable.Location = new System.Drawing.Point(92, 97);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(117, 33);
            this.btnChangeTable.TabIndex = 1;
            this.btnChangeTable.Text = "Tách bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // cmbListTable
            // 
            this.cmbListTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbListTable.FormattingEnabled = true;
            this.cmbListTable.Location = new System.Drawing.Point(20, 17);
            this.cmbListTable.Name = "cmbListTable";
            this.cmbListTable.Size = new System.Drawing.Size(204, 33);
            this.cmbListTable.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbDiscount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtCostsIncurred);
            this.panel3.Controls.Add(this.btnCheckOutManyTable);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.txtSumTotalPrice);
            this.panel3.Location = new System.Drawing.Point(773, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 177);
            this.panel3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(113, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 24);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(22, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chú thích :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(19, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tạm tính :";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.Location = new System.Drawing.Point(113, 43);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(333, 24);
            this.txtTotalPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(264, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giảm :";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "0",
            "10",
            "20"});
            this.cmbDiscount.Location = new System.Drawing.Point(325, 78);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(121, 24);
            this.cmbDiscount.TabIndex = 7;
            this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbDiscount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(19, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tổng tiền :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chi phí phụ";
            // 
            // txtCostsIncurred
            // 
            this.txtCostsIncurred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCostsIncurred.Location = new System.Drawing.Point(113, 78);
            this.txtCostsIncurred.Name = "txtCostsIncurred";
            this.txtCostsIncurred.Size = new System.Drawing.Size(135, 22);
            this.txtCostsIncurred.TabIndex = 4;
            this.txtCostsIncurred.TextChanged += new System.EventHandler(this.txtCostsIncurred_TextChanged);
            this.txtCostsIncurred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostsIncurred_KeyPress);
            // 
            // btnCheckOutManyTable
            // 
            this.btnCheckOutManyTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOutManyTable.Location = new System.Drawing.Point(264, 138);
            this.btnCheckOutManyTable.Name = "btnCheckOutManyTable";
            this.btnCheckOutManyTable.Size = new System.Drawing.Size(175, 37);
            this.btnCheckOutManyTable.TabIndex = 3;
            this.btnCheckOutManyTable.Text = "Thanh toán nhiều bàn";
            this.btnCheckOutManyTable.UseVisualStyleBackColor = true;
            this.btnCheckOutManyTable.Click += new System.EventHandler(this.btnCheckOutManyTable_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOut.Location = new System.Drawing.Point(141, 138);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(117, 37);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Thanh toán";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtSumTotalPrice
            // 
            this.txtSumTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSumTotalPrice.Location = new System.Drawing.Point(113, 108);
            this.txtSumTotalPrice.Name = "txtSumTotalPrice";
            this.txtSumTotalPrice.Size = new System.Drawing.Size(333, 26);
            this.txtSumTotalPrice.TabIndex = 0;
            // 
            // colIdBillInfo
            // 
            this.colIdBillInfo.HeaderText = "ID";
            this.colIdBillInfo.Name = "colIdBillInfo";
            this.colIdBillInfo.Width = 50;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên sản phẩm";
            this.colName.Name = "colName";
            this.colName.Width = 200;
            // 
            // colCount
            // 
            this.colCount.HeaderText = "SL";
            this.colCount.Name = "colCount";
            this.colCount.Width = 40;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Đơn giá";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 160;
            // 
            // colChecked
            // 
            this.colChecked.HeaderText = "Chọn";
            this.colChecked.Name = "colChecked";
            this.colChecked.Width = 60;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 50;
            // 
            // colNamePro
            // 
            this.colNamePro.HeaderText = "Tên sản phẩm";
            this.colNamePro.Name = "colNamePro";
            this.colNamePro.ReadOnly = true;
            this.colNamePro.Width = 230;
            // 
            // colPricePro
            // 
            this.colPricePro.HeaderText = "Đơn giá";
            this.colPricePro.Name = "colPricePro";
            this.colPricePro.ReadOnly = true;
            this.colPricePro.Width = 190;
            // 
            // colCountPro
            // 
            this.colCountPro.HeaderText = "SL";
            this.colCountPro.Name = "colCountPro";
            this.colCountPro.Width = 50;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Lưu chỉnh sửa";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Lưu chỉnh sửa";
            this.colEdit.Width = 150;
            // 
            // HandlingMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources.backgroundCFMresized1;
            this.ClientSize = new System.Drawing.Size(1234, 603);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvListProChoosed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProductChanged);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HandlingMoreForm";
            this.Text = "HandlingMore";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductChanged)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProChoosed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductChanged;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvListProChoosed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnChangeTable;
        private System.Windows.Forms.ComboBox cmbListTable;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtSumTotalPrice;
        private System.Windows.Forms.Button btnCheckOutManyTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostsIncurred;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdBillInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
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