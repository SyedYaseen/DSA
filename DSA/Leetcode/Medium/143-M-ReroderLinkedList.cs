using DSA.Leetcode.Medium;
using DSA.Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Medium
{
    internal class ReroderLinkedList
    {
        public void Soln(ListNode head)
        {
            // split in half, reverse second half and insert in middle
            int count = 0;
            ListNode last = head;

            //Find middle of list - using slow and fast pointers
            ListNode middle = head;
            ListNode fast = head;
            while (fast.next!=null && fast.next.next != null)
            {
                middle = middle.next;
                fast = fast.next.next;
            }

            // Assign second half starting point
            ListNode secondHalf = middle.next;

            // reverse second half
            ListNode node = null;
            

            while (secondHalf != null)
            {
                ListNode temp = secondHalf.next;
                secondHalf.next = node;
                node = secondHalf;
                secondHalf = temp;
            }

            //Add to head
            ListNode current = head;
            while (node != null )
            {
                ListNode temp = current.next;
                ListNode secondTemp = node.next;

                current.next = node;
                node.next = temp;


                node = secondTemp;
                current = temp;
            }
            if (current != null)
            {   // To avoid cyclic lists
                current.next = null;
            }
            
        }
    }
}


//ListNode ll1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
//ListNode ll2 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));


//var cl = new ReroderLinkedList();
//cl.Soln(ll1);
//cl.Soln(ll2);
//var f = "a";
