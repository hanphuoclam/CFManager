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
        #endregion

        #region Events
        private void txtNameProduct_TextChanged(object sender, EventArgs e)
        {
            if(dgvListProduct.SelectedCells.Count > 0)
            {
                //int id = (int)dgvListProduct.SelectedCells[0].OwningRow.Cells["id"].Value;
                //MessageBox.Show(id.ToString());
            }
        }

        #endregion


    }
}
