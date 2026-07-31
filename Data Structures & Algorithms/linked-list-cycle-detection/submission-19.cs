public class Solution {
    public bool HasCycle(ListNode head) 
    {
        /*
        Two pointers, both starting at head. slow moves one node at a time; 
            fast moves two nodes at a time. If there's a cycle, 
            fast will eventually lap slow and they land on the same node.
            If there's no cycle, fast (or fast.next) hits null before that ever happens.
        */

        bool loopDetected = false;

        if(head is null || head.next is null)
            return false;

        ListNode slow = head;
        ListNode fast = head;

        while(!loopDetected)
        {
            if(slow == null || fast == null)
                return false;

            if(slow.next is null || fast.next is null)
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