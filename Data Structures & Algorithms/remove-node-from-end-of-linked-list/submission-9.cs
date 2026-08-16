/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */


/*
Use two pointers, both starting at dummy.
  Advance one pointer (fast) n steps ahead first. 
  Then move fast and a second pointer (slow) forward together, one step at a time, until fast hits the end (null). 
  
At that point, slow is sitting exactly one node before the target — same position, every time, whether the target is the head, the tail, or anywhere in the middle.

Because slow starts at dummy (not head), it always has somewhere valid to sit even when the node to delete is the original head — you're never asking "does this node have a predecessor," because dummy guarantees it does. That's what collapses your 5 cases into one uniform loop plus a single slow.next = slow.next.next at the end.

*/



public class Solution 
{
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        
        ListNode fast = new ListNode(0, head);
        ListNode dummy = fast;
        ListNode slow = fast;
        int i = 0;

        //Advance fast n steps ahead first.
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
