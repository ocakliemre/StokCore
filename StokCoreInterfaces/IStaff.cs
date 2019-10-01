using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{
 
   public interface IStaff
    {
      
        void Add(Staff staff);
      
        int Delete(int Id, int companyId);
      
      void Update(Staff staff);
      
        List<Staff> GetAll();
      
        List<Staff> GetAllById(int companyId);
      
       Staff Get(int Id,int companyId);
      
        int IsActivet(int Id, int CompanyId);





    }
}
