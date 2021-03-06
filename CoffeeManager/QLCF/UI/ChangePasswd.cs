﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF.Domain;
using QLCF.Services;
using QLCF.Domain.Validation;
using QLCF.Infrastructure;

namespace QLCF.UI
{
    public partial class ChangePasswdForm : Form
    {
        private Account accountLogin;
        private IAccountService<Account> _serviceAcc;
        private ModelStateValidation _modelState;
        public ChangePasswdForm(Account acc)
        {
            InitializeComponent();
            this.accountLogin = acc;
            IntData();
        }

        public Account AccountLogin { get => accountLogin; set => accountLogin = value; }
        #region methods
        void IntData()
        {
            _modelState = new ModelStateValidation();
            _serviceAcc = new AccountService(new ValidationWrapper(_modelState));
        }
        void Remove()
        {
            txtConfrimPass.ResetText();
            txtNewPass.ResetText();
            txtPass.ResetText();
        }

        void ChangePasswd ()
        {
            string pass = txtPass.Text;
            string newpass = txtNewPass.Text;
            string cfpass = txtConfrimPass.Text;
            if (pass == "") MessageBox.Show("Bạn chưa nhập mật khẩu cũ!!!");
            else if (newpass == "") MessageBox.Show("Bạn chưa nhập mật khẩu mới!!!");
            else if (cfpass == "") MessageBox.Show("Bạn chưa nhập xác nhận mật khẩu!!!");
            else if (newpass != cfpass)
            {
                MessageBox.Show("xác nhận mật khẩu không đúng!!!");
                txtConfrimPass.ResetText();
                txtNewPass.ResetText();
            }
            else if (Infrastructure.MethodsSupport.HasPass(pass) != accountLogin.passWord)
            {
                MessageBox.Show("Mật khẩu cũ không đúng!!!");
                txtPass.ResetText();
            }
            else
            {
                string username = accountLogin.userName;
                if (_serviceAcc.EditAccount_S(new Account() { userName = username, passWord = Infrastructure.MethodsSupport.HasPass(newpass) , type = accountLogin.type }))
                    MessageBox.Show("Đổi mật khẩu thành công!!!");
                Remove();
            }
        }
        #endregion
        #region events
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChangePasswd();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
