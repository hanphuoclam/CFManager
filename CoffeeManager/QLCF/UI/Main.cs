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
using QLCF.Infrastructure;
using QLCF.UI;

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
            LoadListtable();
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
        void LoadListtable()
        {
            IEnumerable listTable = _serviceTable.GetAll();
            cmbTableFood.DataSource = listTable;
            cmbTableFood.DisplayMember = "name";
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
        void AddProduct()
        {
            TableFood table = lsvBill.Tag as TableFood;
            if(table == null)
            {
                MessageBox.Show("Xin chọn bàn!!");
                return;
            }
            int idBill = _serviceBill.GetUncheckBillByIdTable_S(table.id);
            int idProduct = (cmbProduct.SelectedItem as Product).id;
            int count = (int)nmdCount.Value;

            if(idBill == -1) // Bill not exist
            {
                if(_serviceBill.AddBill_S(new Bill() { idTable = table.id , dateCheckIn = DateTime.Now, discount = 0, status = 0, totalPrice = 0}))
                    if(_serviceBillInfo.AddBillInfo_S(new BillInfo()
                    { idBill = _serviceBill.GetMaxIdBill_S().GetValueOrDefault(), idProduct = idProduct, count = count }))
                    {
                        //Cập nhật status 
                        _serviceTable.UpdateStatus_S(new TableFood() { id = table.id, status = "Có khách" });

                    }
            }
            else // Bill đã tồn tại
            {
                if (_serviceBillInfo.AddBillInfo_S(new BillInfo()
                { idBill = idBill, idProduct = idProduct, count = count }))
                {
                    //Do something if you want
                }
            }
            ShowBill(table.id);
            LoadTable();
        }
        void CheckOut()
        {
            TableFood table = lsvBill.Tag as TableFood;
            if (table == null)
                return;
            int idBill = _serviceBill.GetUncheckBillByIdTable_S(table.id);
            int discount = Convert.ToInt32(cmbDiscount.SelectedItem);
            double totalPrice = double.Parse(txtTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice * (100 - discount) / 100;

            if(idBill != -1)
            {
                if(MessageBox.Show(String.Format("Bạn có chắc chắn muốn thanh toán bàn : {0}\nTổng tiền là : {1}\nGiảm giá : {2}\nTổng tiền phải trả là : {3}"
                    ,table.name,totalPrice,totalPrice- finalTotalPrice, finalTotalPrice)
                    ,"Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if(_serviceBill.CheckOut_S(new Bill()
                    { id=idBill, discount = discount, dateCheckIn = DateTime.Now, idTable = table.id, totalPrice = finalTotalPrice, status = 1}))
                    {
                        MessageBox.Show("Thanh toán thành công!");
                        _serviceTable.UpdateStatus_S(new TableFood() { id = table.id, name = table.name, status = "Trống" });
                    }
                    ShowBill(table.id);
                    LoadTable();
                }
            }
        }
        void SwitchTable()
        {
            TableFood table = lsvBill.Tag as TableFood;
            if (table == null)
                return;
            int idBillBeSwitch = _serviceBill.GetUncheckBillByIdTable_S(table.id);
            int idTableSwitchTo = (cmbTableFood.SelectedItem as TableFood).id;
            if (idTableSwitchTo == table.id)
                return;
            int idBillSwitchTo = _serviceBill.GetUncheckBillByIdTable_S(idTableSwitchTo);
            IEnumerable listBillInfo_TableBeSwitch = _serviceBillInfo.GetListBillInfoByIdBill_S(idBillBeSwitch);
            bool check = false;
            if (idBillSwitchTo == -1)
            {
                if(MessageBox.Show(String.Format("Bạn có chắc chắn muốn chuyển {0} sang {1} không?"
                    ,table.name,(cmbTableFood.SelectedItem as TableFood).name),"Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (_serviceBill.AddBill_S(new Bill() { idTable = idTableSwitchTo, dateCheckIn = DateTime.Now, discount = 0, status = 0, totalPrice = 0 }))
                    {//Tạo bill mới cho bàn đc chuyển tới
                        int idBillCurrent = _serviceBill.GetMaxIdBill_S().GetValueOrDefault();
                        foreach (BillInfo item in listBillInfo_TableBeSwitch)
                        {//Chuyển tất cả billinfo của bàn được chuyển qua bàn mới
                            
                            if (_serviceBillInfo.UpdateBillInfo_S(new BillInfo()
                            { id = item.id ,idBill = idBillCurrent, idProduct = item.idProduct, count = item.count}))
                            { // idBill ở đây là của bill mới tạo nên lấy giá trị max của bill 
                                check = true;
                            }
                        }
                    }
                }
            }
            else
            { //Trường hợp này là 2 bàn cùng có bill nên k cần tạo bill mới cho bàn chuyển tới
                if (MessageBox.Show(String.Format("Bạn có chắc chắn muốn gọp {0} và {1} không?"
                    , table.name, (cmbTableFood.SelectedItem as TableFood).name), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (BillInfo item in listBillInfo_TableBeSwitch)
                    {//Chuyển tất các các billinfo cho bàn đc chuyển tới
                        if (_serviceBillInfo.UpdateBillInfo_S(new BillInfo()
                        { id = item.id ,idBill = idBillSwitchTo, idProduct = item.idProduct, count = item.count }))
                        {
                            check = true;
                        }
                    }
                }
            }
            _serviceBill.DeleteBillById_S(idBillBeSwitch);
            if (check)
            {
                _serviceTable.UpdateStatus_S(new TableFood() { id = table.id, status = "Trống" });
                if (idBillSwitchTo == -1)
                {
                    MessageBox.Show("Chuyển bàn thành công!");
                    _serviceTable.UpdateStatus_S(new TableFood() { id = idTableSwitchTo , status = "Có Khách" });
                } 
                else
                    MessageBox.Show("Gọp bàn thành công!");
            }
            //ShowBill(idTableSwitchTo);
            LoadTable();
        }
        #endregion
        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int idtable = ((sender as Button).Tag as TableFood).id;
            lsvBill.Tag = (sender as Button).Tag;
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
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswdForm p = new ChangePasswdForm(AccountLogin);
            p.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            SwitchTable();
        }
        #endregion
        
    }
}
