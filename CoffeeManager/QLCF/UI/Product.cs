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
            AddBindingFood();
        }

        #region Methods
        void InitData()
        {
            this._serviceProduct = new ProductService(new ProductRepository());
            this._serviceCategory = new ProductCategoryService(new ProductCategoryRepository());
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
        }
        void AddBindingFood()
        {
            txtNameProduct.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "Tên sản phẩm",true,DataSourceUpdateMode.Never));
            txtPriceProduct.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "Đơn giá", true, DataSourceUpdateMode.Never));
            txtInventory.DataBindings.Add(new Binding("Text", dgvListProduct.DataSource, "SL Tồn", true, DataSourceUpdateMode.Never));
        }

        
        void AddProduct()
        {
            string nameProduct = txtNameProduct.Text;
            double priceProduct = double.Parse(txtPriceProduct.Text);
            int idCategory = (cmbListCategory.SelectedItem as ProductCategory).id;
            if(_serviceProduct.AddProduct_S(new Product()
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
            if (_serviceProduct.DeleteProduct_S(idProduct))
            {
                MessageBox.Show("Xóa thành công!!!");
            }
            LoadListFood();
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

        private void btnShowProduct_Click(object sender, EventArgs e)
        {
            LoadListFood();
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
        #endregion

        
        
    }
}
