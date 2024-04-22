using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iIterator<T> where T: IComparable<T>
    {
        #region Movement
        bool opGoFirst();
        bool opGoPrevious();
        bool opGoMiddle();
        bool opGoNext();
        bool opGoLast();
        bool opGo(int Idx);
        void opGoBack();
        void opGoFoward(); 
        #endregion
        #region Getters
        int opGetLength();
        int opGetCurrentIdx();
        #endregion
        #region Setters
        int opSetCurrentItem(T prmContent);
        #endregion
        #region Query
        bool opIsValid(int Index);
        bool opIsThereNext();
        bool opIsTherePrevious();
        #endregion
    }
}
