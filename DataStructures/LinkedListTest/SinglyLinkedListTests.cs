using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LinkedList;

namespace LinkedListTest
{
    [TestClass]
    public class SinglyLinkedListTests
    {
        #region AddHead Tests
        [TestMethod]
        public void TestMethod1()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddHead(head, 1);

            Assert.AreEqual(1, head.data);
            Assert.IsNull(head.next);
        }

        [TestMethod]
        public void TestMethod2()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddHead(head, 1);
            head = SinglyLinkedListOps.AddHead(head, 2);

            Assert.AreEqual(2, head.data);
            Assert.AreEqual(1, head.next.data);
            Assert.IsNull(head.next.next);
        }

        [TestMethod]
        public void TestMethod3()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddHead(head, 1);
            head = SinglyLinkedListOps.AddHead(head, 2);
            head = SinglyLinkedListOps.AddHead(head, 3);

            Assert.AreEqual(3, head.data);
            Assert.AreEqual(2, head.next.data);
            Assert.AreEqual(1, head.next.next.data);
            Assert.IsNull(head.next.next.next);
        }
        #endregion

        #region AddTail Tests
        [TestMethod]
        public void TestMethod4()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);

            Assert.AreEqual(1, head.data);
            Assert.IsNull(head.next);
        }

        [TestMethod]
        public void TestMethod5()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.AddTail(head, 2);

            Assert.AreEqual(1, head.data);
            Assert.AreEqual(2, head.next.data);
            Assert.IsNull(head.next.next);
        }

        [TestMethod]
        public void TestMethod6()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.AddTail(head, 2);
            head = SinglyLinkedListOps.AddTail(head, 3);

            Assert.AreEqual(1, head.data);
            Assert.AreEqual(2, head.next.data);
            Assert.AreEqual(3, head.next.next.data);
            Assert.IsNull(head.next.next.next);
        }
        #endregion

        #region Insert Tests
        [TestMethod]
        public void TestMethod7()
        {
            SNode head = null;
            head = SinglyLinkedListOps.InsertAt(head, 1, 0);

            Assert.AreEqual(1, head.data);
            Assert.IsNull(head.next);
        }

        [TestMethod]
        public void TestMethod8()
        {
            SNode head = null;
            head = SinglyLinkedListOps.InsertAt(head, 1, 0);
            head = SinglyLinkedListOps.InsertAt(head, 2, 0);

            Assert.AreEqual(2, head.data);
            Assert.AreEqual(1, head.next.data);
            Assert.IsNull(head.next.next);
        }

        [TestMethod]
        public void TestMethod9()
        {
            SNode head = null;
            head = SinglyLinkedListOps.InsertAt(head, 1, 0);
            head = SinglyLinkedListOps.InsertAt(head, 2, 0);
            head = SinglyLinkedListOps.InsertAt(head, 3, 1);

            Assert.AreEqual(2, head.data);
            Assert.AreEqual(3, head.next.data);
            Assert.AreEqual(1, head.next.next.data);
            Assert.IsNull(head.next.next.next);
        }

        [TestMethod]
        public void TestMethod10()
        {
            SNode head = null;
            head = SinglyLinkedListOps.InsertAt(head, 1, 0);
            head = SinglyLinkedListOps.InsertAt(head, 2, 0);
            head = SinglyLinkedListOps.InsertAt(head, 3, 2);

            Assert.AreEqual(2, head.data);
            Assert.AreEqual(1, head.next.data);
            Assert.AreEqual(3, head.next.next.data);
            Assert.IsNull(head.next.next.next);
        }

        [TestMethod]
        public void TestMethod11()
        {
            SNode head = null;
            head = SinglyLinkedListOps.InsertAt(head, 1, 0);
            head = SinglyLinkedListOps.InsertAt(head, 2, 0);
            head = SinglyLinkedListOps.InsertAt(head, 3, 100);

            Assert.AreEqual(2, head.data);
            Assert.AreEqual(1, head.next.data);
            Assert.AreEqual(3, head.next.next.data);
            Assert.IsNull(head.next.next.next);
        }

        #endregion

        #region Delete Tests
        [TestMethod]
        public void TestMethod12()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.DeleteAll(head, 1);
            Assert.IsNull(head);
        }

        [TestMethod]
        public void TestMethod13()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.AddTail(head, 2);
            head = SinglyLinkedListOps.DeleteAll(head, 1);
            Assert.AreEqual(2, head.data);
            Assert.IsNull(head.next);
        }

        [TestMethod]
        public void TestMethod14()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.AddTail(head, 2);
            head = SinglyLinkedListOps.DeleteAll(head, 2);
            Assert.AreEqual(1, head.data);
            Assert.IsNull(head.next);
        }

        [TestMethod]
        public void TestMethod15()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.AddTail(head, 2);
            head = SinglyLinkedListOps.AddTail(head, 3);
            head = SinglyLinkedListOps.DeleteAll(head, 2);
            Assert.AreEqual(1, head.data);
            Assert.AreEqual(3, head.next.data);
            Assert.IsNull(head.next.next);
        }

        [TestMethod]
        public void TestMethod16()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.DeleteAll(head, 1);
            Assert.IsNull(head);
        }

        [TestMethod]
        public void TestMethod17()
        {
            SNode head = null;
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.AddTail(head, 1);
            head = SinglyLinkedListOps.DeleteAll(head, 2);
            Assert.AreEqual(1, head.data);
            Assert.AreEqual(1, head.next.data);
            Assert.IsNull(head.next.next);
        }

        #endregion

        #region Cycle Tests
        [TestMethod]
        public void TestMethod18()
        {
            SNode n4 = new SNode { data = 5 };
            SNode n3 = new SNode { data = 4 };
            SNode n2 = new SNode { data = 3 };
            SNode n1 = new SNode { data = 2 };
            SNode head = new SNode { data = 1 };

            head.next = n1;
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;

            Assert.AreEqual(-1, SinglyLinkedListOps.FindCycle(head));
        }

        [TestMethod]
        public void TestMethod19()
        {
            SNode n1 = new SNode { data = 2 };
            SNode head = new SNode { data = 1 };

            head.next = n1;
            n1.next = head;

            Assert.AreEqual(2, SinglyLinkedListOps.FindCycle(head));
        }

        [TestMethod]
        public void TestMethod20()
        {
            SNode n2 = new SNode { data = 2 };
            SNode n1 = new SNode { data = 2 };
            SNode head = new SNode { data = 1 };

            head.next = n1;
            n1.next = n2;
            n2.next = head;

            Assert.AreEqual(3, SinglyLinkedListOps.FindCycle(head));
        }

        [TestMethod]
        public void TestMethod21()
        {
            SNode n2 = new SNode { data = 2 };
            SNode n1 = new SNode { data = 2 };
            SNode head = new SNode { data = 1 };

            head.next = n1;
            n1.next = n2;
            n2.next = n1;

            Assert.AreEqual(2, SinglyLinkedListOps.FindCycle(head));
        }
        #endregion

        #region Reverse Tests
        [TestMethod]
        public void TestMethod22()
        {
            SNode head = new SNode { data = 1 };

            head = SinglyLinkedListOps.Reverse(head);

            Assert.AreEqual(1, head.data);
            Assert.IsNull(head.next);
        }

        [TestMethod]
        public void TestMethod23()
        {
            SNode head = new SNode { data = 1 };
            head = SinglyLinkedListOps.AddTail(head, 2);

            head = SinglyLinkedListOps.Reverse(head);

            Assert.AreEqual(2, head.data);
            Assert.AreEqual(1, head.next.data);
            Assert.IsNull(head.next.next);
        }

        [TestMethod]
        public void TestMethod24()
        {
            SNode head = new SNode { data = 1 };
            head = SinglyLinkedListOps.AddTail(head, 2);
            head = SinglyLinkedListOps.AddTail(head, 3);

            head = SinglyLinkedListOps.Reverse(head);

            Assert.AreEqual(3, head.data);
            Assert.AreEqual(2, head.next.data);
            Assert.AreEqual(1, head.next.next.data);
            Assert.IsNull(head.next.next.next);
        }
        #endregion

        #region Swap Tests
        [TestMethod]
        public void TestMethod25()
        {
            SNode head = new SNode { data = 1 };
            head = SinglyLinkedListOps.AddTail(head, 2);
            head = SinglyLinkedListOps.AddTail(head, 3);
            head = SinglyLinkedListOps.AddTail(head, 4);
            head = SinglyLinkedListOps.AddTail(head, 5);

            // Swap 2 and 4
            SinglyLinkedListOps.Swap(head, head.next, head.next.next.next);
            ValidateList(head, new List<int> { 1, 4, 3, 2, 5 });
        }

        [TestMethod]
        public void TestMethod26()
        {
            SNode head = new SNode { data = 1 };
            head = SinglyLinkedListOps.AddTail(head, 2);
            head = SinglyLinkedListOps.AddTail(head, 3);
            head = SinglyLinkedListOps.AddTail(head, 4);
            head = SinglyLinkedListOps.AddTail(head, 5);

            // Swap 2 and 3
            SinglyLinkedListOps.Swap(head, head.next, head.next.next);
            ValidateList(head, new List<int> { 1, 3, 2, 4, 5 });
        }

        [TestMethod]
        public void TestMethod27()
        {
            SNode head = new SNode { data = 1 };
            head = SinglyLinkedListOps.AddTail(head, 2);
            head = SinglyLinkedListOps.AddTail(head, 3);
            head = SinglyLinkedListOps.AddTail(head, 4);
            head = SinglyLinkedListOps.AddTail(head, 5);

            // Swap 2 and 3
            SinglyLinkedListOps.Swap(head, head, head.next);
            ValidateList(head, new List<int> { 2, 1, 3, 4, 5 });
        }

        private void ValidateList(SNode head, List<int> expected)
        {
            int count = 0;
            SNode curr = head;

            // Validate count of items in each list is equal.
            while (curr != null)
            {
                count++;
                curr = curr.next;
            }

            // Ensure the lists contain the same number of elements.
            Assert.AreEqual(count, expected.Count);

            curr = head;
            count = 0;
            while (curr != null)
            {
                // Ensure data for the current node is valid.
                Assert.AreEqual(expected[count], curr.data);

                count++;
                curr = curr.next;
            }
        }
        #endregion
    }
}
