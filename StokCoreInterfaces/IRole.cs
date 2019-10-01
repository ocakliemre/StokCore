using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreBll
{
   public interface IRole
    {

        Role GetRole(string Username);

        void Add(Role role);

        void Delete(int Id, int CompanyId);
    }
}
