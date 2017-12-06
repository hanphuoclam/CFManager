using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.Domain
{
    public interface IProductCategoryRepository <P> where P : ProductCategory
    {
        P GetCategoryById(int id);
        IEnumerable<P> GetAll();
        bool AddProductCategory(P ProCategory);
        bool EditProductCategory(P ProCategory);
        bool DeleteProductCategory(int id);
    }
}
