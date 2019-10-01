

using StokCoreModels;

namespace StokCoreData.Abstrack
{
    public interface IAuthenticationDal
    {
        Company AuthenticationCompany(Company user);
        Staff AuthenticationStaff(Staff user);
    }
}
