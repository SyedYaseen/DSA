using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Leetcode.Medium
{
    internal class AddTwoNumsLinkedList
    {
        public ListNode Soln(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode left = l1;
           
            while (left != null && l2 != null)
            {
               
                var res = carry + left.val + l2.val;
                if(res > 9) carry = 1;
                else carry = 0;

                left.val = res % 10;

                if (left.next == null && l2.next != null) left.next = l2.next;
                else
                {
                    left = left.next;
                    l2 = l2.next;
                }
                
            }



            while (carry != 0 && left != null)
            {
   
                var res = carry + left.val;
                if (res < 10) carry = 0;
                left.val = res % 10;

                if (left.next != null) left = left.next;
                else
                {
                    left.next = new ListNode(carry);
                    carry = 0;
                }
            }

            return l1;
        }
    }
}
