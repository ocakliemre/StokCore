using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{
    
   public interface ICompanyAddress
    {
      
        void Add(CompanyAddress companyAddress);
    
        void Delete(int CompanyId);
        
        void Update(CompanyAddress companyAddress);
        List<CompanyAddress> GetAll();
        CompanyAddress Get(int CompanyId);
    }
}
