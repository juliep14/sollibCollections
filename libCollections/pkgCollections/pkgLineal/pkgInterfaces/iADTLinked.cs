using libCollections.pkgCollections.pkgNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgInterfaces
{
    public interface iADTLinked<T> where T : IComparable<T>
    {
        #region Operations
        #region Getters
        clsLinkedNode<T> opGetFirst();
        clsLinkedNode<T> opGetMiddle();
        clsLinkedNode<T> opGetLast();
        #endregion
        #region Setters
        bool opSetFirst(clsLinkedNode<T> prmNode);
        bool opSetMiddle(clsLinkedNode<T> prmNode);
        bool opSetLast(clsLinkedNode<T> prmNode);
        #endregion 
        #endregion
    }
}