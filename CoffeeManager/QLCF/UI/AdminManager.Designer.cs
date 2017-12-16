namespace QLCF.UI
{
    partial class AdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManager));
            this.btnProductManager = new System.Windows.Forms.Button();
            this.btnBillManager = new System.Windows.Forms.Button();
            this.btnReceiptManager = new System.Windows.Forms.Button();
            this.btnUserManager = new System.Windows.Forms.Button();
            this.btnManagerReceipt = new System.Windows.Forms.Button();
            this.btnCategoryManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductManager
            // 
            this.btnProductManager.BackColor = System.Drawing.Color.Black;
            this.btnProductManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProductManager.ForeColor = System.Drawing.Color.White;
            this.btnProductManager.Image = global::QLCF.Properties.Resources.Product;
            this.btnProductManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductManager.Location = new System.Drawing.Point(218, 110);
            this.btnProductManager.Name = "btnProductManager";
            this.btnProductManager.Size = new System.Drawing.Size(220, 152);
            this.btnProductManager.TabIndex = 0;
            this.btnProductManager.Text = "Quản lí sản phẩm";
            this.btnProductManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductManager.UseVisualStyleBackColor = false;
            this.btnProductManager.Click += new System.EventHandler(this.btnProductManager_Click);
            // 
            // btnBillManager
            // 
            this.btnBillManager.BackColor = System.Drawing.Color.Black;
            this.btnBillManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBillManager.ForeColor = System.Drawing.Color.White;
            this.btnBillManager.Image = global::QLCF.Properties.Resources.bill;
            this.btnBillManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBillManager.Location = new System.Drawing.Point(509, 110);
            this.btnBillManager.Name = "btnBillManager";
            this.btnBillManager.Size = new System.Drawing.Size(220, 152);
            this.btnBillManager.TabIndex = 1;
            this.btnBillManager.Text = "Quản lí hóa đơn";
            this.btnBillManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBillManager.UseVisualStyleBackColor = false;
            this.btnBillManager.Click += new System.EventHandler(this.btnBillManager_Click);
            // 
            // btnReceiptManager
            // 
            this.btnReceiptManager.BackColor = System.Drawing.Color.Black;
            this.btnReceiptManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReceiptManager.ForeColor = System.Drawing.Color.White;
            this.btnReceiptManager.Image = global::QLCF.Properties.Resources.store;
            this.btnReceiptManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReceiptManager.Location = new System.Drawing.Point(800, 110);
            this.btnReceiptManager.Name = "btnReceiptManager";
            this.btnReceiptManager.Size = new System.Drawing.Size(220, 152);
            this.btnReceiptManager.TabIndex = 2;
            this.btnReceiptManager.Text = "Nhập hàng";
            this.btnReceiptManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReceiptManager.UseVisualStyleBackColor = false;
            this.btnReceiptManager.Click += new System.EventHandler(this.btnReceiptManager_Click);
            // 
            // btnUserManager
            // 
            this.btnUserManager.BackColor = System.Drawing.Color.Black;
            this.btnUserManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUserManager.ForeColor = System.Drawing.Color.White;
            this.btnUserManager.Image = global::QLCF.Properties.Resources.UserMN;
            this.btnUserManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserManager.Location = new System.Drawing.Point(509, 287);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(220, 152);
            this.btnUserManager.TabIndex = 3;
            this.btnUserManager.Text = "Quản lí tài khoản";
            this.btnUserManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserManager.UseVisualStyleBackColor = false;
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // btnManagerReceipt
            // 
            this.btnManagerReceipt.BackColor = System.Drawing.Color.Black;
            this.btnManagerReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnManagerReceipt.ForeColor = System.Drawing.Color.White;
            this.btnManagerReceipt.Image = global::QLCF.Properties.Resources.QLNhapHang;
            this.btnManagerReceipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManagerReceipt.Location = new System.Drawing.Point(800, 287);
            this.btnManagerReceipt.Name = "btnManagerReceipt";
            this.btnManagerReceipt.Size = new System.Drawing.Size(220, 152);
            this.btnManagerReceipt.TabIndex = 4;
            this.btnManagerReceipt.Text = "Quản lí nhập hàng";
            this.btnManagerReceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManagerReceipt.UseVisualStyleBackColor = false;
            this.btnManagerReceipt.Click += new System.EventHandler(this.btnManagerReceipt_Click);
            // 
            // btnCategoryManager
            // 
            this.btnCategoryManager.BackColor = System.Drawing.Color.Black;
            this.btnCategoryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCategoryManager.ForeColor = System.Drawing.Color.White;
            this.btnCategoryManager.Image = global::QLCF.Properties.Resources.category;
            this.btnCategoryManager.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategoryManager.Location = new System.Drawing.Point(218, 287);
            this.btnCategoryManager.Name = "btnCategoryManager";
            this.btnCategoryManager.Size = new System.Drawing.Size(220, 152);
            this.btnCategoryManager.TabIndex = 5;
            this.btnCategoryManager.Text = "Quản lí danh mục sản phẩm";
            this.btnCategoryManager.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategoryManager.UseVisualStyleBackColor = false;
            this.btnCategoryManager.Click += new System.EventHandler(this.btnCategoryManager_Click);
            // 
            // AdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources.backgroundCFMresized;
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.btnCategoryManager);
            this.Controls.Add(this.btnManagerReceipt);
            this.Controls.Add(this.btnUserManager);
            this.Controls.Add(this.btnReceiptManager);
            this.Controls.Add(this.btnBillManager);
            this.Controls.Add(this.btnProductManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductManager;
        private System.Windows.Forms.Button btnBillManager;
        private System.Windows.Forms.Button btnReceiptManager;
        private System.Windows.Forms.Button btnUserManager;
        private System.Windows.Forms.Button btnManagerReceipt;
        private System.Windows.Forms.Button btnCategoryManager;
    }
}