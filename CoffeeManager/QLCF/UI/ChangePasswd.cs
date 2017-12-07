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
    public partial class ChangePasswdForm : Form
    {
        private Account accountLogin;
        public ChangePasswdForm(Account acc)
        {
            InitializeComponent();
            this.accountLogin = acc;
        }

        public Account AccountLogin { get => accountLogin; set => accountLogin = value; }
    }
}
