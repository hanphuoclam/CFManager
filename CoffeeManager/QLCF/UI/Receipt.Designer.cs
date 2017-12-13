namespace QLCF.UI
{
    partial class ReceiptForm
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInventoryPro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPricePro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamePro = new System.Windows.Forms.TextBox();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProductSuggest = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSuggest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.Black;
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = global::QLCF.Properties.Resources.cart;
            this.btnChoose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChoose.Location = new System.Drawing.Point(138, 270);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(219, 42);
            this.btnChoose.TabIndex = 10;
            this.btnChoose.Text = "Thêm vào giỏ";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tổng cộng : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số lượng:";
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtCount.Location = new System.Drawing.Point(126, 160);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(240, 35);
            this.txtCount.TabIndex = 6;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "SL Tồn:";
            // 
            // txtInventoryPro
            // 
            this.txtInventoryPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtInventoryPro.Location = new System.Drawing.Point(126, 112);
            this.txtInventoryPro.Name = "txtInventoryPro";
            this.txtInventoryPro.ReadOnly = true;
            this.txtInventoryPro.Size = new System.Drawing.Size(240, 35);
            this.txtInventoryPro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn giá:";
            // 
            // txtPricePro
            // 
            this.txtPricePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtPricePro.Location = new System.Drawing.Point(126, 63);
            this.txtPricePro.Name = "txtPricePro";
            this.txtPricePro.ReadOnly = true;
            this.txtPricePro.Size = new System.Drawing.Size(240, 35);
            this.txtPricePro.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // txtNamePro
            // 
            this.txtNamePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNamePro.Location = new System.Drawing.Point(126, 16);
            this.txtNamePro.Name = "txtNamePro";
            this.txtNamePro.ReadOnly = true;
            this.txtNamePro.Size = new System.Drawing.Size(240, 35);
            this.txtNamePro.TabIndex = 0;
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.nhậpHàngToolStripMenuItem.Text = "File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(35, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bảng gợi ý các sản phẩm cần nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnBuy);
            this.panel2.Controls.Add(this.txtTotalPrice);
            this.panel2.Controls.Add(this.btnChoose);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtInventoryPro);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPricePro);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNamePro);
            this.panel2.Location = new System.Drawing.Point(483, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 589);
            this.panel2.TabIndex = 6;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Black;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Image = global::QLCF.Properties.Resources.tick;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuy.Location = new System.Drawing.Point(29, 544);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(328, 42);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "Thanh toán";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtTotalPrice.Location = new System.Drawing.Point(126, 204);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(240, 35);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvProductSuggest);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 592);
            this.panel1.TabIndex = 4;
            // 
            // dgvProductSuggest
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductSuggest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductSuggest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductSuggest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductSuggest.Location = new System.Drawing.Point(3, 3);
            this.dgvProductSuggest.Name = "dgvProductSuggest";
            this.dgvProductSuggest.RowHeadersVisible = false;
            this.dgvProductSuggest.Size = new System.Drawing.Size(457, 544);
            this.dgvProductSuggest.TabIndex = 0;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources._880x670;
            this.ClientSize = new System.Drawing.Size(864, 631);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductSuggest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInventoryPro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPricePro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamePro;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProductSuggest;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnBuy;
    }
}