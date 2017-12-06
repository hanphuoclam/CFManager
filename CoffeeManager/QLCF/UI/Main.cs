using QLCF.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCF.Services;
using QLCF.Repository;
using System.Collections;
using System.Globalization;

namespace QLCF
{
    public partial class MainForm : Form
    {
        private Account accountLogin;
        private ITableFoodService _serviceTable;
        private IBillInfoService<BillInfo> _serviceBillInfo;
        private IBillService<Bill> _serviceBill;

        public MainForm(Account acc)
        {
            InitializeComponent();
            this.AccountLogin = acc;
            InitData();
            LoadTable();
        }

        public Account AccountLogin
        {
            get
            {
                return accountLogin;
            }
            set
            {
                accountLogin = value;
                ChangeAccount(accountLogin.type);
            }
        }
#region Methods
        void InitData()
        {
            this._serviceTable = new TableFoodService(new TableFoodRepository());
            this._serviceBillInfo = new BillInfoService(new BillInfoRepository());
            this._serviceBill = new BillService(new BillRepository());
        }
        public void ChangeAccount(int? type)
        {
            adminToolStripMenuItem.Enabled = type == 1 ? true : false;
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + accountLogin.userName + ")";
        }
        void LoadTable()
        {
            IEnumerable<TableFood> listTable = _serviceTable.GetAll();
            foreach (TableFood item in listTable)
            {
                Button btn = new Button();
                switch(item.name)
                {
                    case "Bàn 1":
                        btn = btnTable_1;
                        break;
                    case "Bàn 2":
                        btn = btnTable_2;
                        break;
                    case "Bàn 3":
                        btn = btnTable_3;
                        break;
                    case "Bàn 4":
                        btn = btnTable_4;
                        break;
                    case "Bàn 5":
                        btn = btnTable_5;
                        break;
                    case "Bàn 6":
                        btn = btnTable_6;
                        break;
                    case "Bàn 7":
                        btn = btnTable_7;
                        break;
                    case "Bàn 8":
                        btn = btnTable_8;
                        break;
                    case "Bàn 9":
                        btn = btnTable_9;
                        break;
                    case "Bàn 10":
                        btn = btnTable_10;
                        break;
                }
                btn.Text = item.name + Environment.NewLine + "(" + item.status + ")";
                btn.Click += btn_Click;
                btn.Tag = item;
                switch(item.status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightYellow;
                        break;
                }
            }
        }

        void ShowBill(int idTable)
        {
            int idBill = _serviceBill.GetUncheckBillByIdTable_S(idTable);
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            lsvBill.Items.Clear();
            foreach(BillInfo item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.id.ToString());
                lvItem.SubItems.Add(item.Product.name);
                lvItem.SubItems.Add(item.count.ToString());

                lsvBill.Items.Add(lvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
        }

        #endregion
        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int idtable = (sender as TableFood).id;
            ShowBill(idtable);
        }
        #endregion
    }
}
