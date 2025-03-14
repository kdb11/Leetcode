namespace Solution
{
    class solution17
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode ReverseList(ListNode head)
        {

            List<int> result = new List<int>();
            int a = 0;

            for (int i = head.Length - 1; i >= 0; i--)
            {
                result[a] = head[i];
                a++;
            }
            ;
            return result;
        }
    }
}