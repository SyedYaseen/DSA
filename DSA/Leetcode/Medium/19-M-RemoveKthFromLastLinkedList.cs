using DSA.Leetcode.Medium;
using DSA.Leetcode;
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
            if (head == null) return head;

            int count = 1;
            ListNode current = head;

            while (current.next != null)
            {
                current = current.next;
                count++;
            }

            if (count == 1 && n == 1) return null;
            if (count == n) return head.next;

            count = count - n;

            

            current = head;
            while (count > 1)
            {
                current = current.next;
                count--;
            }
            if(current.next != null)  current.next = current.next.next;

            return head;
        }
    }
}


//ListNode ll1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
//ListNode ll2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
//ListNode ll3 = new ListNode(1, new ListNode(2));
//ListNode ll4 = new ListNode(1, new ListNode(2));


//var cl = new AddTwoNumsLinkedList();
//cl.Soln(ll4, 2); //[2]
//cl.Soln(ll1, 2);
//cl.Soln(ll2, 2);
//cl.Soln(ll3, 1);
