using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;
using System.Collections;
using System.Linq.Expressions;
using System.Data;

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

        public IEnumerable ListProductforShow()
        {
            IEnumerable<Product> list = GetAll();
            //DataTable data;
            //data.Columns.Add()
            return GetBy(f => f.id > 0, n => new { n.id, n.name, n.idCategory, n.price, n.inventory });
            
        }
        public IEnumerable<U> GetBy<U>(Expression<Func<Product, bool>> exp, Expression<Func<Product, U>> columns)
        {
            return db.Products.Where<Product>(exp).Select<Product, U>(columns);
        }
    }
}
