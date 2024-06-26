﻿using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgIterator
{
    public class clsIterator<T>: iIterator<T> where T: IComparable<T>
    {
        protected int attLength = 0;
        protected int attCurrentIdx;
        protected T attCurrentItem;

        #region Getters
        public int opGetCurrentIdx()
        {
            return attCurrentIdx;
        }

        public int opGetLength()
        {
            return attLength;
        }

        #endregion
        public virtual bool opGo(int prmIdx)
        {
            throw new NotImplementedException();
        }

        public void opGoBack()
        {
            throw new NotImplementedException();
        }

        public bool opGoFirst()
        {
            throw new NotImplementedException();
        }

        public void opGoFoward()
        {
            throw new NotImplementedException();
        }

        public bool opGoLast()
        {
            throw new NotImplementedException();
        }

        public bool opGoMiddle()
        {
            throw new NotImplementedException();
        }

        public bool opGoNext(T[] attItems)
        {
            if (attCurrentIdx < attLength - 1)
            {
                attCurrentIdx++;
                attCurrentItem = attItems[attCurrentIdx];
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool opGoNext()
        {
            throw new NotImplementedException();
        }

        public bool opGoPrevious(T[] attItems)
        {
            if (attCurrentIdx > 0)
            {
                attCurrentIdx--;
                attCurrentItem = attItems[attCurrentIdx];
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool opGoPrevious()
        {
            throw new NotImplementedException();
        }

        public bool opIsThereNext()
        {
            throw new NotImplementedException();
        }

        public bool opIsTherePrevious()
        {
            throw new NotImplementedException();
        }

        public bool opIsValid(int Index)
        {
            throw new NotImplementedException();
        }

        public int opSetCurrentItem(T prmContent)
        {
            throw new NotImplementedException();
        }
    }
}
