using libCollections.pkgCollections.pkgLineal.pkgADT;
using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using System;


namespace libCollections.pkgCollections.pkgLineal.pkgDoubleLinked
{
    public class clsDoubleLinkedList<T> : clsADTDoubleLinked<T>, iList<T> where T : IComparable<T>
    {
        public bool opAdd(ref T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opInsert(ref int Idx, T prmItem)
        {
            throw new NotImplementedException();
        }
        public bool opRemove(ref int Idx, T prmItem)
        {
            throw new NotImplementedException();
        }
    }
}