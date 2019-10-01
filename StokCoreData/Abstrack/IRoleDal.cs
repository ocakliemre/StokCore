using StokCoreModels;

using System.Collections.Generic;

namespace StokCoreData.Abstrack
{
  public interface IRoleDal
    {
        Role GetRole(string Username);

        void Add(Role role);

        void Delete(int Id, int CompanyId);

    }
}
