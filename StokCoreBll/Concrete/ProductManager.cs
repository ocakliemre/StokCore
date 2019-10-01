
using StokCoreData.Abstrack;
using StokCoreModels;
using System.Collections.Generic;

namespace StokCoreBll.Concrete
{
    public class ProductManager : IProduct
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public int Delete(int Id, int companyId)
        {
         int events= _productDal.Delete(Id,companyId);
            return events;
        }

        public Product Get(int productId, int companyId)
        {
            return _productDal.Get(productId,companyId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllById(int CompanyId)
        {
            return _productDal.GetAllById(CompanyId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
