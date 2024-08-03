using DSA.LinkedListDSA;

namespace DSA.Leetcode.Easy
{
    internal class ReverseLinkedList
    {
        public Node Soln(Node head)
        {
            if (head._next == null) return head;
            Node node = null;

            while (head != null)
            {
                var temp = head._next;
                head._next = node;
                node = head;
                head = temp;
            }
            return node;
        }
    }
}
