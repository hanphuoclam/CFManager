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
            editDgv();
            addBindingUser();

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
            dgvListUser.Columns[1].Width = 230;
            dgvListUser.Columns[2].Width = 190;
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
        }

        void addBindingUser()
        {
            txtUserName.DataBindings.Add(new Binding("Text",dgvListUser.DataSource,"userName", true,DataSourceUpdateMode.Never));
        }

        void ResetPass()
        {
            string username = dgvListUser.SelectedCells[0].OwningRow.Cells["Tên đăng nhập"].Value.ToString();
            string type = dgvListUser.SelectedCells[0].OwningRow.Cells["Loại tài khoản"].Value.ToString();
            if (type != "Nhân Viên")
                type = "1";
            else type = "0";
            if (_serviceAcc.EditAccount_S(new Account() { userName = username, passWord = "1", type = Convert.ToInt32(type)}))
            {
                MessageBox.Show("Reset mật khẩu thành công!!!");
            }
            loadListUser();
        }

        void Save()
        {
            string username = dgvListUser.SelectedCells[0].OwningRow.Cells["Tên đăng nhập"].Value.ToString();
            if (_serviceAcc.EditAccount_S(new Account(){userName = username, type = Convert.ToInt32(nmdType.Value)}))
            {
                MessageBox.Show("lưu thành công!!!");
            }
            loadListUser();
        }

        void Add()
        {
            string user = txtUserName.Text;
            int type = Convert.ToInt32(nmdType.Value);
            if (user == "") MessageBox.Show("Chưa nhập tên đăng nhập!!!");
            else if(!_serviceAcc.CheckUser_S(new Account() {userName = user }))
            {
                if(_serviceAcc.AddAccount_S(new Account() { userName = user, passWord = "1", type = type }))
                    MessageBox.Show("Thêm thành công!!!");
                loadListUser();
            }
            else MessageBox.Show("Tài khoản đã tồn tại!!!");
        }

        void Delete()
        {
            string item = accountLogin.userName;
            string username = dgvListUser.SelectedCells[0].OwningRow.Cells["Tên đăng nhập"].Value.ToString();
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
        #endregion
    }
}
