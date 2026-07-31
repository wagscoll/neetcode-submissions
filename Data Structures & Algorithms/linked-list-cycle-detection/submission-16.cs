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

public class Solution {
    public bool HasCycle(ListNode head) 
    {
        ListNode dummy = head;

        if(head is null)
            return false;

        int i = 0;

        while(dummy is not null && i < 30)
        {
            Console.WriteLine($"dummy.val: {dummy.val} \n");
            dummy = dummy.next;
            i++;
        }

        if (i < 30 )
            return false;

        return true;
        
    }
}
