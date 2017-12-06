using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain
{
    public interface IProductRepository <P> where P :Product
    {
        bool AddProduct(P product);
        bool EditProduct(P product);
        bool DeleteProduct(int id);
        IEnumerable<P> GetAll();
        IEnumerable<P> GetProductByIdCategory(int idCategory);
        P GetProductById(int id);
    }
}
