using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Easy
{
    internal class MergeTwoSortedLists
    {
        public ListNode Soln(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode(-99);
            var current = head;

            while (list1 != null && list2 != null)
            {

                if (list1.val <= list2.val)
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                current = current.next;
            }
            if (list1 != null) current.next = list1;
            if (list2 != null) current.next = list2;

            return head.next;

        }



        public ListNode Soln2(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode(-99);
            var current = head;

            while (list1 != null && list2 != null)
            {
                
                if (list1.val <= list2.val)
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                current = current.next;
            }
            if (list1 != null) current.next = list1;
            if (list2 != null) current.next = list2;

            return head.next;

        }
    }
}
