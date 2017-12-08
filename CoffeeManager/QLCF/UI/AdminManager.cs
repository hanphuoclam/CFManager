using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF.UI
{
    public partial class AdminManager : Form
    {
        public AdminManager()
        {
            InitializeComponent();
        }

        private void btnProductManager_Click(object sender, EventArgs e)
        {
            ProductForm p = new ProductForm();
            this.Hide();
            p.ShowDialog();
            this.Show();
        }

        private void btnBillManager_Click(object sender, EventArgs e)
        {
            BillForm b = new BillForm();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void btnReceiptManager_Click(object sender, EventArgs e)
        {
            ReceiptForm r = new ReceiptForm();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }
    }
}
