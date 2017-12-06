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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           // SuportThisForm();
        }
        #region Methods

        void SuportThisForm()
        {
            this.txtUserName.Size = new System.Drawing.Size(250, 50);
            this.txtPassword.Size = new System.Drawing.Size(250, 50);
        }

        #endregion
    }
}
