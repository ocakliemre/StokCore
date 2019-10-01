using StokCoreModels;

using System.Collections.Generic;

namespace StokCoreData.Abstrack
{
    public interface ICustomerDal
    {
        void Add(Customer customer);
        void Delete(int Id, int companyId);
        void Update(Customer customer);

        Customer Get(int Id,int companyId);
        List<Customer> GetAll(int Id);
        List<Customer> GetAllById(int companyId);
    }
}
