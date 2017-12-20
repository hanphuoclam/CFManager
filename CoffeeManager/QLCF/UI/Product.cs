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

namespace QLCF.UI
{
    public partial class ProductForm : Form
    {
        private IProductService<Product> _serviceProduct;
        private IProductCategoryService<ProductCategory> _serviceCategory;
        public ProductForm()
        {
            InitializeComponent();
            InitData();
            LoadListFood();
            LoadListCategory();
        }

        #region Methods
        void InitData()
        {
            this._serviceProduct = new ProductService(new ProductRepository());
            this._serviceCategory = new ProductCategoryService(new ProductCategoryRepository());
        }
        void PaintDGV()
        {//width = 484
            dgvListProduct.Columns[0].Width = 50;
            dgvListProduct.Columns[0].ReadOnly = true;
            dgvListProduct.Columns[1].Width = 130;
            dgvListProduct.Columns[1].ReadOnly = true;
            dgvListProduct.Columns[2].Width = 134;
            dgvListProduct.Columns[2].ReadOnly = true;
            dgvListProduct.Columns[3].Width = 100;
            dgvListProduct.Columns[3].ReadOnly = true;
            dgvListProduct.Columns[4].Width = 70;
            dgvListProduct.Columns[4].ReadOnly = true;
        }
        void LoadListCategory()
        {
            cmbListCategory.DataSource = _serviceCategory.GetAll_S();
            cmbListCategory.DisplayMember = "name";
        }
        void LoadListFood()
        {
            IEnumerable list = _serviceProduct.GetAll_S();
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Tên sản phẩm");
            data.Columns.Add("Danh mục");
            data.Columns.Add("Đơn giá");
            data.Columns.Add("SL Tồn");
            foreach (Product item in list)
            {
                DataRow row = data.NewRow();
                row["ID"] = item.id;
                row["Tên sản phẩm"] = item.name;
                row["Danh mục"] = item.ProductCategory.name;
                row["Đơn giá"] = item.price;
                row["SL Tồn"] = item.inventory;
                data.Rows.Add(row);
            }

            dgvListProduct.DataSource = data;
            //dgvListProduct.Columns["ID"].Visible = false;
            AddBindingFood();
            PaintDGV();
        }
        void AddBindingFood()
        {
            txtNameProduct.Clear();
            txtPriceProduct.Clear();
            txtInventory.Clear();
            txtNameProduct.DataBindings.Clear();
            txtPriceProduct.DataBindings.Clear();
            txtInventory.DataBindings.Clear();
            txtNameProduct.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "Tên sản phẩm",true,DataSourceUpdateMode.Never));
            txtPriceProduct.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
            txtInventory.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "SL Tồn", true, DataSourceUpdateMode.Never));
        }

        
        void AddProduct()
        {
            int idProduct = Convert.ToInt32(dgvListProduct.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            string nameProduct = txtNameProduct.Text;
            double priceProduct = double.Parse(txtPriceProduct.Text);
            int idCategory = (cmbListCategory.SelectedItem as ProductCategory).id;
            Product temp = _serviceProduct.GetProductById_S(idProduct);
            if(temp != null)
                if (temp.idCategory == idCategory && temp.price == priceProduct && temp.name == nameProduct)
                    return;
            if (_serviceProduct.AddProduct_S(new Product()
            { idCategory = idCategory, name = nameProduct, price = priceProduct, inventory = 0}))
            {
                MessageBox.Show("Thêm thành công!!!");
            }
            LoadListFood();
        }
        void EditProduct()
        {
            int idProduct = Convert.ToInt32(dgvListProduct.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            string nameProduct = txtNameProduct.Text;
            double priceProduct = double.Parse(txtPriceProduct.Text);
            int idCategory = (cmbListCategory.SelectedItem as ProductCategory).id;
            Product temp = _serviceProduct.GetProductById_S(idProduct);
            if (temp.idCategory == idCategory && temp.price == priceProduct && temp.name == nameProduct)
                return;
            if (_serviceProduct.EditProduc_St(new Product()
            { id = idProduct ,idCategory = idCategory, name = nameProduct, price = priceProduct, inventory = 0 }))
            {
                MessageBox.Show("Sửa thành công!!!");
            }
            LoadListFood();
        }
        void DeleteProduct()
        {
            int idProduct = Convert.ToInt32(dgvListProduct.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            Product temp = _serviceProduct.GetProductById_S(idProduct);
            if (MessageBox.Show(String.Format("Bạn có chắc chắn muốn xóa sản phẩm '{0}'", temp.name), "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (_serviceProduct.DeleteProduct_S(idProduct))
            {
                MessageBox.Show("Xóa thành công!!!");
            }
            LoadListFood();
        }
        void Search()
        {
            string searchtext = txtContextSearch.Text;
            IEnumerable list = _serviceProduct.listSearchPro_S(searchtext);
            if(list == null)
            {
                MessageBox.Show("Không tìm thấy kết quả!");
                return;
            }
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Tên sản phẩm");
            data.Columns.Add("Danh mục");
            data.Columns.Add("Đơn giá");
            data.Columns.Add("SL Tồn");
            foreach (Product item in list)
            {
                string cate = _serviceCategory.GetCategoryById_S(item.idCategory).name;
                DataRow row = data.NewRow();
                row["ID"] = item.id;
                row["Tên sản phẩm"] = item.name;
                row["Danh mục"] = cate;
                row["Đơn giá"] = item.price;
                row["SL Tồn"] = item.inventory;
                data.Rows.Add(row);
            }

            dgvListProduct.DataSource = data;
            //dgvListProduct.Columns["ID"].Visible = false;
            AddBindingFood();
            PaintDGV();
        }
        #endregion

        #region Events
        private void dgvListProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                int idProduct = 1;
                try
                {
                    idProduct = Convert.ToInt32(dgvListProduct.Rows[e.RowIndex].Cells[0].Value);
                }
                catch
                {

                }
                int idCategory = _serviceProduct.GetProductById_S(idProduct).ProductCategory.id;

                int index = -1;
                int i = 0;
                foreach (ProductCategory item in cmbListCategory.Items)
                {
                    if (idCategory == item.id)
                    {
                        index = i;
                    }
                    i++;
                }
                cmbListCategory.SelectedIndex = index;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void txtPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void txtContextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        #endregion


    }
}
