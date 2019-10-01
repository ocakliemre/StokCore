using StokCoreModels;


namespace StokCoreBll
{
    
    public interface IAuthentication
    {



        Company AuthenticationCompany(Company user);
  
        Staff AuthenticationStaff(Staff user);

    }
}