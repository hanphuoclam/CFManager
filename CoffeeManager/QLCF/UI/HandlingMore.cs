using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using QLCF.Domain;
using QLCF.Repository;
using QLCF.Services;

namespace QLCF.UI
{
    public partial class HandlingMoreForm : Form
    {
        private int _idTable;
        private IEnumerable _listBillInfo;
        private List<BillInfo> _listProductChoosed = new List<BillInfo>();
        private IProductService<Product> _serviceProduct;
        private IBillInfoService<BillInfo> _serviceBillInfo;
        private IBillService<Bill> _serviceBill;
        private ITableFoodService _serviceTableFood;
        public HandlingMoreForm(int idtable, IEnumerable listBillInfo)
        {
            InitializeComponent();
            this._idTable = idtable;
            this._listBillInfo = listBillInfo;
            initData();
            LoadListProductOfTableChoosed();
            LoadListTable();
        }

        void initData()
        {
            this._serviceProduct = new ProductService(new ProductRepository());
            this._serviceBillInfo = new BillInfoService(new BillInfoRepository());
            this._serviceBill = new BillService(new BillRepository());
            this._serviceTableFood = new TableFoodService(new TableFoodRepository());
        }
        #region Methods
        void LoadListTable()
        {
            IEnumerable listTable = _serviceTableFood.GetAll();
            cmbListTable.DataSource = listTable;
            cmbListTable.DisplayMember = "name";
        }
        bool CheckProCountChoosed(BillInfo BI)
        {
            //int idBill = _serviceBill.GetUncheckBillByIdTable_S(_idTable);
            //IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            foreach (BillInfo item in this._listBillInfo)
            {
                if (BI.id == item.id)
                {
                    if (BI.count < item.count)
                        return false;
                }
            }
            return true;
        }
        void UpdateProCount(BillInfo BI)
        {
            int idBill = _serviceBill.GetUncheckBillByIdTable_S(_idTable);
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            foreach (BillInfo item in listBillInfo)
            {
                if (BI.id == item.id)
                {
                    if (_serviceBillInfo.UpdateBillInfo_S(new BillInfo()
                    { id = item.id, idBill = idBill, idProduct = item.idProduct, count = (item.count - BI.count) }))
                    {
                        break;
                    }
                    break;
                }
            }
        }
        bool CheckBillNull(int id)
        {
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(id);
            return QLCF.Infrastructure.MethodsSupport.Count(listBillInfo) <= 0 ? true : false;
        }
        void ChangeProductTable()
        {
            int idBillBeSwitch = _serviceBill.GetUncheckBillByIdTable_S(_idTable);
            int idTableSwitchTo = (cmbListTable.SelectedItem as TableFood).id;
            if (idTableSwitchTo == _idTable)
            {
                MessageBox.Show("Đây là bàn hiện tại đang thao tác. Xin chọn lại bàn khác!");
                return;
            }
            int idBillSwitchTo = _serviceBill.GetUncheckBillByIdTable_S(idTableSwitchTo);
            bool check = false;
            if (idBillSwitchTo == -1)
            {
                if (MessageBox.Show(String.Format("Bạn có chắc chắn muốn tách những sản phẩm đã chọn của Bàn {0} sang {1} không?"
                    , _idTable, (cmbListTable.SelectedItem as TableFood).name), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (_serviceBill.AddBill_S(new Bill() { idTable = idTableSwitchTo, dateCheckIn = DateTime.Now, discount = 0, status = 0, totalPrice = 0 }))
                    {//Tạo bill mới cho bàn đc chuyển tới
                        int idBillCurrent = _serviceBill.GetMaxIdBill_S().GetValueOrDefault();
                        foreach (BillInfo item in _listProductChoosed)
                        {//Chuyển billinfo(checked) of bàn được chọn(đang thao tác) => bàn mới
                            if (CheckProCountChoosed(item))
                            {// Kiểm tra nếu số lượng được chọn bằng số lượng của billInfo ban đầu
                               
                                if (_serviceBillInfo.UpdateBillInfo_S(new BillInfo()
                                { id = item.id, idBill = idBillCurrent, idProduct = item.idProduct, count = item.count }))
                                { // idBill ở đây là của bill mới tạo nên lấy giá trị max của bill 
                                    check = true;
                                }
                            }
                            else
                            {//Số lượng được chọn ít hơn số lượng ban đầu
                                if (_serviceBillInfo.AddBillInfo_S(new BillInfo()
                                { idBill = idBillCurrent, idProduct = item.idProduct, count = item.count }))
                                { // idBill ở đây là của bill mới tạo nên lấy giá trị max của bill 
                                    check = true;
                                }
                                UpdateProCount(item);
                            }
                        }
                    }
                }
            }
            else
            { //Trường hợp này là 2 bàn cùng có bill nên k cần tạo bill mới cho bàn chuyển tới
                if (MessageBox.Show(String.Format("Bạn có chắc chắn muốn tách những sản phẩm đã chọn Bàn {0} sang {1} không?"
                    , _idTable, (cmbListTable.SelectedItem as TableFood).name), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (BillInfo item in _listProductChoosed)
                    {//Chuyển billinfo(checked) of bàn được chọn(đang thao tác) => bàn đc chuyển tới
                        if (CheckProCountChoosed(item))
                        {
                            if (_serviceBillInfo.UpdateBillInfo_S(new BillInfo()
                            { id = item.id, idBill = idBillSwitchTo, idProduct = item.idProduct, count = item.count }))
                            {
                                check = true;
                            }
                        }
                        else
                        {
                            if (_serviceBillInfo.AddBillInfo_S(new BillInfo()
                            { idBill = idBillSwitchTo, idProduct = item.idProduct, count = item.count }))
                            {
                                check = true;
                            }
                            UpdateProCount(item);
                        }
                    }
                }
            }
            if (CheckBillNull(idBillBeSwitch))
            {
                _serviceBill.DeleteBillById_S(idBillBeSwitch);
                MessageBox.Show("Xóa bill null");
            }
            if (check)
            {
                int idBill = _serviceBill.GetUncheckBillByIdTable_S(_idTable);
                if (CheckBillNull(idBill))
                    _serviceTableFood.UpdateStatus_S(new TableFood() { id = _idTable, status = "Trống" });
                if (idBillSwitchTo == -1)
                {
                    MessageBox.Show("Tách bàn thành công!");
                    _serviceTableFood.UpdateStatus_S(new TableFood() { id = idTableSwitchTo, status = "Có Khách" });
                }
                else
                    MessageBox.Show("Gọp bàn thành công!");
            }
            //ShowBill(idTableSwitchTo);
            //LoadTable();
            //LoadListProductOfTableChoosed();
        }
        void AddProductInList(BillInfo billInfo)
        {
            _listProductChoosed.Add(billInfo);
            LoadListProductChossed();
        }
        void RemoveProductFromList(BillInfo billInfo)
        {
            _listProductChoosed.Remove(billInfo);
            LoadListProductChossed();
        }
        void UpdateListProChoosed(int idbillinfo, int count)
        {
            foreach (BillInfo item in _listProductChoosed)
            {
                if (item.id == idbillinfo)
                {
                    //BillInfo b = new BillInfo() { id = item.id, idProduct = item.idProduct, idBill = item.idBill, count = count };

                    //_listProductChoosed.Remove(item);
                    //_listProductChoosed.Add(b);
                    item.count = count;
                    break;
                }
            }
        }
        void LoadListProductChossed()
        {
            if (_listProductChoosed.Count <= 0)
                return;
            double totalPrice = 0;
            dgvListProChoosed.Rows.Clear();
            dgvListProChoosed.Refresh();
            foreach (BillInfo item in _listProductChoosed)
            {
                dgvListProChoosed.Rows.Add(item.id, item.Product.name, item.Product.price, item.count);
                totalPrice += item.count.GetValueOrDefault() * item.Product.price.GetValueOrDefault();
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPrice.ToString("C", culture);
        }
        void LoadListProductOfTableChoosed()
        {
            int idBill = _serviceBill.GetUncheckBillByIdTable_S(_idTable);
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            dgvProductChanged.Rows.Clear();
            dgvProductChanged.Refresh();
            foreach (BillInfo item in listBillInfo)
            {
                dgvProductChanged.Rows.Add(item.id, item.Product.name, item.count, item.Product.price);
            }
        }
        bool CompareList(IEnumerable listbillInfo)
        {
            int idBill = _serviceBill.GetUncheckBillByIdTable_S(_idTable);
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            int LengthListOrg = QLCF.Infrastructure.MethodsSupport.Count(listBillInfo);
            int LengthNewList = QLCF.Infrastructure.MethodsSupport.Count(listbillInfo);

            return false;
        }
        #endregion
        #region Events
        private void dgvProductChanged_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)//set your checkbox column index instead of 2
            {
                if (Convert.ToBoolean(dgvProductChanged.Rows[e.RowIndex].Cells[4].EditedFormattedValue) == true)
                {
                    int id = Convert.ToInt32(dgvProductChanged.Rows[e.RowIndex].Cells[0].Value);
                    BillInfo b = _serviceBillInfo.GetBillInfoById_S(id);
                    BillInfo ba = new BillInfo() { id = b.id, idBill = b.idBill, idProduct = b.idProduct, count = b.count, Product = b.Product };
                    AddProductInList(ba);
                }
                else
                {
                    int id = Convert.ToInt32(dgvProductChanged.Rows[e.RowIndex].Cells[0].Value);
                    RemoveProductFromList(_serviceBillInfo.GetBillInfoById_S(id));
                }
                LoadListProductChossed();
            }
        }

        private void dgvListProChoosed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListProChoosed.Columns["colEdit"].Index && e.RowIndex >= 0)
            {
                int idBillInfo = Convert.ToInt32(dgvListProChoosed.SelectedCells[0].OwningRow.Cells["colID"].Value.ToString());
                int Count;
                try
                {
                    Count = Convert.ToInt32(dgvListProChoosed.SelectedCells[0].OwningRow.Cells["colCountPro"].Value.ToString());
                }
                catch
                {
                    Count = 1;
                }

                UpdateListProChoosed(idBillInfo, Count);
                dgvListProChoosed.Rows.Clear();
                dgvListProChoosed.Refresh();
                LoadListProductChossed();
            }
        }

        private void dgvListProChoosed_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);

            e.Control.KeyPress += new KeyPressEventHandler(dataGridViewTextBox_KeyPress);
        }
        private void dataGridViewTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            ChangeProductTable();
        }
        #endregion
    }
}

