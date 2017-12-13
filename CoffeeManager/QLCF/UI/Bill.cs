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
using QLCF.Repository;
using QLCF.Services;
using System.Collections;

namespace QLCF.UI
{
    public partial class BillForm : Form
    {
        private IBillInfoService<BillInfo> _serviceBillInfo;
        private IBillService<Bill> _serviceBill;
        public BillForm()
        {
            InitializeComponent();
            InitData();
            LoadDateTimePicker();
            LoadListBill();
            PaintDGV();
        }
#region Methods
        void InitData()
        {
            this._serviceBill = new BillService(new BillRepository());
            this._serviceBillInfo = new BillInfoService(new BillInfoRepository());
        }
        void PaintDGV()
        {//width = 548
            dgvListBill.Columns[0].Width = 70;
            dgvListBill.Columns[1].Width = 50;
            dgvListBill.Columns[2].Width = 150;
            dgvListBill.Columns[3].Width = 120;
            dgvListBill.Columns[4].Width = 158;
        }
        void LoadListBill()
        {
            IEnumerable listBill = _serviceBill.GetAll_S();
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Ngày");
            data.Columns.Add("Giảm giá");
            data.Columns.Add("Tổng tiền");
            foreach(Bill item in listBill)
            {
                data.Rows.Add(item.id, item.dateCheckIn.ToShortDateString(), item.discount, item.totalPrice);
            }
            dgvListBill.DataSource = data;
        }
        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dpkDateFrom.Value = new DateTime(today.Year, today.Month, 1);
            dpkDateTo.Value = dpkDateFrom.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime dateFrom, DateTime dateTo)
        {
            IEnumerable listBill = _serviceBill.GetBillByDate_S(dateFrom, dateTo);
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Ngày");
            data.Columns.Add("Giảm giá");
            data.Columns.Add("Tổng tiền");
            foreach (Bill item in listBill)
            {
                data.Rows.Add(item.id, item.dateCheckIn.ToShortDateString(), item.discount, item.totalPrice);
            }
            dgvListBill.DataSource = data;
        }
        void LoadListBillInfo(int idBill)
        {
            BillInfoForm b = new BillInfoForm(idBill);
            b.ShowDialog();
        }
#endregion
        #region Events
        private void btnViewList_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dpkDateFrom.Value;
            DateTime dateTo = dpkDateTo.Value;
            LoadListBillByDate(dateFrom, dateTo);
        }
        private void dgvListBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvListBill.Columns["ColDetail"].Index && e.RowIndex >= 0)
            {
                int idBill = Convert.ToInt32(dgvListBill.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                LoadListBillInfo(idBill);
            }
        }
        #endregion


    }
}
