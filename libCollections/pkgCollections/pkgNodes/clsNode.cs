using libCollections.pkgCollections.pkgNodes.pkgIntefraces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgNodes
{
    public class clsNode<T> : iNode<T> where T : IComparable<T>
    {
        protected T attItem = default;
        protected clsNode()
        {
        }
        public clsNode(T attItem)
        {
        }
        public T opGetItem()
        {
            return attItem;
        }
        public bool opSetItem(T prmContent)
        {
            return false;
        }
    }
}