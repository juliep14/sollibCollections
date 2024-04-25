using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iList<T> where T:IComparable<T>
    {
        #region CRUDs
        bool opAdd(T prmItem);
        bool opInsert(int ldx, T prmItem);
        bool opRemove(int ldx,ref T prmItem);
        #endregion
    }
}
