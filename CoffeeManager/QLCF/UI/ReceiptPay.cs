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
using QLCF.Repository;
using QLCF.Services;
using System.Globalization;

namespace QLCF.UI
{
    public partial class ReceiptPayForm : Form
    {
        private List<Product> listPro;
        private Dictionary<int, int> dictionaryCountPro;

        private IReceiptInfoService<ReceiptInfo> _serviceReceiptInfo;
        private IReceiptService<Receipt> _serviceReceipt;
        private IProductService<Product> _serviceProduct;

        public ReceiptPayForm(List<Product> listPro, Dictionary<int, int> dictionaryCountPro)
        {
            this.listPro = listPro;
            this.dictionaryCountPro = dictionaryCountPro;
            InitializeComponent();
            InitData();
            LoadListProductReceipt();
        }

#region Methods
        void InitData()
        {
            this._serviceReceipt = new ReceiptService(new ReceiptRepository());
            this._serviceReceiptInfo = new ReceiptInfoService(new ReceiptInfoRepository());
            this._serviceProduct = new ProductService(new ProductRepository());
        }
        void LoadListProductReceipt()
        {
            if (listPro.Count <= 0)
                return;
            double totalPrice = 0;
            foreach(Product item in listPro)
            {
                foreach(KeyValuePair<int,int> i in dictionaryCountPro)
                {
                    if(i.Key == item.id)
                    {
                        dgvListProductReceipt.Rows.Add(item.id, item.name, item.price, i.Value);
                        totalPrice += item.price.GetValueOrDefault() * i.Value;
                        break;
                    }
                }
            }
            txtTotalPrice.Text = totalPrice.ToString();
            dgvListProductReceipt.Columns[0].ReadOnly = true;
            dgvListProductReceipt.Columns[1].ReadOnly = true;
            dgvListProductReceipt.Columns[2].ReadOnly = true;
        }
        void DeleteProduct(int idPro)
        {
            foreach(Product item in listPro)
            {
                if (item.id == idPro)
                {
                    listPro.Remove(item);
                    break;
                }
            }
            foreach(KeyValuePair<int,int> item in dictionaryCountPro)
            {
                if(item.Key == idPro)
                {
                    dictionaryCountPro.Remove(item.Key);
                    break;
                }
            }
        }
        void UpdateProduct(int idPro, int count)
        {
            dictionaryCountPro[idPro] = count;
        }

        void Buy()
        {
            if (dgvListProductReceipt.RowCount <= 0)
                return;
            if(MessageBox.Show("Bạn có chắc chắn mua các sản phẩm này không!", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool check = false;
                if(_serviceReceipt.AddReceipt_S(new Receipt()
                { dateReceipt = DateTime.Now, totalPrice = 0}))
                {
                    int idReceiptCurrent = _serviceReceipt.GetMaxIdReceipt_S().GetValueOrDefault();
                    foreach(Product item in listPro)
                    {
                        if(_serviceReceiptInfo.AddReceiptInfo_S(new ReceiptInfo()
                        { idReceipt = idReceiptCurrent, idProduct = item.id, count = dictionaryCountPro[item.id]}))
                        {
                            if (_serviceProduct.EditProduc_St(new Product()
                            {
                                id = item.id,
                                idCategory = item.idCategory,
                                name = item.name,
                                price = item.price,
                                inventory = item.inventory + dictionaryCountPro[item.id]
                            }))
                            {

                                check = true;
                            }
                        }
                    }
                    _serviceReceipt.Pay_S(new Receipt() { id = idReceiptCurrent, dateReceipt = DateTime.Now, totalPrice = Double.Parse( txtTotalPrice.Text) });
                }
                if (check)
                {
                    MessageBox.Show("Mua thành công!");
                    listPro.Clear();
                    dictionaryCountPro.Clear();
                    this.Close();
                }
            }
        }
#endregion
        #region Events

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Buy();
        }

        private void dgvListProductReceipt_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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

        private void dgvListProductReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListProductReceipt.Columns["ColDelete"].Index && e.RowIndex >= 0)
            {
                string namePro = dgvListProductReceipt.SelectedCells[0].OwningRow.Cells["ColName"].Value.ToString();
                if (MessageBox.Show(String.Format("Bạn có chắc chắn muốn xóa : '{0}' khỏi danh sách không???", namePro), "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idPro = Convert.ToInt32(dgvListProductReceipt.SelectedCells[0].OwningRow.Cells["ColID"].Value.ToString());
                    DeleteProduct(idPro);
                }
                dgvListProductReceipt.Rows.Clear();
                dgvListProductReceipt.Refresh();
                LoadListProductReceipt();
            }
            else if (e.ColumnIndex == dgvListProductReceipt.Columns["ColSave"].Index && e.RowIndex >= 0)
            {
                int idPro = Convert.ToInt32(dgvListProductReceipt.SelectedCells[0].OwningRow.Cells["ColID"].Value.ToString());
                int Count;
                try
                {
                    Count = Convert.ToInt32(dgvListProductReceipt.SelectedCells[0].OwningRow.Cells["ColCount"].Value.ToString());
                }
                catch
                {
                    Count = 1;
                }

                UpdateProduct(idPro, Count);
                dgvListProductReceipt.Rows.Clear();
                dgvListProductReceipt.Refresh();
                LoadListProductReceipt();
            }
            
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    #endregion


}
