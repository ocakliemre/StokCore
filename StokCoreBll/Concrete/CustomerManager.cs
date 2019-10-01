
using System;
using System.Collections.Generic;

using StokCoreData.Abstrack;
using StokCoreModels;

namespace StokCoreBll.Concrete
{
    public class CustomerManager : ICustomer
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id, int companyId)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int Id, int companyId)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllById(int companyId)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
