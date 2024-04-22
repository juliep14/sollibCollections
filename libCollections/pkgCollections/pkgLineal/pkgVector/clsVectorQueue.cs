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
            if (prmCapacity <= 0)
            {
                prmCapacity = 0;
                throw new ArgumentException("La capacidad no puede ser negativa.", nameof(prmCapacity));
            }
            else
            {
                attItems = new T[prmCapacity];
            }
        }
         
        #endregion
        #region CRUDs

        public bool opPush(T prmItem)
        {
            return true;
        }

        public bool opPop(ref T prmItem)
        {
            return true;
        }

        public bool opPeek(ref T prmItem)
        {
            return true;
        }
        #endregion
    }
}
