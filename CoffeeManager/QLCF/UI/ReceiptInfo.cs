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
    public partial class ReceiptInfoForm : Form
    {
        private int idReceipt;
        private IReceiptInfoService<ReceiptInfo> _serviceReceiptInfo;
        public ReceiptInfoForm(int idReceipt)
        {
            this.idReceipt = idReceipt;
            InitializeComponent();
            InitData();
            LoadListReceiptInfo(idReceipt);
            PaintDGV();
        }

        void InitData()
        {
            this._serviceReceiptInfo = new ReceiptInfoService(new ReceiptInfoRepository());
        }
        void PaintDGV()
        {//width = 595
            dgvListReceiptForm.Columns[0].Width = 70;
            dgvListReceiptForm.Columns[1].Width = 100;
            dgvListReceiptForm.Columns[2].Width = 275;
            dgvListReceiptForm.Columns[3].Width = 150;
        }
        void LoadListReceiptInfo(int idReceipt)
        {
            IEnumerable listReceipt = _serviceReceiptInfo.GetReceiptInfoByIdReceipt_S(idReceipt);
            DataTable data = new DataTable();
            data.Columns.Add("STT");
            data.Columns.Add("ID HĐ Nhập");
            data.Columns.Add("Tên sản phẩm");
            data.Columns.Add("Số lượng");
            int i = 1;
            foreach(ReceiptInfo item in listReceipt)
            {
                data.Rows.Add(i, item.idReceipt, item.Product.name, item.count);
                i++;
            }
            dgvListReceiptForm.DataSource = data;
        }
    }
}
