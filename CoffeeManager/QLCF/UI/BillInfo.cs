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
    public partial class BillInfoForm : Form
    {
        private int IDBill;
        private IBillInfoService<BillInfo> _serviceBillInfo = new BillInfoService(new BillInfoRepository());
        public BillInfoForm(int idBill)
        {
            this.IDBill = idBill;
            InitializeComponent();
            LoadListBillInfo(IDBill);
            PaintDGV();
        }
        void PaintDGV()
        {//width = 549
            dgvListBillInfo.Columns[0].Width = 70;
            dgvListBillInfo.Columns[1].Width = 120;
            dgvListBillInfo.Columns[2].Width = 209;
            dgvListBillInfo.Columns[3].Width = 150;
        }
        void LoadListBillInfo(int idBill)
        {
            IEnumerable listBillInfo = _serviceBillInfo.GetListBillInfoByIdBill_S(idBill);
            DataTable data = new DataTable();
            data.Columns.Add("STT");
            data.Columns.Add("ID Bill");
            data.Columns.Add("Tên sản phẩm");
            data.Columns.Add("Số lượng");
            int i = 1;
            foreach (BillInfo item in listBillInfo)
            {
                data.Rows.Add(i,item.idBill, item.Product.name, item.count);
                i++;
            }
            dgvListBillInfo.DataSource = data;
        }
    }
}
