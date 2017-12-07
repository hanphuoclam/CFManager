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
        private IProductCategoryService<ProductCategory> _serviceCategory;
        private IProductService<Product> _serviceProduct;

        public MainForm(Account acc)
        {
            InitializeComponent();
            this.AccountLogin = acc;
            InitData();
            LoadTable();
            LoadCategoryProduct();
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
            this._serviceCategory = new ProductCategoryService(new ProductCategoryRepository());
            this._serviceProduct = new ProductService(new ProductRepository());
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
        void LoadCategoryProduct()
        {
            IEnumerable listCategory = _serviceCategory.GetAll_S();
            cmbCategoryProduct.DataSource = listCategory;
            cmbCategoryProduct.DisplayMember = "name";
        }
        void LoadListProductByCategory(int idCategory)
        {
            IEnumerable listProduct = _serviceProduct.GetProductByIdCategory_S(idCategory);
            cmbProduct.DataSource = listProduct;
            cmbProduct.DisplayMember = "name";
        }
        void ShowBill(int idTable)
        {
            int idBill = _serviceBill.GetUncheckBillByIdTable_S(idTable);
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            lsvBill.Items.Clear();
            double totalPriceOfBill = 0;
            foreach(BillInfo item in listBillInfo)
            {
                ListViewItem lvItem = new ListViewItem(item.Product.name);
                lvItem.SubItems.Add(item.count.ToString());
                lvItem.SubItems.Add(item.Product.price.ToString());
                /*
                 * Ở đây có các cách convert kiểu Nullable (int? , double?) => ValueType (int,double)
                 * Ex : int? p1; int p2;
                 * case 1 : p2 = p1 ?? default(int);
                 * case 2 : p2 = p1.GetValueOrDefault();
                 * case 3 : p2 = p1 == null ? default(int) : p1;
                 * case 4 : if(p1.HasValue) p2 = p1.Value;
                 */
                int count = item.count ?? default(int);
                double price = item.Product.price ?? default(double);
                double totalpricEachPro = count * price;
                lvItem.SubItems.Add(totalpricEachPro.ToString());
                totalPriceOfBill += totalpricEachPro;

                lsvBill.Items.Add(lvItem);
            }
            /*
             * Setting lại cái luồng đang chạy thành culture như trên
             * Thread.CurrentThread.CurrentCulture = culture;
             * Chỉ chạy culture ở dòng hiện tại mà không ảnh hưởng tới luồng(thread)
             */
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPriceOfBill.ToString("C", culture);
        }

        #endregion
        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int idtable = ((sender as Button).Tag as TableFood).id;
            ShowBill(idtable);
        }
        private void cmbCategoryProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idcategory = 0;
            ComboBox cmb = sender as ComboBox;
            if (cmb.SelectedItem == null)
                return;
            ProductCategory category = cmb.SelectedItem as ProductCategory;
            idcategory = category.id;

            LoadListProductByCategory(idcategory);
        }
        #endregion


    }
}
