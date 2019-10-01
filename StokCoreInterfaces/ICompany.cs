using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{
   public interface ICompany
    {
        List<Company> GetAll();
        Company Get(int companyId);
        bool Add(Company company);
        void Delete(int companyId);
        void Update(Company company);

    }
}
