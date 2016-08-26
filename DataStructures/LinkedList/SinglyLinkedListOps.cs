using System;

namespace LinkedList
{
    /// <summary>
    /// Data structure representing a node in a singly linked list.
    /// </summary>
    public class SNode
    {
        public int data;
        public SNode next;
    }

    /// <summary>
    /// Collection of methods to perform basic operations on a singly linked list.
    /// </summary>
    /// <remarks>
    /// Some of the operations can be cleaned up if an alternate implementation
    /// of a linked list is used. If the linked list contained sentinal head and tail
    /// nodes, the addition and removal of any node becomes trivial. The operation
    /// does not have to check for the common edge cases (head and tail nodes).
    /// </remarks>
    public static class SinglyLinkedListOps
    {
        public static SNode AddHead(SNode head, int data)
        {
            SNode newNode = new SNode { data = data };
            newNode.next = head;
            return newNode;
        }

        public static SNode AddTail(SNode head, int data)
        {
            SNode newNode = new SNode { data = data };

            // List doesn't exist, just return the new node.
            if (head == null)
            {
                return newNode;
            }

            SNode tmp = head;

            // Iterate to end of list.
            while (tmp.next != null)
            {
                tmp = tmp.next;
            }

            // Add the new node.
            tmp.next = newNode;

            return head;
        }

        public static SNode InsertAt(SNode head, int data, int position)
        {
            SNode newNode = new SNode { data = data };

            // Adding position 0 is the same as AddHead.
            if (position == 0)
            {
                return AddHead(head, data);
            }

            int index = 0;
            SNode curr = head;
            SNode prev = null;

            while (curr != null && index < position)
            {
                prev = curr;
                curr = curr.next;
                index++;
            }

            // Add the new node.
            newNode.next = curr;
            prev.next = newNode;

            return head;
        }

        public static SNode DeleteAll(SNode head, int data)
        {
            SNode curr = head;
            SNode prev = null;
            SNode toDelete = null;

            // Delete all nodes with the given data.
            while (curr != null)
            {
                if (curr.data == data)
                {
                    toDelete = curr;
                    if (prev == null)
                    {
                        head = curr.next;
                    }
                    else
                    {
                        prev.next = curr.next;
                    }
                }
                else
                {
                    prev = curr;
                }
                curr = curr.next;
                toDelete = null;
            }

            return head;
        }

        public static void InsertAfter(SNode node, SNode a)
        {
            a.next = node.next;
            node.next = a;
        }

        public static SNode RemoveNext(SNode node)
        {
            SNode tmp = node.next;
            if (tmp != null)
            {
                node.next = node.next.next;
            }
            return tmp;
        }

        public static void Swap(SNode head, SNode a, SNode b)
        {
            SNode x = head;

            // TODO: What if a is the head of list?
            // Find the node before a.
            while (x.next != null && x.next.data != a.data)
            {
                x = x.next;
            }

            SNode y = head;

            // Find the node before b.
            while (y.next != null && y.next.data != b.data)
            {
                y = y.next;
            }

            x.next = b;
            y.next = a;

            SNode tmp = a.next;
            a.next = b.next;
            b.next = tmp;
        }

        public static int CycleSize(SNode head, SNode curr)
        {
            SNode a = head;
            SNode b = curr;

            // Find the cycle start index.
            int cycleStartIndex = 0;
            while (a != b)
            {
                a = a.next;
                b = b.next;
                cycleStartIndex++;
            }

            // Count the cycle size.
            a = a.next;
            int cycleSize = 1;
            while (a != b)
            {
                a = a.next;
                cycleSize++;
            }
            Console.WriteLine("cycleStartIndex={0}, cycleSize={1}", cycleStartIndex, cycleSize);
            return cycleSize;
        }

        public static int FindCycle(SNode head)
        {
            int cycleSize = -1;

            if (head == null || head.next == null)
            {
                return cycleSize;
            }

            // "a" starts at index 0, "b" starts at index 2.
            SNode a = head;
            SNode b = head.next.next;

            while (b != null)
            {
                // Update "a" by one.
                a = a.next;

                if (a == b)
                {
                    // Found cycle.
                    cycleSize = CycleSize(head, b);
                    return cycleSize;
                }

                // Update "b" by two.
                b = b.next;
                if (b != null)
                {
                    b = b.next;
                }
            }
            // Reached end of list without cycle.
            return cycleSize;
        }

        public static SNode Reverse(SNode head)
        {
            SNode curr = head;
            SNode next = head;
            SNode prev = null;

            while (curr != null)
            {
                next = next.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }
    }
}
