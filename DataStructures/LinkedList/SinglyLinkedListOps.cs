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

            int index = 0;
            SNode curr = head;
            SNode prev = null;

            // Iterate through list until position is reached.
            // If position > list size, will append item to end of list.
            while (curr != null && index < position)
            {
                prev = curr;
                curr = curr.next;
                index++;
            }

            if (prev == null)
            {
                // Insert item at head of list.
                head = newNode;
            }
            else
            {
                // Insert item in position.
                prev.next = newNode;
            }

            // Append the rest of the list after the new node.
            newNode.next = curr;

            return head;
        }

        public static SNode DeleteAll(SNode head, int data)
        {
            SNode curr = head;
            SNode prev = null;

            // Delete all nodes with the given data.
            while (curr != null)
            {
                // If the current node matches the data:
                if (curr.data == data)
                {
                    // If head node:
                    if (prev == null)
                    {
                        // Skip over the node.
                        head = curr.next;
                    }
                    // If any other node:
                    else
                    {
                        // Update the incoming reference to the current node
                        // to skip over the node.
                        prev.next = curr.next;
                    }
                }
                // Current node does not match data:
                else
                {
                    // Update the previous node to be current node.
                    prev = curr;
                }

                // Move to the next node.
                curr = curr.next;
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

        public static void Swap(ref SNode head, SNode a, SNode b)
        {
            // If the nodes are the same:
            if (a == b)
            {
                // Nothing to do.
                return;
            }

            // Find a, keeping track of the previous node.
            SNode prevA = null;
            SNode currA = head;
            while (currA != null && currA.data != a.data)
            {
                prevA = currA;
                currA = currA.next;
            }

            // Find b, keeping track of the previous node.
            SNode prevB = null;
            SNode currB = head;
            while (currB != null && currB.data != b.data)
            {
                prevB = currB;
                currB = currB.next;
            }

            // If either node is not found:
            if (currA == null || currB == null)
            {
                // Nothing to do.
                return;
            }

            if (prevA != null)
            {
                prevA.next = currB;
            }
            else
            {
                head = currB;
            }

            if (prevB != null)
            {
                prevB.next = currA;
            }
            else
            {
                head = currA;
            }

            // Swap the 'next' references.
            SNode tmp = currB.next;
            currB.next = currA.next;
            currA.next = tmp;
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
