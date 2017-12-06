using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF.Domain.Validation;
using QLCF.Domain;
using QLCF.Services;

namespace QLCF.UI
{
    public partial class Login : Form
    {
        private IAccountService<Account> _accService;
        private ModelStateValidation _modelState;
        public Login(IAccountService<Account> accService)
        {
            this._accService = accService;
        }
        public Login()
        {
            this._accService = new AccountService(new ValidationWrapper(this._modelState));
            InitializeComponent();
            InitData();
           // SuportThisForm();
        }
        void InitData()
        {
            _modelState = new ModelStateValidation();
            _accService = new AccountService(new ValidationWrapper(this._modelState));
        }
        void login()
        {
            Account acc = new Account() { userName = txtUserName.Text, passWord = txtPassword.Text };
            if(_accService.CheckUser_S(acc))
            {
                MainForm m = new MainForm();
                this.Hide();
                m.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
        #region Methods

        void SuportThisForm()
        {
            this.txtUserName.Size = new System.Drawing.Size(250, 50);
            this.txtPassword.Size = new System.Drawing.Size(250, 50);
        }

        #endregion
#region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?","Thông báo",MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
