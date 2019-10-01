using StokCoreData.Abstrack;
using StokCoreModels;
using StokData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreData.Concrete.EntityFramework
{
    
    public class EfMenuDal : IMenuDal
    {
        private InventoryManagement _contextDb;

        public EfMenuDal()
        {
            _contextDb =   new InventoryManagement();
        }

        public void Add(Menu menu)
        {
            _contextDb.Menus.Add(menu);
        }

        public void Delete(int Id)
        {
            _contextDb.Menus.Remove(_contextDb.Menus.FirstOrDefault(s=> s.Id == Id));

        }

        public List<Menu> GetAll()
        {
            return _contextDb.Menus.ToList();
        }
    }
}
