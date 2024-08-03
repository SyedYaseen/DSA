namespace DSA.Leetcode.Medium
{
    internal class AddTwoNumsLinkedList
    {
        public ListNode Soln(ListNode l1, ListNode l2)
        {
            int carry = 0;


            ListNode result = new ListNode(0);
            ListNode tail = result;

            while (l1 != null || l2 != null || carry == 1)
            {
                var res = carry + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                carry = res > 9 ? 1 : 0;
                res = res % 10;

                tail.next = new ListNode(res);
                tail = tail.next;


                l1 = l1?.next;
                l2 = l2?.next;
            }

            return result.next;
        }

        public ListNode Soln2(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode left = l1;

            while (left != null && l2 != null)
            {
                var res = carry + left.val + l2.val;
                if (res > 9) carry = 1;
                else carry = 0;

                left.val = res % 10;
                l2 = l2.next;
                if (left.next == null && l2 != null && l2.next != null) left.next = l2.next;
                else left = left.next;
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
