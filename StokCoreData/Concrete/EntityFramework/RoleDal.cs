using StokCoreData.Concrete.EntityFramework;
using StokCoreData.Abstrack;
using StokCoreModels;

using System.Linq;

using StokCoreData;
using StokData;

namespace StokCoreData.Concrete.EntityFramework
{
    public class RoleDal : IRoleDal
    {
        private InventoryManagement _contexDb;
        public RoleDal()
        {
            _contexDb = new InventoryManagement();
        }
        public void Add(Role role)
        {
            _contexDb.Roles.Add(role);
        }

        public void Delete(int Id, int CompanyId)
        {
            _contexDb.Roles.Remove(_contexDb.Roles.FirstOrDefault(s=> s.Id == Id && s.CompanyId == CompanyId));
        }

        public Role GetRole(string Username)
        {
          return  _contexDb.Roles.FirstOrDefault(s => s.UserName == Username);
        }
    }
}
