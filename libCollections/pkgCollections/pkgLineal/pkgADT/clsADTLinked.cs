using libCollections.pkgCollections.pkgLineal.pkgInterfaces;
using libCollections.pkgCollections.pkgNodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCollections.pkgCollections.pkgLineal.pkgADT
{
    class clsADTLinked<T> : clsADTLineal<T>, iADTLinked<T> where T : IComparable<T>
    {
        #region Attributes
        protected libCollections.pkgCollections.pkgNodes.clsLinkedNode<T> attFirst = null;
        protected libCollections.pkgCollections.pkgNodes.clsLinkedNode<T> attMiddle = null;
        protected libCollections.pkgCollections.pkgNodes.clsLinkedNode<T> attLast = null;
        #endregion
        #region Operations
        #region Builders
        protected clsADTLinked() { }
        #endregion
        #region Getters
        public clsLinkedNode<T> opGetFirst()
        {
            throw new NotImplementedException();
        }
        public clsLinkedNode<T> opGetLast()
        {
            throw new NotImplementedException();
        }
        public clsLinkedNode<T> opGetMiddle()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Setters
        public bool opSetFirst(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetLast(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        public bool opSetMiddle(clsLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Iterator
        public override bool opGo(int prmIdx)
        {
            if (!opIsValid(prmIdx)) return false;
            if (prmIdx < attLength / 2)
                opGoFirst();
            else opGoMiddle();
            while (attCurrentIdx < prmIdx)
                opGoNext();
            return true;

        }
        public override bool opToItems(T[] prmArray)
        {
            if (prmArray == null) return false;
            if (prmArray.Length == 0) return false;          
            attFirst = new clsLinkedNode<T>(prmArray[0]);
            attMiddle = attFirst;
            attLast = attFirst;
            clsLinkedNode<T> varPreviousNode = attFirst;
            clsLinkedNode<T> varCurrentNode = null;
            for (int varIdx = 1; varIdx < prmArray.Length; varIdx++)
            {
                varCurrentNode = new clsLinkedNode<T>(prmArray[varIdx]);
                varPreviousNode.opSetNext(varCurrentNode);
                clsLinkedNode<T> varCurrentNode = new clsLinkedNode<T>(prmArray[varIdx]);
                varPreviousNode.opSetNext(varCurrentNode);
                if (varIdx == (prmArray.Length / 2))
                    attMiddle = varCurrentNode;
            }
                
                attLast = varCurrentNode;
            return true;
                }

        #endregion
        #endregion
    }
}