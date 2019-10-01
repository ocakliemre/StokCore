using StokCoreModels;

using System.Collections.Generic;

namespace StokCoreData.Abstrack
{
    public interface IProductImagesDal
    {
        void Add(ProductImage productImg);
        void Delete(int Id);
        void Update(ProductImage productImg);
        List<ProductImage> GetAll();
        ProductImage Get(int Id);


    }
}
