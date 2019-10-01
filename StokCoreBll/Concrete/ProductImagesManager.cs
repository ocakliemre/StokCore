

using StokCoreData.Abstrack;
using StokCoreModels;
using System.Collections.Generic;


namespace StokCoreBll.Concrete
{
    public class ProductImagesManager : IProductImages
    {
       private IProductImagesDal productImgDal;

        public ProductImagesManager(IProductImagesDal productImgDal)
        {
            this.productImgDal = productImgDal;
        }

        public void Add(ProductImage productImg)
        {
            productImgDal.Add(productImg);
        }

        public void Delete(int Id)
        {
            productImgDal.Delete(Id);

        }

        public List<ProductImage> GetAll()
        {
            return productImgDal.GetAll();
        }

        public ProductImage Get(int Id)
        {
           return productImgDal.Get(Id);
        }

        public void Update(ProductImage productImg)
        {
            productImgDal.Update(productImg);
        }
    }
}
