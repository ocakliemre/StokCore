using StokCoreModels;

using System.Collections.Generic;


namespace StokCoreData.Abstrack
{
   public interface ICompanyAddressesDal
    {
        void Add(CompanyAddress companyAddress);

        void Delete(int CompanyId);

        void Update(CompanyAddress companyAddress);

        List<CompanyAddress> GetAll();

        CompanyAddress Get(int CompanyId);
    
    }
}
