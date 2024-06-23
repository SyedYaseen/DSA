using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Medium
{
    internal class RemoveKthFromLastLinkedList
    {
        public ListNode Soln(ListNode head, int n)
        {
            int count = 0;
            ListNode current = head;

            if (n == 1)
            {
                while (current.next.next != null) current = current.next;
                
                current.next = null;
                return head;
            }

            while (current != null)
            {
                count++;
                current = current.next;
            }

            if (count == 0) return head;
            
            count = count - n - 1 ;
            current = head;
            while (count > 0)
            {
                current = current.next;
                count--;
            }
            if(current.next != null && current.next.next != null)  current.next = current.next.next;

            return head;
        }
    }
}
