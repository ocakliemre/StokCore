﻿using StokCoreData.Abstrack;
using StokCoreModels;
using StokData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreData.Concrete.EntityFramework
{
    public class EfStaffDal : IStaffDal
    {
        private InventoryManagement _contexDb; 

        public EfStaffDal()
        {
            _contexDb  = new InventoryManagement();
        }

        public void Add(Staff staff)
        {
            _contexDb.Staffs.Add(staff);
            _contexDb.SaveChanges();
        }

        public int Delete(int Id, int companyId)
        {
            //Tüm delete işlemlerine ugulancak staff url erişimi engelemek için companyId Session dan geliyor
            Staff staff = _contexDb.Staffs.FirstOrDefault(s => s.Id == Id && s.CompanyId == companyId);
            if (staff != null)
            {
                _contexDb.Staffs.Remove(staff);
                int events = _contexDb.SaveChanges();
                return events;
            }
            else
            {
                int events = 0;
                return events;
            }
           
        }

       

        public Staff Get(int Id, int companyId)
        {
            return _contexDb.Staffs.FirstOrDefault(s => s.Id == Id && s.CompanyId == companyId );
        }

        public List<Staff> GetAll()
        {
         return _contexDb.Staffs.ToList();
        }

        public List<Staff> GetAllById(int companyId)
        {
            return _contexDb.Staffs.Where(s => s.CompanyId == companyId).ToList();
        }

        public int IsActive(int Id, int companyId)
        {
            Staff StaffUp = _contexDb.Staffs.FirstOrDefault(s => s.Id == Id && s.CompanyId == companyId);
            StaffUp.IsActive = false;
            return _contexDb.SaveChanges();
        }

        public void Update(Staff staff)
        {
            Staff StaffUp = _contexDb.Staffs.FirstOrDefault(s => s.Id == staff.Id);
            StaffUp.Name = staff.Name;
            StaffUp.Surname = staff.Surname;
            StaffUp.Username = staff.Username;
            StaffUp.Task = staff.Task;
            StaffUp.Password = staff.Password;
            StaffUp.Phone = staff.Phone;
            StaffUp.Email = staff.Email;
            StaffUp.Department = staff.Department;

            _contexDb.SaveChanges();

        }
    }
}
