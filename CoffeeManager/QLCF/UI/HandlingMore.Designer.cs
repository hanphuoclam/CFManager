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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvListProChoosed = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbListTable = new System.Windows.Forms.ComboBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductChanged)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProChoosed)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductChanged
            // 
            this.dgvProductChanged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductChanged.Location = new System.Drawing.Point(12, 81);
            this.dgvProductChanged.Name = "dgvProductChanged";
            this.dgvProductChanged.Size = new System.Drawing.Size(428, 510);
            this.dgvProductChanged.TabIndex = 0;
            this.dgvProductChanged.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductChanged_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
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
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 48);
            this.panel1.TabIndex = 2;
            // 
            // dgvListProChoosed
            // 
            this.dgvListProChoosed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProChoosed.Location = new System.Drawing.Point(446, 81);
            this.dgvListProChoosed.Name = "dgvListProChoosed";
            this.dgvListProChoosed.Size = new System.Drawing.Size(474, 358);
            this.dgvListProChoosed.TabIndex = 3;
            this.dgvListProChoosed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProChoosed_CellClick);
            this.dgvListProChoosed.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvListProChoosed_EditingControlShowing);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChangeTable);
            this.panel2.Controls.Add(this.cmbListTable);
            this.panel2.Location = new System.Drawing.Point(446, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 146);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Location = new System.Drawing.Point(688, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 146);
            this.panel3.TabIndex = 5;
            // 
            // cmbListTable
            // 
            this.cmbListTable.FormattingEnabled = true;
            this.cmbListTable.Location = new System.Drawing.Point(20, 17);
            this.cmbListTable.Name = "cmbListTable";
            this.cmbListTable.Size = new System.Drawing.Size(189, 21);
            this.cmbListTable.TabIndex = 0;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(23, 18);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(192, 20);
            this.txtTotalPrice.TabIndex = 0;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Location = new System.Drawing.Point(79, 70);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(117, 33);
            this.btnChangeTable.TabIndex = 1;
            this.btnChangeTable.Text = "button1";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(98, 70);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(117, 33);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "button2";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // HandlingMoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 603);
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
        private System.Windows.Forms.TextBox txtTotalPrice;
    }
}