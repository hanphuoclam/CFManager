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
using QLCF.Repository;
using System.Collections;
using System.Globalization;

namespace QLCF.UI
{
    public partial class CheckOutManyTableForm : Form
    {
        private List<int> listIdBill = new List<int>();
        private IBillService<Bill> _serviceBill;
        private IBillInfoService<BillInfo> _serviceBillInfo;
        private ITableFoodService _serviceTableFood;
        public CheckOutManyTableForm()
        {
            InitializeComponent();
            Init();
            LoadListTableHaveBill();
        }
        #region Methods
        void Init()
        {
            this._serviceBill = new BillService(new BillRepository());
            this._serviceBillInfo = new BillInfoService(new BillInfoRepository());
            this._serviceTableFood = new TableFoodService(new TableFoodRepository());
        }
        void LoadListTableHaveBill()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (_serviceBill.GetUncheckBillByIdTable_S(i) != -1)
                {
                    dgvListTable.Rows.Add("Bàn " + i.ToString());
                }
            }
        }
        double CountPrice(int idBill)
        {
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            double S = 0;
            foreach (BillInfo item in listBillInfo)
            {
                S += (item.Product.price.GetValueOrDefault() * item.count.GetValueOrDefault());
            }
            return S;
        }
        double SumPriceOfListTable()
        {
            double S = 0;
            foreach (int item in listIdBill)
            {
                S += CountPrice(item);
            }
            return S;
        }
        void ChangeIdBill(int idBillBeChange, int idBillChangeTo)
        {
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBillBeChange);
            foreach(BillInfo item in listBillInfo)
            {
                if (_serviceBillInfo.UpdateBillInfo_S(new BillInfo()
                { id = item.id, idBill = idBillChangeTo, idProduct = item.idProduct, count = item.count }))
                {
                   
                }
            }
        }
        void DeleteBillNull(int idBill)
        {
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            if (QLCF.Infrastructure.MethodsSupport.Count(listBillInfo) <= 0)
                _serviceBill.DeleteBillById_S(idBill);
        }
        void CheckOut()
        {
            if (listIdBill.Count <= 0) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán các bàn đã chọn không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string note = txtNote.Text;
                int discount = Convert.ToInt32(cmbDiscount.SelectedItem);
                double totalPrice = double.Parse(txtTotalPrice.Text.Split(',')[0]);
                double costsIncurred = double.Parse(txtCostsIncurred.Text);
                double finalTotalPrice = (totalPrice * (100 - discount) / 100) + costsIncurred;
                int idBillChangeTo;
                if (listIdBill.Count > 1)
                {
                    idBillChangeTo = listIdBill[0];
                    foreach (int item in listIdBill)
                    {
                        ChangeIdBill(item, idBillChangeTo);
                        DeleteBillNull(item);
                    }
                }
                Bill b = _serviceBill.GetBillById_S(listIdBill[0]);
                if (_serviceBill.CheckOut_S(new Bill()
                { id = b.id, discount = discount, dateCheckIn = DateTime.Now, idTable = b.idTable, totalPrice = finalTotalPrice, status = 1, Note = note }))
                {
                    MessageBox.Show(String.Format("Thanh toán thành công!\nTạm tính : {0}\nGiảm giá : {1}\nChi phí phát sinh: {2}\nGhi chú : {3}\nTổng tiền phải trả : {4}"
                        ,totalPrice, totalPrice + costsIncurred - finalTotalPrice, costsIncurred, note, finalTotalPrice));
                    _serviceTableFood.UpdateStatus_S(new TableFood() { id = b.idTable, status = "Trống" });
                }
            }

        }
        #endregion
        #region Events
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut();
        }
        private void dgvListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (Convert.ToBoolean(dgvListTable.Rows[e.RowIndex].Cells[1].EditedFormattedValue) == true)
                {
                    string nameTable = dgvListTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int idTable = Convert.ToInt32(nameTable.Split(' ')[1]);
                    listIdBill.Add(_serviceBill.GetUncheckBillByIdTable_S(idTable));
                    double totalPrice = SumPriceOfListTable();
                    CultureInfo culture = new CultureInfo("vi-VN");
                    txtTotalPrice.Text = totalPrice.ToString("C", culture);
                }
                else
                {
                    string nameTable = dgvListTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int idTable = Convert.ToInt32(nameTable.Split(' ')[1]);
                    listIdBill.Remove(_serviceBill.GetUncheckBillByIdTable_S(idTable));
                    double totalPrice = SumPriceOfListTable();
                    CultureInfo culture = new CultureInfo("vi-VN");
                    txtTotalPrice.Text = totalPrice.ToString("C", culture);
                }
            }
        }
        private void txtCostsIncurred_TextChanged(object sender, EventArgs e)
        {
            if (txtCostsIncurred.Text == "") return;
            int discount = Convert.ToInt32(cmbDiscount.SelectedItem);
            double totalPrice = double.Parse(txtTotalPrice.Text.Split(',')[0]);
            double costsIncurred = double.Parse(txtCostsIncurred.Text);
            txtSumTotalPrice.Text = ((totalPrice * (100 - discount) / 100) + costsIncurred).ToString();
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(cmbDiscount.SelectedItem);
            double totalPrice = double.Parse(txtTotalPrice.Text.Split(',')[0]);
            double costsIncurred = double.Parse(txtCostsIncurred.Text);
            txtSumTotalPrice.Text = ((totalPrice * (100 - discount) / 100) + costsIncurred).ToString();
        }
        private void txtCostsIncurred_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtCostsIncurred.Text == "") return;
            int discount = Convert.ToInt32(cmbDiscount.SelectedItem);
            double totalPrice = double.Parse(txtTotalPrice.Text.Split(',')[0]);
            double costsIncurred = double.Parse(txtCostsIncurred.Text);
            txtSumTotalPrice.Text = ((totalPrice * (100 - discount) / 100) + costsIncurred).ToString();
        }
        #endregion


    }
}
