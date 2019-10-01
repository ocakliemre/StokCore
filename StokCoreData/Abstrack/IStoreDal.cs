using StokCoreModels;

using System.Collections.Generic;

namespace StokCoreData.Abstrack
{
    public interface IStoreDal
    {
        List<Store> GetAll();
        List<Store> GetAllById(int companyId);
        Store Get(int storeId,int companyId);
        void Add(Store store);
        void Delete(int storeId, int companyId);
        void Update(Store store);

    }
}
