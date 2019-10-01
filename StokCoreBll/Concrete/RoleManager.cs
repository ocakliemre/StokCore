

using StokCoreData.Abstrack;
using StokCoreModels;
using System.Collections.Generic;

namespace StokCoreBll.Concrete
{
    public class RoleManager : IRole
    {
        private IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Add(Role role)
        {
            _roleDal.Add(role);
        }

        public void Delete(int Id, int CompanyId)
        {
            _roleDal.Delete(Id, CompanyId);
        }

        public Role GetRole(string Username)
        {
            return _roleDal.GetRole(Username);
        }
    }
}
