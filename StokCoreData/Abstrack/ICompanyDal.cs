using StokCoreModels;

using System.Collections.Generic;

namespace StokCoreData.Abstrack
{
    public interface ICompanyDal
    {

        List<Company> GetAll();

        Company Get(int companyId);
        Company GetTax(string TaxNumber);
        void Add(Company company);

        void Delete(int companyId);

        void Update(Company company);


    }
}
