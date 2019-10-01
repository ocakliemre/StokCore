using System.Collections.Generic;
using StokCoreData.Abstrack;
using StokCoreModels;
using System;

namespace StokCoreBll.Concrete
{
    public class MenuManager : IMenu
    {
      private IMenuDal menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            this.menuDal = menuDal;
        }

        public void Add(StokCoreModels.Menu menu)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public List<StokCoreModels.Menu> GetAll()
        {
            return menuDal.GetAll();
        }
    }
}
