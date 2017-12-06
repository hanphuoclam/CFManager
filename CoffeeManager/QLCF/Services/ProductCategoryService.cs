using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Services
{
    public class ProductCategoryService : IProductCategoryService<ProductCategory>
    {
        private IProductCategoryRepository<ProductCategory> _repository;
        public ProductCategoryService(IProductCategoryRepository<ProductCategory> repository)
        {
            this._repository = repository;
        }
        public bool AddProductCategory_S(ProductCategory ProCategory)
        {
            if (_repository.AddProductCategory(ProCategory))
                return true;
            return false;
        }

        public bool DeleteProductCategory_S(int id)
        {
            if (_repository.DeleteProductCategory(id))
                return true;
            return false;
        }

        public bool EditProductCategory_S(ProductCategory ProCategory)
        {
            if (_repository.EditProductCategory(ProCategory))
                return true;
            return false;
        }

        public IEnumerable GetAll_S()
        {
            return _repository.GetAll();
        }

        public ProductCategory GetCategoryById_S(int id)
        {
            return _repository.GetCategoryById(id);
        }
    }
}
