/* namespace Solution
{
    class solution17
    {


        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode nextTemp = current.next;  // Save the next node
                current.next = prev;               // Reverse the current node's pointer
                prev = current;                    // Move prev and current one step forward
                current = nextTemp;
            }

            return prev;  // prev will be the new head of the reversed list
        }

    }
}
 */