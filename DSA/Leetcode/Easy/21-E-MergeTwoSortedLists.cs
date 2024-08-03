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

//ListNode ll1 = new ListNode(1, new ListNode(2, new ListNode(4)));
//ListNode ll2 = new ListNode(1, new ListNode(3, new ListNode(5)));


//var cl = new MergeTwoSortedLists();
//cl.Soln(ll1, ll2);
//var f = "a";