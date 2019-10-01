using StokCoreModels;

using System.Collections.Generic;

namespace StokCoreData.Abstrack
{
    public interface IStaffDal
    {
        List<Staff> GetAll();
       
        List<Staff> GetAllById(int companyId);
        Staff Get(int Id,int companyId);
        void Add(Staff staff);
        int Delete(int Id, int companyId);
        void Update(Staff staff);
        int IsActive(int Id, int companyId);

    }
}
