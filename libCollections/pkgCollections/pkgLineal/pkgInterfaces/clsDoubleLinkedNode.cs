﻿using libCollections.pkgCollections.pkgNodes;
using libCollections.pkgCollections.pkgNodes.pkgIntefraces;
using System;

namespace libCollections.pkgCollections.pkgLineal.pkgInterfaces
{
    public class clsDoubleLinkedNode<T> : clsNode<T>, iDoubleLinkedNode<T> where T : IComparable<T>
    {
        #region Attributes
        public clsDoubleLinkedNode<T> attNext;
        public clsDoubleLinkedNode<T> attPrevious;
        #endregion
        #region Operations
        #region Builders
        public clsDoubleLinkedNode() { }
        public clsDoubleLinkedNode(T prmItem) { }
        #endregion
        #region Getters
        public clsDoubleLinkedNode<T> opGetNext()
        {
            throw new NotImplementedException();
        }
        public clsDoubleLinkedNode<T> opGetPrevious()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Setters
        public bool opSetNext(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }

        public bool opSetNext(pkgNodes.clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }

        public bool opSetPrevious(clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }

        public bool opSetPrevious(pkgNodes.clsDoubleLinkedNode<T> prmNode)
        {
            throw new NotImplementedException();
        }

        pkgNodes.clsDoubleLinkedNode<T> iDoubleLinkedNode<T>.opGetNext()
        {
            throw new NotImplementedException();
        }

        pkgNodes.clsDoubleLinkedNode<T> iDoubleLinkedNode<T>.opGetPrevious()
        {
            throw new NotImplementedException();
        }
        #endregion
        #endregion
    }
}