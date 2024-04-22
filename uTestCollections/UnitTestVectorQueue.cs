using libCollections.pkgCollections.pkgLineal.pkgVector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace uTestCollections
{
    [TestClass]
    public class UnitTestVectorQueue
    {
        private clsVectorQueue<int> testMyQueue;
        private int[] testExpectedItems;
        private int testExpectedItem;


        #region Builder Tester
        [TestMethod]
        public void testDefaultConstructor()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testNegativeCapacityConstructor()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>(-1);
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testValidCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(50);
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            CollectionAssert.AreEqual(new int[50], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testZeroCapacityConstructor()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>(0);
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[0], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testBeyondMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyQueue = new clsVectorQueue<int>(clsVectorQueue<int>.opGetMaxCapacity() + 1);
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[clsVectorQueue<int>.opGetMaxCapacity() + 1], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testBehindMaxCapacityConstructor()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>(clsVectorQueue<int>.opGetMaxCapacity() - 1);
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[clsVectorQueue<int>.opGetMaxCapacity() - 1], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testOverFlowCapacityConstructor()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>(int.MaxValue);
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testMaxCapacityConstructor()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>(clsVectorQueue<int>.opGetMaxCapacity());
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            Assert.AreEqual(100, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[int.MaxValue / 16], testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            #endregion
        }
        #endregion
        #region PopTest
        [TestMethod]
        public void testPopWithFullCollection()
        {
            #region Setup
            testMyQueue = new clsVectorQueue<int>();
            testMyQueue.opToItems(new int[4] { 1, 2, 3, 4 });
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyQueue.opPop(ref testExpectedItem));
            Assert.AreEqual(0, testExpectedItem);
            Assert.AreEqual(4, testMyQueue.opGetLength());
            Assert.IsFalse(testMyQueue.opItsOrderedAscending());
            Assert.IsFalse(testMyQueue.opItsOrderedDescending());
            Assert.AreEqual(4, testMyQueue.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyQueue.opToArray());
            Assert.IsFalse(testMyQueue.opItsFlexible());
            Assert.AreEqual(100, testMyQueue.opGetGrowingFactor());
            Assert.AreEqual(3, testMyQueue.opGetAvailableCapacity());
            #endregion
        }
    }

   
    
    #endregion
}
