using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{

    public interface IProductImages
    {

        void Add(ProductImage productImg);

        void Delete(int Id);

        void Update(ProductImage productImg);

        List<ProductImage> GetAll();
        ProductImage Get(int Id);
    }
}
