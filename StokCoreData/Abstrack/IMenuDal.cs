using StokCoreModels;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokCoreData.Abstrack
{
    public interface IMenuDal
    {
        List<Menu> GetAll();

        void Add(Menu menu);

        void Delete(int Id);

    }
}
