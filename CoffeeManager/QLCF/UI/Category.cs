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


namespace QLCF.UI
{
    public partial class FormCategory : Form
    {
        private IProductCategoryService<ProductCategory> _serviceProdutCategory;
        public FormCategory()
        {
            InitializeComponent();
            IntData();
            loadListCategory();
            addBindingCategory();
        }


        #region Methods
        void IntData()
        {
            _serviceProdutCategory = new ProductCategoryService(new ProductCategoryRepository());

        }

        void loadListCategory()
        {
            //IEnumerable<ProductCategory> list = _serviceProdutCategory.GetAll_S();
            dgvListCategory.DataSource = _serviceProdutCategory.GetAll_S();
            dgvListCategory.Columns["Products"].Visible = false;
           
            //DataTable data = new DataTable();
            //foreach (ProductCategory item in list)
            //{
            //    DataRow row = data.NewRow();
            //    row["ID"] = item.id;
            //    row["Tên sản phẩm"] = item.name;
            //}
        }

        void addBindingCategory()
        {
            txtNameCategory.DataBindings.Add(new Binding("Text", dgvListCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        void addCategory()
        {
            string nameCategory = txtNameCategory.Text;
            if (_serviceProdutCategory.AddProductCategory_S(new ProductCategory(){ name = nameCategory }))
            {
                MessageBox.Show("Thêm thành công!!!");
            }
            loadListCategory();
        }
        void editCategory()
        {
            string nameCategory = txtNameCategory.Text;
            int idProductCategory = Convert.ToInt32(dgvListCategory.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            if (_serviceProdutCategory.EditProductCategory_S(new ProductCategory(){id = idProductCategory , name = nameCategory }))
            {
                MessageBox.Show("Sửa thành công!!!");
            }
            loadListCategory();

        }
        void deleteCategory()
        {
            int idProductCategory = Convert.ToInt32(dgvListCategory.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            if (_serviceProdutCategory.DeleteProductCategory_S(idProductCategory))
            {
                MessageBox.Show("Xóa thành công!!!");
            }
            loadListCategory();

        }
        #endregion 
        #region events
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            loadListCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            addCategory();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            editCategory();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            deleteCategory();
        }
        #endregion 
    }
}
