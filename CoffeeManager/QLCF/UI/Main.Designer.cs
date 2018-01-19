namespace QLCF
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nmdCount = new System.Windows.Forms.NumericUpDown();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.cmbCategoryProduct = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbTableFood = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTable_4 = new System.Windows.Forms.Button();
            this.btnTable_2 = new System.Windows.Forms.Button();
            this.btnTable_1 = new System.Windows.Forms.Button();
            this.btnTable_5 = new System.Windows.Forms.Button();
            this.btnTable_9 = new System.Windows.Forms.Button();
            this.btnTable_10 = new System.Windows.Forms.Button();
            this.btnTable_7 = new System.Windows.Forms.Button();
            this.btnTable_6 = new System.Windows.Forms.Button();
            this.btnTable_3 = new System.Windows.Forms.Button();
            this.btnTable_8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmdCount)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nmdCount
            // 
            this.nmdCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nmdCount.Location = new System.Drawing.Point(277, 48);
            this.nmdCount.Name = "nmdCount";
            this.nmdCount.Size = new System.Drawing.Size(47, 40);
            this.nmdCount.TabIndex = 3;
            this.nmdCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(3, 86);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(268, 37);
            this.cmbProduct.TabIndex = 2;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Black;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::QLCF.Properties.Resources.add;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProduct.Location = new System.Drawing.Point(330, 13);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(106, 110);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Thêm Món";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SL";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 180;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.Color.Black;
            this.btnSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.White;
            this.btnSwitchTable.Image = global::QLCF.Properties.Resources.swap;
            this.btnSwitchTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitchTable.Location = new System.Drawing.Point(0, 86);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(218, 49);
            this.btnSwitchTable.TabIndex = 8;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(269, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giảm giá :";
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "75",
            "70",
            "65",
            "60",
            "55",
            "50",
            "45",
            "40",
            "35",
            "30",
            "25",
            "20",
            "15",
            "10",
            "5",
            "0"});
            this.cmbDiscount.Location = new System.Drawing.Point(128, 3);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDiscount.Size = new System.Drawing.Size(140, 33);
            this.cmbDiscount.TabIndex = 5;
            this.cmbDiscount.Text = "0";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Black;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = global::QLCF.Properties.Resources.S;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckOut.Location = new System.Drawing.Point(313, 3);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(120, 132);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtTotalPrice.Location = new System.Drawing.Point(82, 42);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(222, 38);
            this.txtTotalPrice.TabIndex = 3;
            // 
            // cmbCategoryProduct
            // 
            this.cmbCategoryProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbCategoryProduct.FormattingEnabled = true;
            this.cmbCategoryProduct.Location = new System.Drawing.Point(3, 26);
            this.cmbCategoryProduct.Name = "cmbCategoryProduct";
            this.cmbCategoryProduct.Size = new System.Drawing.Size(268, 37);
            this.cmbCategoryProduct.TabIndex = 1;
            this.cmbCategoryProduct.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryProduct_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbTableFood);
            this.panel4.Controls.Add(this.btnSwitchTable);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cmbDiscount);
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtTotalPrice);
            this.panel4.Location = new System.Drawing.Point(6, 537);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 138);
            this.panel4.TabIndex = 5;
            // 
            // cmbTableFood
            // 
            this.cmbTableFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cmbTableFood.FormattingEnabled = true;
            this.cmbTableFood.Location = new System.Drawing.Point(224, 96);
            this.cmbTableFood.Name = "cmbTableFood";
            this.cmbTableFood.Size = new System.Drawing.Size(80, 33);
            this.cmbTableFood.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click_1);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Đổi mật khẩu";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnTable_4);
            this.panel1.Controls.Add(this.btnTable_2);
            this.panel1.Controls.Add(this.btnTable_1);
            this.panel1.Controls.Add(this.btnTable_5);
            this.panel1.Controls.Add(this.btnTable_9);
            this.panel1.Controls.Add(this.btnTable_10);
            this.panel1.Controls.Add(this.btnTable_7);
            this.panel1.Controls.Add(this.btnTable_6);
            this.panel1.Controls.Add(this.btnTable_3);
            this.panel1.Controls.Add(this.btnTable_8);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 670);
            this.panel1.TabIndex = 4;
            // 
            // btnTable_4
            // 
            this.btnTable_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_4.BackgroundImage")));
            this.btnTable_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_4.ForeColor = System.Drawing.Color.White;
            this.btnTable_4.Location = new System.Drawing.Point(423, 402);
            this.btnTable_4.Name = "btnTable_4";
            this.btnTable_4.Size = new System.Drawing.Size(310, 102);
            this.btnTable_4.TabIndex = 14;
            this.btnTable_4.Text = "Bàn số 4";
            this.btnTable_4.UseVisualStyleBackColor = true;
            // 
            // btnTable_2
            // 
            this.btnTable_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_2.BackgroundImage")));
            this.btnTable_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_2.ForeColor = System.Drawing.Color.White;
            this.btnTable_2.Location = new System.Drawing.Point(423, 537);
            this.btnTable_2.Name = "btnTable_2";
            this.btnTable_2.Size = new System.Drawing.Size(310, 102);
            this.btnTable_2.TabIndex = 13;
            this.btnTable_2.Text = "Bàn số 2";
            this.btnTable_2.UseVisualStyleBackColor = true;
            // 
            // btnTable_1
            // 
            this.btnTable_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_1.BackgroundImage")));
            this.btnTable_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_1.ForeColor = System.Drawing.Color.White;
            this.btnTable_1.Location = new System.Drawing.Point(46, 537);
            this.btnTable_1.Name = "btnTable_1";
            this.btnTable_1.Size = new System.Drawing.Size(310, 102);
            this.btnTable_1.TabIndex = 12;
            this.btnTable_1.Text = "Bàn số 1";
            this.btnTable_1.UseVisualStyleBackColor = true;
            // 
            // btnTable_5
            // 
            this.btnTable_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_5.BackgroundImage")));
            this.btnTable_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_5.ForeColor = System.Drawing.Color.White;
            this.btnTable_5.Location = new System.Drawing.Point(46, 219);
            this.btnTable_5.Name = "btnTable_5";
            this.btnTable_5.Size = new System.Drawing.Size(150, 138);
            this.btnTable_5.TabIndex = 11;
            this.btnTable_5.Text = "Bàn số 5";
            this.btnTable_5.UseVisualStyleBackColor = true;
            // 
            // btnTable_9
            // 
            this.btnTable_9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_9.BackgroundImage")));
            this.btnTable_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_9.ForeColor = System.Drawing.Color.White;
            this.btnTable_9.Location = new System.Drawing.Point(323, 41);
            this.btnTable_9.Name = "btnTable_9";
            this.btnTable_9.Size = new System.Drawing.Size(150, 138);
            this.btnTable_9.TabIndex = 10;
            this.btnTable_9.Text = "Bàn số 9";
            this.btnTable_9.UseVisualStyleBackColor = true;
            // 
            // btnTable_10
            // 
            this.btnTable_10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_10.BackgroundImage")));
            this.btnTable_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_10.ForeColor = System.Drawing.Color.White;
            this.btnTable_10.Location = new System.Drawing.Point(583, 41);
            this.btnTable_10.Name = "btnTable_10";
            this.btnTable_10.Size = new System.Drawing.Size(150, 138);
            this.btnTable_10.TabIndex = 9;
            this.btnTable_10.Text = "Bàn số 10";
            this.btnTable_10.UseVisualStyleBackColor = true;
            // 
            // btnTable_7
            // 
            this.btnTable_7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_7.BackgroundImage")));
            this.btnTable_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_7.ForeColor = System.Drawing.Color.White;
            this.btnTable_7.Location = new System.Drawing.Point(583, 219);
            this.btnTable_7.Name = "btnTable_7";
            this.btnTable_7.Size = new System.Drawing.Size(150, 138);
            this.btnTable_7.TabIndex = 8;
            this.btnTable_7.Text = "Bàn số 7";
            this.btnTable_7.UseVisualStyleBackColor = true;
            // 
            // btnTable_6
            // 
            this.btnTable_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_6.BackgroundImage")));
            this.btnTable_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_6.ForeColor = System.Drawing.Color.White;
            this.btnTable_6.Location = new System.Drawing.Point(323, 219);
            this.btnTable_6.Name = "btnTable_6";
            this.btnTable_6.Size = new System.Drawing.Size(150, 138);
            this.btnTable_6.TabIndex = 7;
            this.btnTable_6.Text = "Bàn số 6";
            this.btnTable_6.UseVisualStyleBackColor = true;
            // 
            // btnTable_3
            // 
            this.btnTable_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_3.BackgroundImage")));
            this.btnTable_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_3.ForeColor = System.Drawing.Color.White;
            this.btnTable_3.Location = new System.Drawing.Point(46, 402);
            this.btnTable_3.Name = "btnTable_3";
            this.btnTable_3.Size = new System.Drawing.Size(310, 102);
            this.btnTable_3.TabIndex = 6;
            this.btnTable_3.Text = "Bàn số 3";
            this.btnTable_3.UseVisualStyleBackColor = true;
            // 
            // btnTable_8
            // 
            this.btnTable_8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTable_8.BackgroundImage")));
            this.btnTable_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnTable_8.ForeColor = System.Drawing.Color.White;
            this.btnTable_8.Location = new System.Drawing.Point(46, 41);
            this.btnTable_8.Name = "btnTable_8";
            this.btnTable_8.Size = new System.Drawing.Size(150, 138);
            this.btnTable_8.TabIndex = 1;
            this.btnTable_8.Text = "Bàn số 8";
            this.btnTable_8.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(804, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 675);
            this.panel2.TabIndex = 5;
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.Silver;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(3, 149);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(436, 382);
            this.lsvBill.TabIndex = 1;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nmdCount);
            this.panel3.Controls.Add(this.cmbProduct);
            this.panel3.Controls.Add(this.cmbCategoryProduct);
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 140);
            this.panel3.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources.backgroundCFMresized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý bán Cà phê";
            ((System.ComponentModel.ISupportInitialize)(this.nmdCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nmdCount;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox cmbCategoryProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTable_4;
        private System.Windows.Forms.Button btnTable_2;
        private System.Windows.Forms.Button btnTable_1;
        private System.Windows.Forms.Button btnTable_5;
        private System.Windows.Forms.Button btnTable_9;
        private System.Windows.Forms.Button btnTable_10;
        private System.Windows.Forms.Button btnTable_7;
        private System.Windows.Forms.Button btnTable_6;
        private System.Windows.Forms.Button btnTable_3;
        private System.Windows.Forms.Button btnTable_8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbTableFood;
    }
}

