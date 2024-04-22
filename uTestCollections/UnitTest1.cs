using libCollections.pkgCollections.pkgLineal.pkgLinked;
using libCollections.pkgCollections.pkgLineal.pkgVector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace uTestCollections
{
    [TestClass]

    public class UnitTest1
    {
        private clsVectorStack<int> testMyStack;
        private int[] testExpectedItems;
        private int testExpectedItem;
        [TestMethod]
        public void testerExpectedItems()
        {
            #region Setup
                testMyStack = new clsVectorStack<int>(4);
                int[] testExpectedItems = new int[4];
                testExpectedItems[0] = 987;
                testExpectedItems[1] = 789;
                testExpectedItems[2] = 456;
                testExpectedItems[3] = 123;
                #endregion
            #region Test & Assert
                Assert.IsTrue(testMyStack.opPush(123));
                Assert.IsTrue(testMyStack.opPush(456));
                Assert.IsTrue(testMyStack.opPush(789));
                Assert.IsTrue(testMyStack.opPush(987));
                Assert.AreEqual(4, testMyStack.opGetLength());
                Assert.IsFalse(testMyStack.opItsOrderedAscending());
                Assert.IsFalse(testMyStack.opItsOrderedDescending());
                Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
                CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
                Assert.IsFalse(testMyStack.opItsFlexible());
                Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
                Assert.AreEqual(3, testMyStack.opGetAvailableCapacity());
                Assert.AreEqual(987, testMyStack.opToArray()[0]);

                #endregion
        }
        #region BuilderTester
        [TestMethod]
        public void testDefaultConstructor()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();

            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testNegativeCapacityConstructor()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>(-1);
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testValidCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(50);
            Assert.AreEqual(50, testMyStack.opGetTotalCapacity());
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            CollectionAssert.AreEqual(new int[50], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testZeroCapacityConstructor()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>(0);
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(0, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[0], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testBeyondMaxCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(clsVectorStack<int>.opGetMaxCapacity() + 1);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(clsVectorStack<int>.opGetMaxCapacity() + 1, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[clsVectorStack<int>.opGetMaxCapacity() + 1], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testBehindMaxCapacityConstructor()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>(clsVectorStack<int>.opGetMaxCapacity() - 1);
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(clsVectorStack<int>.opGetMaxCapacity() - 1, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[clsVectorStack<int>.opGetMaxCapacity() - 1], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testOverFlowCapacityConstructor()
        {
            #region Setup
            #endregion
            #region Test & Assert
            testMyStack = new clsVectorStack<int>(int.MaxValue);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            #endregion
        }
        [TestMethod]
        public void testMaxCapacityConstructor()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>(clsVectorStack<int>.opGetMaxCapacity());
            #endregion
            #region Test & Assert
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(clsVectorStack<int>.opGetMaxCapacity(), testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(new int[int.MaxValue / 16], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(0, testMyStack.opGetGrowingFactor());
            #endregion
        }
        #endregion
        #region PushTest
        [TestMethod]
        public void testPush()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            int[] testExpectedItems = new int[100];
            testExpectedItems[0] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(123));
            Assert.AreEqual(1, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(123, testMyStack.opToArray()[0]);
            Assert.AreEqual(99, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushFirstItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testExpectedItems = new int[100];
            testExpectedItems[0] = 123;
            //clsLinkedStack<T> otherStack= new clsLinkedStack
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(123));
            Assert.AreEqual(1, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            //Assert.AreEqual(123, testMyStack.opToArray()[0]);
            Assert.AreEqual(99, testMyStack.opGetAvailableCapacity());
            #endregion
        }

        [TestMethod]
        public void testPushNextItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 123, 0, 0, 0 }, 1);
            int[] testExpectedItems = new int[4] { 456, 123, 0, 0 };
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(456));
            Assert.AreEqual(2, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(3, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushSecondItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            int[] testExpectedItems = new int[100];
            testExpectedItems[0] = 123;
            testMyStack.opToItems(testExpectedItems, 1);
            testExpectedItems = new int[100];
            testExpectedItems[0] = 456;
            testExpectedItems[1] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(456));
            Assert.AreEqual(2, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            //CollectionAssert.AreEqual(new int[100], testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(99, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushLastItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testExpectedItems = new int[100];
            testExpectedItems[0] = 123;
            testMyStack.opToItems(testExpectedItems, 1);
            testExpectedItems = new int[100];
            testExpectedItems[0] = 456;
            testExpectedItems[1] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(456));
            Assert.AreEqual(2, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(99, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPushNextItemWithFullFlexibleCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 987, 789, 456, 123 });
            testMyStack.opSetFlexible();
            testExpectedItems = new int[104];
            testExpectedItems[0] = 777;
            testExpectedItems[1] = 987;
            testExpectedItems[2] = 789;
            testExpectedItems[3] = 456;
            testExpectedItems[4] = 123;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPush(987));
            Assert.AreEqual(5, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(104, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsTrue(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(99, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        #endregion
        #region PopTest
        [TestMethod]
        public void testPopWithFullCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 1, 2, 3, 4 });
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPop(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItem);
            Assert.AreEqual(3, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(3, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPopWithEmptyCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[100]);
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsFalse(testMyStack.opPop(ref testExpectedItem));
            Assert.AreEqual(default, testExpectedItem);
            Assert.AreEqual(0, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(100, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(100, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPopNextItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 1, 2, 3, 4 }, 3);
            testExpectedItems = new int[4] { 2, 3, 4, 4 };
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsFalse(testMyStack.opPop(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItem);
            Assert.AreEqual(2, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(2, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        #endregion
        #region PeekTest
        [TestMethod]
        public void testPeekNextItem()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testMyStack.opToItems(new int[4] { 1, 2, 3, 4 }, 3);
            testExpectedItems = new int[4] { 1, 2, 3, 4 };
            testExpectedItem = 1;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPeek(ref testExpectedItem));
            Assert.AreEqual(1, testExpectedItem);
            Assert.AreEqual(3, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(3, testMyStack.opGetAvailableCapacity());
            #endregion
        }
        [TestMethod]
        public void testPeekWithEmptyCollection()
        {
            #region Setup
            testMyStack = new clsVectorStack<int>();
            testExpectedItems = new int[100];
            testExpectedItem = default;
            #endregion
            #region Test & Assert
            Assert.IsTrue(testMyStack.opPeek(ref testExpectedItem));
            Assert.AreEqual(0, testExpectedItem);
            Assert.AreEqual(4, testMyStack.opGetLength());
            Assert.IsFalse(testMyStack.opItsOrderedAscending());
            Assert.IsFalse(testMyStack.opItsOrderedDescending());
            Assert.AreEqual(4, testMyStack.opGetTotalCapacity());
            CollectionAssert.AreEqual(testExpectedItems, testMyStack.opToArray());
            Assert.IsFalse(testMyStack.opItsFlexible());
            Assert.AreEqual(100, testMyStack.opGetGrowingFactor());
            Assert.AreEqual(100, testMyStack.opGetAvailableCapacity());
            #endregion
        }
    }
    #endregion
}