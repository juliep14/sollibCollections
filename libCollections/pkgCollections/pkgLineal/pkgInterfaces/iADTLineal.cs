using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iADTLineal<T> where T : IComparable<T>
    {
        #region Getters
        int opGetLength();
        #endregion
        #region Query
        int opFind(T prmItem);
        bool opExists(T prmItem);
        bool ItsEmpty();
        bool ItsValid(int prmIndex);
        bool opItsOrderedAscending();
        bool opItsOrderedDescending();
        #endregion
        #region Serialize/Deserialize
        
        T[] opToArray();
        string opToString();
        bool opToItems(T[] prmItems);
        bool opToItems(T[] prmItems, int prmItemsCount);
        #endregion
        #region CRUD
        bool opModify(int prmIdx, T prmItem);
        bool opRetrieve(int prmIdx, ref T prmItem);
        #endregion


    }
}