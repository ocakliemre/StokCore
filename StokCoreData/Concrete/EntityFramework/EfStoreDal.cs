using StokCoreData.Abstrack;
using StokCoreData.Concrete.EntityFramework;
using StokCoreModels;
using StokData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreData.concrete.EntityFramework
{
    public class EfStoreDal : IStoreDal
    {
        private InventoryManagement _contexDb;

        public EfStoreDal()
        {
            _contexDb   = new InventoryManagement();
        }

        public void Add(Store store)
        {
            _contexDb.Stores.Add(store);
            _contexDb.SaveChanges();
                
                
        }

        public void Delete(int storeId,int companyId)
        {/* boş gelen Store şuan hata verir*/
            _contexDb.Stores.Remove(_contexDb.Stores.FirstOrDefault(s => s.Id == storeId && s.CompanyId == companyId));
        }

      

        public Store Get(int storeId, int companyId)
        {
            return _contexDb.Stores.FirstOrDefault(s => s.Id == storeId && s.CompanyId==companyId);
        }

        public List<Store> GetAll()
        {
            return _contexDb.Stores.ToList();
        }

        public List<Store> GetAllById(int companyId)
        {
          return  _contexDb.Stores.Where(s => s.CompanyId == companyId).ToList();
        }

        public void Update(Store store)
        {
           Store storeUp = _contexDb.Stores.FirstOrDefault(s => s.Id == store.Id);

            storeUp.Name = store.Name;
            storeUp.Address = store.Address;
            _contexDb.SaveChanges();
        }
    }
}
