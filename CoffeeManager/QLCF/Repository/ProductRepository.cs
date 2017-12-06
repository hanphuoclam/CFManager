using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Repository
{
    public class ProductRepository : IProductRepository<Product>
    {
        #region Singleton
        //private static ProductRepository instance;

        //public static ProductRepository Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new ProductRepository();
        //        return instance;
        //    }
        //    private set => instance = value;
        //}
        #endregion
        private Domain.CFMEntities db = CFMEntities.Instance;
        public bool AddProduct(Product product)
        {
            try
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteProduct(int id)
        {
            Product originalPro = GetProductById(id);
            try
            {
                db.Products.Remove(originalPro);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool EditProduct(Product product)
        {
            Product originalPro = GetProductById(product.id);
            try
            {
                db.Entry(originalPro).CurrentValues.SetValues(product);
                db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
        

        public IEnumerable<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return (from c in db.Products
                    where c.id == id
                    select c).FirstOrDefault();
        }

        public IEnumerable<Product> GetProductByIdCategory(int idCategory)
        {
            return (from c in db.Products
                    where c.idCategory == idCategory
                    select c).ToList();
        }
    }
}
