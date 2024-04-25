using libCollections.pkgCollections.pkgLineal.pkgADT;
using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgVector
{
    public class clsVectorList<T> : clsADTVector<T>, iList<T> where T : IComparable<T>
    {
        #region Attributes

        #endregion
        #region Builders
        public clsVectorList()
        {
            attItsFlexible = false;
            attItems = new T[100];
            attLength = 0;

        }
        public clsVectorList(int prmCapacity)
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
        #endregion
        #region CRUDs
        public bool opAdd(T prmItem)
        {
            if (attLength == attTotalCapacity)
            {
                return false;
            }
            else
            {
                attItems[attLength] = prmItem;  
                attLength++;                    
                return true;
            }
        }

        public bool opAdd(ref T prmItem)
        {
            throw new NotImplementedException();
        }

        public bool opExists(ref T prmItem)
        {
            throw new NotImplementedException();
        }

        public int opFind(ref T prmItem)
        {
            for (int i = 0; i < attLength; i++)
            {
                if (attItems[i].CompareTo(prmItem) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool opInsert(ref int Idx, T prmItem)
        {
            throw new NotImplementedException();
        }

        public bool opInsert(int Idx, T prmItem)
        {
            if (attLength == attTotalCapacity) return false;
            for (int i = 0; i < attLength - Idx; i++)
            {
                attItems[attLength - i] = attItems[attLength - (i + 1)];
            }
            attItems[Idx] = prmItem;
            attLength++;
            return true;
        }
        #endregion
        #region Query
        public bool opModify(int Idx, T prmItem)
        {
            if (Idx >= attLength) return false;
            attItems[Idx] = prmItem;
            return true;
        }

        public bool opRemove(int Idx, ref T prmItem)
        {
            if (attLength == 0) return false;
            prmItem = attItems[Idx];
            for (int j = Idx; j < attLength - 1; j++)
            {
                attItems[j] = attItems[j + 1];
            }
            attLength--;
            return true;

        }

        public bool opRemove(int ldx, T prmItem)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}