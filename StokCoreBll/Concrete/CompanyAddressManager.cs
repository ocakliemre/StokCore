

using System.Collections.Generic;

using StokCoreData.Abstrack;
using StokCoreModels;

namespace StokCoreBll.Concrete
{
    public class CompanyAddressManager : ICompanyAddress
    {
        private  ICompanyAddressesDal _companyAddressesDal;

        public CompanyAddressManager(ICompanyAddressesDal companyAddressesDal)
        {
            _companyAddressesDal = companyAddressesDal;
        }

        public void Add(CompanyAddress companyAddress)
        {
            _companyAddressesDal.Add(companyAddress);
        }

        public void Delete(int CompanyId)
        {
            _companyAddressesDal.Delete(CompanyId);
        }

        public CompanyAddress Get(int CompanyId)
        {
          return  _companyAddressesDal.Get(CompanyId);
        }

        public List<CompanyAddress> GetAll()
        {
            return _companyAddressesDal.GetAll();
        }

        public void Update(CompanyAddress companyAddress)
        {
            
                _companyAddressesDal.Update(companyAddress);
          
          
        }
    }
}
