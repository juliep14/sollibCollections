using libCollections.pkgCollections.pkgLineal.pkgADT;
using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using libCollections.pkgCollections.pkgLineal.pkgIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorStack<T> : clsADTVector<T>, iStack<T> where T : IComparable<T>
    {
        #region CRUDs
        public bool opPeek(ref T prmItem)
        {
            if (attLength == 0)
            {
                prmItem = default;
                return false;
            }
            else
            {
                prmItem = attItems[0];
                return true;
            }

        }

        public bool opPop(ref T prmItem)
        {
            if (attLength != 0)
            {
                attLength--;
                prmItem = attItems[0];
                for (int i = 0; i < attLength; i++)
                {
                    attItems[i] = attItems[i + 1];
                }

                return true;
            }
            else
            {
                prmItem = default;
                return false;
            }

        }

        public bool opPush(T prmItem)
        {
            if (attLength < attTotalCapacity && attLength == 0)
            {
                attItems[attLength] = prmItem;
                attLength += 1;
                return true;
            }
            else if (attLength < attTotalCapacity)
            {
                for (int j = attLength; j > 0; j--)
                {
                    attItems[j] = attItems[j - 1];

                }
                attItems[0] = prmItem;
                attLength += 1;
                return true;
            }
            return false;
        }

        #endregion

        #region Builders
        public clsVectorStack(int prmCapacity) : base(prmCapacity)
        {
            //attItems = new T[prmCapacity];
            try
            {
                if (attLength < 0) attLength = 0;
                attItems = new T[prmCapacity];
            }
            catch
            {
                attTotalCapacity = 100;
                attMaxCapacity = int.MaxValue / 16;
                attItems = new T[100];
                attItsFlexible = false;
                attGrowingFactor = 100;
            }
        }

        public clsVectorStack()
        {

        }
        #endregion

    }
}


    
