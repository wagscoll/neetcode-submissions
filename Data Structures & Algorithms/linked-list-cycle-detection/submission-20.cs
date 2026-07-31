public class Solution {
    public bool HasCycle(ListNode head) 
    {
        bool loopDetected = false;

        if(head is null || head.next is null)
            return false;

        ListNode slow = head;
        ListNode fast = head;

        while(!loopDetected)
        {
            if(slow == null || fast == null || slow.next == null || fast.next is null)
                return false;

            slow = slow.next;
            fast = fast.next.next;

            if(slow == fast)
            {
                loopDetected = true;
                return true;
            }
        }
        return loopDetected;  
    }
}