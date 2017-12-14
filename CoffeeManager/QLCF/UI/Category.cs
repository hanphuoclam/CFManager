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
            //addBindingCategory();
        }


        #region Methods
        void IntData()
        {
            _serviceProdutCategory = new ProductCategoryService(new ProductCategoryRepository());

        }
        void PaintDGV()
        {//width = 336
            dgvListCategory.Columns[0].HeaderText = "ID";
            dgvListCategory.Columns[1].HeaderText = "Tên danh mục";
            dgvListCategory.Columns[0].Width = 100;
            dgvListCategory.Columns[0].ReadOnly = true;
            dgvListCategory.Columns[1].Width = 236;
            dgvListCategory.Columns[1].ReadOnly = true;
        }
        void loadListCategory()
        {
            dgvListCategory.DataSource = _serviceProdutCategory.GetAll_S();
            dgvListCategory.Columns["Products"].Visible = false;
            addBindingCategory();
            PaintDGV();
        }

        void addBindingCategory()
        {
            txtNameCategory.Clear();
            txtNameCategory.DataBindings.Add(new Binding("Text", dgvListCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        void addCategory()
        {
            string nameCategory = txtNameCategory.Text;
            int idProductCategory = Convert.ToInt32(dgvListCategory.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            ProductCategory temp = _serviceProdutCategory.GetCategoryById_S(idProductCategory);
            if(temp != null)
                if (temp.name == nameCategory)
                    return;
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
            ProductCategory temp = _serviceProdutCategory.GetCategoryById_S(idProductCategory);
            if (temp.name == nameCategory)
                return;
            if (_serviceProdutCategory.EditProductCategory_S(new ProductCategory(){id = idProductCategory , name = nameCategory }))
            {
                MessageBox.Show("Sửa thành công!!!");
            }
            loadListCategory();

        }
        void deleteCategory()
        {
            int idProductCategory = Convert.ToInt32(dgvListCategory.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
            ProductCategory temp = _serviceProdutCategory.GetCategoryById_S(idProductCategory);
            if (MessageBox.Show(String.Format("Bạn có chắc chắn muốn xóa danh mục '{0}' ?", temp.name), "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            if (_serviceProdutCategory.DeleteProductCategory_S(idProductCategory))
            {
                MessageBox.Show("Xóa thành công!!!");
            }
            loadListCategory();

        }
        #endregion 
        #region events

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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
