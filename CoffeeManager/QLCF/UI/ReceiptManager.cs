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
using System.Globalization;

namespace QLCF.UI
{
    public partial class ReceiptManagerForm : Form
    {
        private IReceiptService<Receipt> _serviceReceipt;
        public ReceiptManagerForm()
        {
            InitializeComponent();
            InitData();
            LoadListReceipt();
            LoadDateTimePicker();
            PaintDGV();
        }
        #region Methods
        void InitData()
        {
            this._serviceReceipt = new ReceiptService(new ReceiptRepository());
        }
        void PaintDGV()
        {//width = 548
            dgvListReceipt.Columns[0].Width = 100;
            dgvListReceipt.Columns[1].Width = 50;
            dgvListReceipt.Columns[1].ReadOnly = true;
            dgvListReceipt.Columns[2].Width = 248;
            dgvListReceipt.Columns[2].ReadOnly = true;
            dgvListReceipt.Columns[3].Width = 150;
            dgvListReceipt.Columns[3].ReadOnly = true;
        }
        void LoadListReceipt()
        {
            IEnumerable listReceipt = _serviceReceipt.GetAll_S();
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Ngày");
            data.Columns.Add("Tổng tiền");
            foreach (Receipt item in listReceipt)
            {
                data.Rows.Add(item.id, item.dateReceipt.ToShortDateString(), item.totalPrice);
            }
            dgvListReceipt.DataSource = data;
        }
        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dpkDateFrom.Value = new DateTime(today.Year, today.Month, 1);
            dpkDateTo.Value = dpkDateFrom.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListReceiptByDate(DateTime dateFrom, DateTime dateTo)
        {
            IEnumerable listReceipt = _serviceReceipt.GetReceiptByDate_S(dateFrom, dateTo);
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Ngày");
            data.Columns.Add("Tổng tiền");
            foreach (Receipt item in listReceipt)
            {
                data.Rows.Add(item.id, item.dateReceipt.ToShortDateString(), item.totalPrice);
            }
            dgvListReceipt.DataSource = data;
        }
        void LoadListReceiptInfo(int idReceipt)
        {
            ReceiptInfoForm r = new ReceiptInfoForm(idReceipt);
            r.ShowDialog();
        }
        #endregion
#region Events
        private void btnViewList_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dpkDateFrom.Value;
            DateTime dateTo = dpkDateTo.Value;
            LoadListReceiptByDate(dateFrom, dateTo);
        }

        private void dgvListReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dgvListReceipt.Columns["ColDetail"].Index && e.RowIndex >= 0)
            {
                int idReceipt = Convert.ToInt32(dgvListReceipt.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                LoadListReceiptInfo(idReceipt);
            }
        }
        private void btnTotalMoney_Click(object sender, EventArgs e)
        {
            double total = 0;
            DateTime dateFrom = dpkDateFrom.Value;
            DateTime dateTo = dpkDateTo.Value;
            LoadListReceiptByDate(dateFrom, dateTo);
            IEnumerable listReceipt = _serviceReceipt.GetReceiptByDate_S(dateFrom, dateTo);
            foreach (Receipt item in listReceipt)
            {
                total += item.totalPrice.GetValueOrDefault();
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalMoney.Text = total.ToString("C", culture);
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
