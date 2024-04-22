using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgInterfaces
{
        public interface iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Getters
        clsDoubleLinkedNode<T> opGetFirst();
        clsDoubleLinkedNode<T> opGetMiddle();
        clsDoubleLinkedNode<T> opGetLast();
        #endregion
        #region Setters
        bool opSetFirst(clsDoubleLinkedNode<T> prmNode);
        bool opSetMiddle(clsDoubleLinkedNode<T> prmNode);
        bool opSetLast(clsDoubleLinkedNode<T> prmNode);
        #endregion
    }
}