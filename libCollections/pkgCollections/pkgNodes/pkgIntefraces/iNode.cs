using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgNodes.pkgIntefraces
{
    public interface iNode<T> where T : IComparable<T>
    {
        T opGetItem();
        bool opSetItem(T prmContent);
    }
}