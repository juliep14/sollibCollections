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
        #region Builders
        public clsVectorStack(int prmCapacity) : base(prmCapacity)
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
            attGrowingFactor = 100;

        }

        public clsVectorStack()
        {
            attItsFlexible = false;
            attItems = new T[100];
            attLength = 0;
            attTotalCapacity = 100;
        }
        #endregion

        #region CRUDs
        public bool opPeek(ref T prmItem)
        {
           
            if (attLength != 0)
            {
                prmItem = attItems[0];  // Devuelve el primer elemento de la pila
                return true;
            }
            else
            {
                prmItem = default;
                return false;
            }
        }



        public bool opPop(ref T prmItem)
        {
            if (attLength > 0)
            {
                prmItem = attItems[--attLength];
                attItems[attLength] = default;
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
            if (prmItemsCount == attTotalCapacity)
            {
                return false; 
            }
            else
            {
                for (int i = prmItemsCount - 1; i >= 0; i--)
                {
                    attItems[i + 1] = attItems[i];
                }
                attItems[0] = prmItem; 
                prmItemsCount++; 
                attLength++; 
                return true; 
            }
        }



        #endregion




    }
}


    
