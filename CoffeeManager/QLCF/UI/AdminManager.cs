using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF.Domain;

namespace QLCF.UI
{
    public partial class AdminManager : Form
    {
        private Account accountLogin;
        public AdminManager(Account acc)
        {
            this.accountLogin = acc;
            InitializeComponent();
        }

        private void btnProductManager_Click(object sender, EventArgs e)
        {
            ProductForm p = new ProductForm();
            p.ShowDialog();
            this.Show();
        }

        private void btnBillManager_Click(object sender, EventArgs e)
        {
            BillForm b = new BillForm();
            b.ShowDialog();
            this.Show();
        }

        private void btnReceiptManager_Click(object sender, EventArgs e)
        {
            ReceiptForm r = new ReceiptForm();
            r.ShowDialog();
            this.Show();
        }

        private void btnUserManager_Click(object sender, EventArgs e)
        {
            UserManagerForm u = new UserManagerForm(accountLogin);
            u.ShowDialog();
            this.Show();
        }

        private void btnCategoryManager_Click(object sender, EventArgs e)
        {
            FormCategory c = new FormCategory();
            c.ShowDialog();
            this.Show();
        }

        private void btnManagerReceipt_Click(object sender, EventArgs e)
        {
            ReceiptManagerForm r = new ReceiptManagerForm();
            r.ShowDialog();
            this.Show();
        }
    }
}
