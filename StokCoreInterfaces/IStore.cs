using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{
    public interface IStore
    {
        
        List<Store> GetAll();
      
        List<Store> GetAllById(int companyId);
      
        Store Get(int storeId,int companyId);
    
        void Add(Store store);
   
        void Delete(int storeId, int companyId);
        
        void Update(Store store);


    }
}
