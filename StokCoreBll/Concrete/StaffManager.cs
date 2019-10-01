
using StokCoreData.Abstrack;
using StokCoreModels;
using System.Collections.Generic;

namespace StokCoreBll.Concrete
{
  public  class StaffManager : IStaff

    {
        IStaffDal _staffDal;

        public StaffManager(IStaffDal staffDal)
        {
            _staffDal = staffDal;
        }

        public void Add(Staff staff)
        {
            /*Username kontrol yapılacak*/
            _staffDal.Add(staff);
        }

        public int Delete(int Id, int companyId)
        {
           int events= _staffDal.Delete(Id,companyId);
            return events;
        }

        public Staff Get(int Id, int companyId)
        {
            return _staffDal.Get(Id,companyId);
        }

        public List<Staff> GetAll()
        {
           return _staffDal.GetAll();
        }

        public List<Staff> GetAllById(int CompanyId)
        {
            return _staffDal.GetAllById(CompanyId);
        }

        public int IsActivet(int Id, int CompanyId)
        {
            return _staffDal.IsActive(Id, CompanyId);
        }

        public void Update(Staff staff)
        {  /*Username kontrol yapılacak*/
            _staffDal.Update(staff);
        }
    }
}
