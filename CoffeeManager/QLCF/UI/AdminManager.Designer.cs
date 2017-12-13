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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProductManager
            // 
            this.btnProductManager.BackColor = System.Drawing.Color.Black;
            this.btnProductManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProductManager.ForeColor = System.Drawing.Color.White;
            this.btnProductManager.Location = new System.Drawing.Point(218, 110);
            this.btnProductManager.Name = "btnProductManager";
            this.btnProductManager.Size = new System.Drawing.Size(220, 142);
            this.btnProductManager.TabIndex = 0;
            this.btnProductManager.Text = "Quản lí sản phẩm";
            this.btnProductManager.UseVisualStyleBackColor = false;
            this.btnProductManager.Click += new System.EventHandler(this.btnProductManager_Click);
            // 
            // btnBillManager
            // 
            this.btnBillManager.BackColor = System.Drawing.Color.Black;
            this.btnBillManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBillManager.ForeColor = System.Drawing.Color.White;
            this.btnBillManager.Location = new System.Drawing.Point(509, 110);
            this.btnBillManager.Name = "btnBillManager";
            this.btnBillManager.Size = new System.Drawing.Size(220, 142);
            this.btnBillManager.TabIndex = 1;
            this.btnBillManager.Text = "Quản lí hóa đơn";
            this.btnBillManager.UseVisualStyleBackColor = false;
            this.btnBillManager.Click += new System.EventHandler(this.btnBillManager_Click);
            // 
            // btnReceiptManager
            // 
            this.btnReceiptManager.BackColor = System.Drawing.Color.Black;
            this.btnReceiptManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReceiptManager.ForeColor = System.Drawing.Color.White;
            this.btnReceiptManager.Location = new System.Drawing.Point(800, 110);
            this.btnReceiptManager.Name = "btnReceiptManager";
            this.btnReceiptManager.Size = new System.Drawing.Size(220, 142);
            this.btnReceiptManager.TabIndex = 2;
            this.btnReceiptManager.Text = "Nhập hàng";
            this.btnReceiptManager.UseVisualStyleBackColor = false;
            this.btnReceiptManager.Click += new System.EventHandler(this.btnReceiptManager_Click);
            // 
            // btnUserManager
            // 
            this.btnUserManager.BackColor = System.Drawing.Color.Black;
            this.btnUserManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUserManager.ForeColor = System.Drawing.Color.White;
            this.btnUserManager.Location = new System.Drawing.Point(509, 287);
            this.btnUserManager.Name = "btnUserManager";
            this.btnUserManager.Size = new System.Drawing.Size(220, 142);
            this.btnUserManager.TabIndex = 3;
            this.btnUserManager.Text = "Quản lí tài khoản";
            this.btnUserManager.UseVisualStyleBackColor = false;
            this.btnUserManager.Click += new System.EventHandler(this.btnUserManager_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(800, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 142);
            this.button1.TabIndex = 4;
            this.button1.Text = "Quản lí nhập hàng";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(218, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 142);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quản lí danh mục sản phẩm";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // AdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLCF.Properties.Resources.backgroundCFMresized;
            this.ClientSize = new System.Drawing.Size(1264, 722);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}