using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLCF.Domain
{
    public interface IProductService <P> where P : Product
    { 
        bool AddProduct_S(P product);
        bool EditProduc_St(P product);
        bool DeleteProduct_S(int id);
        IEnumerable GetAll_S();
        IEnumerable GetProductByIdCategory_S(int idCategory);
        P GetProductById_S(int id);
        IEnumerable ListProductforShow_S();
        IEnumerable listSearchPro_S(string searchStr);
    }
}
