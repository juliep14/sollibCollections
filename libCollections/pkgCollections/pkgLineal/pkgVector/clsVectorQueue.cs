using libCollections.pkgCollections.pkgLineal.pkgADT;
using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorQueue<T> : clsADTVector<T>, iQueue<T> where T : IComparable<T>
    {
        #region Builders
        public clsVectorQueue()
        {
            attItsFlexible = false;
            attItems = new T[100];
            attLength = 0;
            attTotalCapacity = 100;
        }

        public clsVectorQueue(int prmCapacity)
        {
            try
            {
                if (prmCapacity < 0)
                {
                    prmCapacity = 100;
                    attTotalCapacity = 100;
                }
                if (prmCapacity == 0)
                {
                    prmCapacity = 100;
                    attTotalCapacity = 100;
                    attGrowingFactor = 100;
                }
                if (prmCapacity == attMaxCapacity)
                {
                    prmCapacity = attMaxCapacity;
                    attTotalCapacity = attMaxCapacity;
                    attGrowingFactor = 0;
                }
                if (prmCapacity == (attMaxCapacity - 1))
                {
                    attGrowingFactor = 1;
                    attTotalCapacity = (attMaxCapacity - 1);
                }

                if (attLength < 0) attLength = 0;
                attItems = new T[prmCapacity];
                attTotalCapacity = prmCapacity;
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
        #endregion

        #region CRUDs

        public bool opPush(T prmItem)
        {
            if (attLength == attTotalCapacity)
            {
                return false;
            }
            else
            {
                attLength++;
                attItems[attLength - 1] = prmItem;
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

        public bool opPeek(ref T prmItem)
        {
            if (attLength == 0)
            {
                prmItem = default;
                return false;
            }
            else
            {
                prmItem = attItems[attLength - 1];
                return true;
            }
        }
        #endregion
    }
}
