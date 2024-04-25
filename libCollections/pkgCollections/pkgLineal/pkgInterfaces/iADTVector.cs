using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iADTVector<T> where T : IComparable<T>
    {
        #region Getters
        int opGetTotalCapacity();
        int opGetGrowingFactor();
        int opGetAvailableCapacity();
        #endregion
        #region Setters
        bool opSetGrowingFactor(int prmValue);
        bool opSetTotalCapacity(int prmValue);
        #endregion
        #region Query
        bool opItsFull();
        bool opItsFlexible();
        #endregion

    }
}