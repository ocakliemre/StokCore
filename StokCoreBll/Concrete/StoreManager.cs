


using StokCoreData.Abstrack;
using StokCoreModels;
using System.Collections.Generic;

namespace StokCoreBll.Concrete
{
    public class StoreManager : IStore
    {
        private IStoreDal _storeDal;

        public StoreManager(IStoreDal storeDal)
        {
            _storeDal = storeDal;
        }

        public void Add(Store store)
        {
            _storeDal.Add(store);
        }

        public void Delete(int storeId, int companyId)
        {
            _storeDal.Delete(storeId,companyId);
        }

        public Store Get(int storeId, int companyId)
        {
            return _storeDal.Get(storeId, companyId);
        }

        public List<Store> GetAll()
        {
            return _storeDal.GetAll();
        }

        public List<Store> GetAllById(int CompanyId)
        {
            return _storeDal.GetAllById(CompanyId);
        }

        public void Update(Store store)
        {
            _storeDal.Update(store);
        }
    }
}
