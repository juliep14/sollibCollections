using libCollections.pkgCollections.pkgLineal.pkgADT;
using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgLinked
{
    public class clsLinkedList<T> : clsADTLinked<T>, iList<T> where T : IComparable<T>
    {
        public bool opAdd(ref T prmItem)
        {
            throw new NotImplementedException();
        }

        public bool opAdd(T prmItem)
        {
            throw new NotImplementedException();
        }

        public bool opInsert(ref int Idx, T prmItem)
        {
            throw new NotImplementedException();
        }

        public bool opInsert(int ldx, T prmItem)
        {
            throw new NotImplementedException();
        }

        public bool opRemove(ref int Idx, T prmItem)
        {
            throw new NotImplementedException();
        }

        public bool opRemove(int ldx, ref T prmItem)
        {
            throw new NotImplementedException();
        }
    }
}