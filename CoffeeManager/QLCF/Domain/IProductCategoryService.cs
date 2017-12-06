using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QLCF.Domain
{
    public interface IProductCategoryService <P> where P : ProductCategory
    {
        P GetCategoryById_S(int id);
        IEnumerable GetAll_S();
        bool AddProductCategory_S(P ProCategory);
        bool EditProductCategory_S(P ProCategory);
        bool DeleteProductCategory_S(int id);
    }
}
