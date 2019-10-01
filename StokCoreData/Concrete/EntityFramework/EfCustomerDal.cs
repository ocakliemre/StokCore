﻿using StokCoreData.Concrete.EntityFramework;
using StokCoreData.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StokCoreModels;
using StokData;

namespace StokCoreData.Concrete.EntityFramework
{
    public class EfCustomerDal : ICustomerDal
    {
        private InventoryManagement _contexDb;

        public EfCustomerDal()
        {
            _contexDb = new InventoryManagement();
        }

        public void Add(Customer customer)
        {
            _contexDb.Customers.Add(customer);
            _contexDb.SaveChanges();
        }

        public void Delete(int Id,int companyId)
        {
            /* boş gelen Customer şuan hata verir*/
            _contexDb.Customers.Remove(_contexDb.Customers.FirstOrDefault(s => s.Id == Id && s.CompanyId==  companyId));
            _contexDb.SaveChanges();
        }

       

        public Customer Get(int Id, int companyId)
        {
            return _contexDb.Customers.FirstOrDefault(s => s.Id == Id && s.CompanyId == companyId);
        }

        public List<Customer> GetAll(int Id)
        {
            return _contexDb.Customers.ToList();
        }

        public List<Customer> GetAllById(int companyId)
        {
            return _contexDb.Customers.Where(s => s.CompanyId == companyId).ToList();
        }

        public void Update(Customer customer)
        {
            Customer Upcustomer = _contexDb.Customers.FirstOrDefault(s => s.Id == customer.Id);
            Upcustomer.Name = customer.Name;
            Upcustomer.Surname = customer.Surname;
            Upcustomer.Taxnumber = customer.Taxnumber;
            _contexDb.SaveChanges();
        }
    }
}
