using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgADT
{
    public class clsADTDoubleLinked<T> : clsADTLineal<T>, iADTDoubleLinked<T> where T : IComparable<T>
    {
        #region Attributes
        protected clsDoubleLinkedNode<T> attFirst;
        protected clsDoubleLinkedNode<T> attFirstQuarter;
        protected clsDoubleLinkedNode<T> attMiddle;
        protected clsDoubleLinkedNode<T> attLastQuarter;
        protected clsDoubleLinkedNode<T> attLast;
        #endregion
        #region Operations
        #region Builders
        protected clsADTDoubleLinked()
        {
        }
        #endregion
        #region Getters
        public clsDoubleLinkedNode<T> opGetFirst()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetLast()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetMiddle()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Setters
        public bool opSetFirst(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetLast(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetMiddle(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Iterators

        #endregion
        #region Serialize/Deserialize
        public override bool opToItems(T[] prmArray)
        {
            if (prmArray == null) return false;
            if (prmArray.Length == 0) return false;
            if (prmArray.Length > attMaxCapacity) return false;
            attFirst = new clsDoubleLinkedNode<T>(prmArray[0]);
            attMiddle = attFirst;
            clsDoubleLinkedNode<T> varPreviousNode = attFirst;
            clsDoubleLinkedNode<T> varCurrentNode = attFirst;
            for (int varIdx = 1; varIdx < prmArray.Length; varIdx++)
            {
                varCurrentNode = new clsDoubleLinkedNode<T>(prmArray[varIdx]);
                varPreviousNode.opSetNext(varCurrentNode);
                if (varIdx == prmArray.Length / 4) attFirstQuarter = varCurrentNode;
                if (varIdx==prmArray.Length/2) attMiddle = varCurrentNode;
                if (varIdx == (prmArray.Length / 2) + prmArray.Length / 4) attLastQuarter = varCurrentNode;
            }
            attLast = varCurrentNode;
            return true;
        }

        #endregion
        #endregion
    }
}