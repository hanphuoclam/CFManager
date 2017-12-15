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
using QLCF.Services;
using QLCF.Domain.Validation;
using System.Collections;

namespace QLCF.UI
{
    public partial class UserManagerForm : Form
    {
        private Account accountLogin;
        private IAccountService<Account> _serviceAcc;
        private ModelStateValidation _modelState;
        public UserManagerForm(Account acc)
        {
            InitializeComponent();
            this.accountLogin = acc;
            IntData();
            loadListUser();
            //addBindingUser();
            editDgv();
        }
        #region methods
        public Account AccountLogin { get => accountLogin; set => accountLogin = value; }
        void IntData()
        {
            _modelState = new ModelStateValidation();
            _serviceAcc = new AccountService(new ValidationWrapper(_modelState));
        }

        void editDgv()
        {
            dgvListUser.Columns[0].Width = 80;
            dgvListUser.Columns[0].ReadOnly = true;
            dgvListUser.Columns[1].Width = 230;
            dgvListUser.Columns[1].ReadOnly = true;
            dgvListUser.Columns[2].Width = 190;
            dgvListUser.Columns[2].ReadOnly = true;
        }

        void loadListUser()
        {
            IEnumerable listAcc = _serviceAcc.GetAll_S();
            int i = 1;

            DataTable data = new DataTable();
            data.Columns.Add("STT");
            data.Columns.Add("Tên đăng nhập");
            data.Columns.Add("Loại tài khoản");
            foreach (Account item in listAcc)
            {
                string ad = "";
                if (item.type == 1)
                    ad = "Quản lí";
                else if (item.type == 0)
                    ad = "Nhân Viên";
                DataRow row = data.NewRow();
                row["STT"] = i;
                row["Tên đăng nhập"] = item.userName;
                row["Loại tài khoản"] = ad;
                data.Rows.Add(row);
                i++;
            }
            dgvListUser.DataSource = data;
            addBindingUser();
        }

        void addBindingUser()
        {
            txtUserName.Clear();
            txtUserName.DataBindings.Clear();
            //dgvListUser.Refresh();
            txtUserName.DataBindings.Add(new Binding("Text",dgvListUser.DataSource,"Tên đăng nhập", true,DataSourceUpdateMode.Never));
        }

        void ResetPass()
        {
            string username = dgvListUser.SelectedCells[0].OwningRow.Cells["Tên đăng nhập"].Value.ToString();
            string type = dgvListUser.SelectedCells[0].OwningRow.Cells["Loại tài khoản"].Value.ToString();
            if (type != "Nhân Viên")
                type = "1";
            else type = "0";
            if (MessageBox.Show(String.Format("Bạn có muốn reset lại mật khẩu của tài khoản '{0}' không ?", username), "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (_serviceAcc.EditAccount_S(new Account() { userName = username, passWord = "1962026656160185351301320480154111117132155", type = Convert.ToInt32(type)}))
            {
                MessageBox.Show("Reset mật khẩu thành công!!!");
            }
            loadListUser();
        }

        void Save()
        {
            string username = dgvListUser.SelectedCells[0].OwningRow.Cells["Tên đăng nhập"].Value.ToString();
            Account acc = _serviceAcc.GetAccountByUsername_S(username);
            if ((acc.type == (int)nmdType.Value) || (acc.type == 1 && (int)nmdType.Value == 0))
                return;
            if (_serviceAcc.EditAccount_S(new Account(){userName = username, passWord = acc.passWord, type = Convert.ToInt32(nmdType.Value)}))
            {
                MessageBox.Show("Lưu thay đổi thành công!!!");
            }
            loadListUser();
        }

        void Add()
        {
            string user = txtUserName.Text;
            int type = Convert.ToInt32(nmdType.Value);
            Account temp = _serviceAcc.GetAccountByUsername_S(user);
            IEnumerable listAcc = _serviceAcc.GetAll_S();
            if (temp != null)
            {
                if(user == temp.userName)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!!!");
                    return;
                }
            }
            else if (user == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập!!!");
                return;
            }
            foreach (Account item in listAcc)
            {
                if (item.userName.CompareTo(user) == 1)
                {
                    MessageBox.Show("Tài khoản đã tồn tại!!!");
                    return;
                }
            }
            if(_serviceAcc.AddAccount_S(new Account() { userName = user, passWord = "1962026656160185351301320480154111117132155", type = type }))
                MessageBox.Show("Thêm thành công!!!");
            loadListUser();
        }

        void Delete()
        {
            string item = accountLogin.userName;
            string username = dgvListUser.SelectedCells[0].OwningRow.Cells["Tên đăng nhập"].Value.ToString();
            if (MessageBox.Show(String.Format("Bạn có muốn xóa tài khoản '{0}' không ?", username), "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (username == accountLogin.userName) MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập!!!");
            else if (_serviceAcc.DeleteAccount_S(username))
            {
                MessageBox.Show("Xóa thành công!!!");
            }
            loadListUser();
        }
        #endregion
        #region events
        private void btnRSPass_Click(object sender, EventArgs e)
        {
            ResetPass();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
