using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Repository
{
    public class ProductCategoryRepository : IProductCategoryRepository<ProductCategory>
    {
#region Singleton
        //private static ProductCategoryRepository instance;
        //public static ProductCategoryRepository Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new ProductCategoryRepository();
        //        return instance;
        //    }
        //    private set => instance = value;
        //}
        #endregion
        private Domain.CFMEntities db = CFMEntities.Instance;
        public bool AddProductCategory(ProductCategory ProCategory)
        {
            try
            {
                db.ProductCategories.Add(ProCategory);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteProductCategory(int id)
        {
            ProductCategory productCategory = GetCategoryById(id);
            try
            {
                db.ProductCategories.Remove(productCategory);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool EditProductCategory(ProductCategory ProCategory)
        {
            ProductCategory OriginalproductCategory = GetCategoryById(ProCategory.id);
            try
            {
                db.Entry(OriginalproductCategory).CurrentValues.SetValues(ProCategory);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return db.ProductCategories.ToList();
        }

        public ProductCategory GetCategoryById(int id)
        {
            return db.ProductCategories.FirstOrDefault(c => c.id == id);
        }
    }
}
