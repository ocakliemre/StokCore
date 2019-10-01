using StokCoreModels;

using System.Collections.Generic;

namespace StokCoreData.Abstrack
{
    public interface IProductDal
    {
        List<Product> GetAll();
        List<Product> GetAllById(int companyId);
        Product Get(int productId,int companyId);
        void Add(Product product);
        int Delete(int Id, int companyId);
        void Update(Product product);
     
    }
}
