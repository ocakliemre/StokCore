
using StokCoreData.Abstrack;
using StokCoreModels;
using System.Collections.Generic;


namespace StokCoreBll.Concrete
{
    public class AuthenticationManager : IAuthentication
    {
        private IAuthenticationDal _authenticationDal;

        public AuthenticationManager(IAuthenticationDal authenticationDal)
        {
            _authenticationDal = authenticationDal;
        }

        public Company AuthenticationCompany(Company user)
        {
            Company company = _authenticationDal.AuthenticationCompany(user);
            if (company != null)
            {
                return company;
            }

            else
            {
                return null;
            }
        }

        public Staff AuthenticationStaff(Staff user)
        {
            throw new System.NotImplementedException();
        }
    }
}