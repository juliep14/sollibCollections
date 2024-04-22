using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgNodes.pkgIntefraces
{
    public interface iLinkedNode<T> where T : IComparable<T>
    {
        #region Getters
        clsLinkedNode<T> opGetNext();
        #endregion
        #region Setters
        bool opSetNext(clsLinkedNode<T> prmNode);
        #endregion
    }
}