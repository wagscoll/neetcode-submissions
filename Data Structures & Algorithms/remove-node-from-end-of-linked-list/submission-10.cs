public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        
        ListNode fast = new ListNode(0, head);
        ListNode dummy = fast;
        ListNode slow = fast;
        int i = 0;

        while(i <= n)
        {
            fast = fast.next;
            i++;
        }

        while(fast != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;

        return dummy.next;
    }
}
