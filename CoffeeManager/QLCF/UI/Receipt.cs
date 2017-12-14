using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using QLCF.Domain;
using QLCF.Services;
using QLCF.Repository;
using QLCF.UI;

namespace QLCF.UI
{
    public partial class ReceiptForm : Form
    {
        private IProductService<Product> _serviceProduct;
        List<Product> listProBeChoose;
        Dictionary<int, int> dictionaryCountPro;
        public ReceiptForm()
        {
            InitializeComponent();
            InitData();
            LoadListProductSuggest();
            //AddBinding();
        }

        #region Methods
        void InitData()
        {
            this._serviceProduct = new ProductService(new ProductRepository());
            this.listProBeChoose = new List<Product>();
            this.dictionaryCountPro = new Dictionary<int, int>();
        }
        void PaintDGV()
        {//width = 457
            dgvProductSuggest.Columns[0].Width = 40;
            dgvProductSuggest.Columns[0].ReadOnly = true;
            dgvProductSuggest.Columns[1].Width = 227;
            dgvProductSuggest.Columns[1].ReadOnly = true;
            dgvProductSuggest.Columns[2].Width = 120;
            dgvProductSuggest.Columns[2].ReadOnly = true;
            dgvProductSuggest.Columns[3].Width = 70;
            dgvProductSuggest.Columns[3].ReadOnly = true;
        }
        void LoadListProductSuggest()
        {
            IEnumerable listProduct = _serviceProduct.GetAll_S();
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Tên sản phẩm");
            data.Columns.Add("Đơn giá");
            data.Columns.Add("SL Tồn");
            foreach (Product item in listProduct)
            {
                bool check = true;
                foreach(Product i in listProBeChoose)
                {
                    if (i.id == item.id)
                        check = false;
                }
                if(item.inventory < 30 && check)
                {
                    DataRow row = data.NewRow();
                    row["ID"] = item.id;
                    row["Tên sản phẩm"] = item.name;
                    row["Đơn giá"] = item.price;
                    row["SL Tồn"] = item.inventory;
                    data.Rows.Add(row);
                }
            }
            dgvProductSuggest.DataSource = data;

            AddBinding();

            PaintDGV();
        }
        void AddBinding()
        {
            txtNamePro.DataBindings.Clear();
            txtPricePro.DataBindings.Clear();
            txtInventoryPro.DataBindings.Clear();
            txtNamePro.DataBindings.Add(new Binding("Text", dgvProductSuggest.DataSource, "Tên sản phẩm", true, DataSourceUpdateMode.Never));
            txtPricePro.DataBindings.Add(new Binding("Text", dgvProductSuggest.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
            txtInventoryPro.DataBindings.Add(new Binding("Text", dgvProductSuggest.DataSource, "SL Tồn", true, DataSourceUpdateMode.Never));
            txtCount.Text = "";
            txtTotalPrice.Text = "";
        }
        void ChooseProduct()
        {
            int idPro = Convert.ToInt32(dgvProductSuggest.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            
            if(MessageBox.Show("Bạn có muốn sản phẩm này vào giỏ hàng??","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int Count = 1;
                if (txtCount.Text.Length != 0)
                    Count = Convert.ToInt32(txtCount.Text);
                Product product = _serviceProduct.GetProductById_S(idPro);
                listProBeChoose.Add(product);
                dictionaryCountPro.Add(idPro, Count);
            }
            LoadListProductSuggest();
        }
        void BuyProduct()
        {
            ReceiptPayForm r = new ReceiptPayForm(listProBeChoose,dictionaryCountPro);
            this.Hide();
            r.ShowDialog();
            this.Show();
            LoadListProductSuggest();
        }
#endregion

        #region Events
        private void btnBuy_Click(object sender, EventArgs e)
        {
            BuyProduct();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ChooseProduct();
        }
        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            int Price = Convert.ToInt32(txtPricePro.Text);
            try
            {
                int count = Convert.ToInt32(txtCount.Text);
                txtTotalPrice.Text = (Price * count).ToString();
            }
            catch
            {

            }
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


    }
}
