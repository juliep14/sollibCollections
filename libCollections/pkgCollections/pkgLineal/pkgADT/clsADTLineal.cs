using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using libCollections.pkgCollections.pkgLineal.pkgIterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgADT
{

    public class clsADTLineal<T> : clsIterator<T>, iADTLineal<T> where T : IComparable<T>
    {
        #region Attributes
        protected static int attMaxCapacity = int.MaxValue / 16;
        protected bool attItsOrderedAscending = false;
        protected bool attItsOrderedDescending = false;
        protected int prmItemsCount = 0;
        protected T[] prmArray = new T[100];
        public clsADTLineal()
        {

        }
        public clsADTLineal(int attLength)
        {
            prmArray = new T[attLength];
            attItsOrderedAscending = false;
            attItsOrderedDescending = false;
            prmItemsCount = 0;
        }
        #endregion
        #region Getters
        #endregion
        #region Serialize/Deserialize
        public virtual T[] opToArray()
        {
            throw new NotImplementedException();
        }
        public string opToString()
        {
            throw new NotImplementedException();
        }
        public virtual bool opToItems(T[] prmArray)
        {
            throw new NotImplementedException();
        }

        #endregion
        #region CRUDs
        public virtual bool opModify(int prmIdx, T prmItem)
        {
            if (prmIdx >= 0 && prmIdx < prmItemsCount)
            {
                prmArray[prmIdx] = prmItem;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool opRetrieve(int prmIdx, ref T prmItem)
        {
            if (prmIdx >= 0 && prmIdx < prmItemsCount)
            {
                prmItem = prmArray[prmIdx];
                return true;
            }
            else
            {
                prmItem = default(T);
                return false;
            }
        }
        public bool opReverse()
        {
            prmArray.Reverse();
            return true;
        }
        public int opFind(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opExists(T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opItsEmpty()
        {
            throw new NotImplementedException();
        }
        public bool opItsValid(int prmIndex)
        {
            throw new NotImplementedException();
        }
        public bool opItsOrderedAscending()
        {
            attLength = prmArray.Length;
            for (int i = 1; i < attLength; i++)
            {
                if (prmArray[i].CompareTo(prmArray[i - 1]) <= 0)
                {
                    attItsOrderedDescending = false;
                    return attItsOrderedDescending;
                }
            }
            attItsOrderedDescending = true;
            return attItsOrderedDescending;
        }
 
        public bool opItsOrderedDescending()
        {
            attLength = prmArray.Length;
            for (int i = 1; i < attLength; i++)
            {
                if (prmArray[i].CompareTo(prmArray[i - 1]) >= 0)
                {
                    attItsOrderedDescending = false;
                    return attItsOrderedDescending;
                }
            }
            attItsOrderedDescending = true;
            return attItsOrderedDescending;
        }
        public bool opItsValid()
        {
            throw new NotImplementedException();
        }

        public bool ItsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool ItsValid(int prmIndex)
        {
            throw new NotImplementedException();
        }
        //public bool opSetCapacity(int prmValue)
        //{
        //    attTotalCapacity = prmValue;
        //   return true;
        //}
        #endregion
        #region Iterator
        public override bool opGo(int prmIdx)
        {
            if (!opItsValid(prmIdx)) return false;
            if (prmIdx < attLength / 2)
                opGoFirst();
            else opGoMiddle();
            while (attCurrentIdx < prmIdx)
                opGoNext();
            return true;
        }
        public bool opToItems(T[] prmItems, int prmItemsCount)
        {
            throw new NotImplementedException();
        }



        #endregion
    }
}