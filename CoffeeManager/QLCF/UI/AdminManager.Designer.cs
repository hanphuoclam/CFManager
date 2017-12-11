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
            this.btnProductManager = new System.Windows.Forms.Button();
            this.btnBillManager = new System.Windows.Forms.Button();
            this.btnReceiptManager = new System.Windows.Forms.Button();
            this.btnUserManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductManager
            // 
            this.btnProductManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProductManager.Location = new System.Drawing.Point(223, 218);
            this.btnProductManager.Name = "btnProductManager";
            this.btnProductManager.Size = new System.Drawing.Size(220, 142);
            this.btnProductManager.TabIndex = 0;
            this.btnProductManager.Text = "Quản lí sản phẩm";
            this.btnProductManager.UseVisualStyleBackColor = true;
            this.btnProductManager.Click += new System.EventHandler(this.btnProductManager_Click);
            // 
            // btnBillManager
            // 
            this.btnBillManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBillManager.Location = new System.Drawing.Point(509, 218);
            this.btnBillManager.Name = "btnBillManager";
            this.btnBillManager.Size = new System.Drawing.Size(220, 142);
            this.btnBillManager.TabIndex = 1;
            this.btnBillManager.Text = "Quản lí hóa đơn";
            this.btnBillManager.UseVisualStyleBackColor = true;
            this.btnBillManager.Click += new System.EventHandler(this.btnBillManager_Click);
            // 
            // btnReceiptManager
            // 
            this.btnReceiptManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReceiptManager.Location = new System.Drawing.Point(798, 218);
            this.btnReceiptManager.Name = "btnReceiptManager";
            this.btnReceiptManager.Size = new System.Drawing.Size(220, 142);
            this.btnReceiptManager.TabIndex = 2;
            this.btnReceiptManager.Text = "Quản lí nhập hàng";
            this.btnReceiptManager.UseVisualStyleBackColor = true;
            this.btnReceiptManager.Click += new System.EventHandler(this.btnReceiptManager_Click);
            // 
            // btnUserManager
            // 
            this.btnUserManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUserManager.Location = new System.Drawing.Point(223, 404);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(220, 142);
            this.btnUserManager.TabIndex = 3;
            this.btnUserManager.Text = "Quản lí tài khoản";
            this.btnUserManager.UseVisualStyleBackColor = true;
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // AdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources.backgroundCFMresized;
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.btnUserManager);
            this.Controls.Add(this.btnReceiptManager);
            this.Controls.Add(this.btnBillManager);
            this.Controls.Add(this.btnProductManager);
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
    }
}