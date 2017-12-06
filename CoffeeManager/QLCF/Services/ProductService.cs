using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCF.Domain;

namespace QLCF.Services
{
    public class ProductService : IProductService<Product>
    {
        private IProductRepository<Product> _repository;

        public ProductService(IProductRepository<Product> repository)
        {
            this._repository = repository;
        }
        public bool AddProduct_S(Product product)
        {
            if (_repository.AddProduct(product))
                return true;
            return false;
        }

        public bool DeleteProduct_S(int id)
        {
            if (_repository.DeleteProduct(id))
                return true;
            return false;
        }

        public bool EditProduc_St(Product product)
        {
            if (_repository.EditProduct(product))
                return true;
            return false;
        }

        public IEnumerable GetAll_S()
        {
            return _repository.GetAll();
        }

        public IEnumerable GetProductByIdCategory_S(int idCategory)
        {
            return _repository.GetProductByIdCategory(idCategory);
        }

        public Product GetProductById_S(int id)
        {
            return _repository.GetProductById(id);
        }
    }
}
