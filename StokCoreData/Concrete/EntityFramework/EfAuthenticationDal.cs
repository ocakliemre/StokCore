using StokCoreData.Abstrack;
using StokCoreData.Concrete.EntityFramework;
using System.Linq;
using StokCoreModels;
using StokData;

namespace StokCoreData.Concrete
{
    public class EfAuthenticationDal : IAuthenticationDal
    {
        private InventoryManagement _contexDb;

        public EfAuthenticationDal()
        {
            _contexDb = new InventoryManagement();
        }

        public Company AuthenticationCompany(Company user)
        {
          return  _contexDb.Companies.FirstOrDefault(s => s.TaxNumber == user.TaxNumber && s.Password == user.Password && s.IsActive == true);
        }

        public Staff AuthenticationStaff(Staff user)
        {
            return _contexDb.Staffs.FirstOrDefault(s => s.Email == user.Email && s.Password == user.Password && s.IsActive == true);
        }
    }
}