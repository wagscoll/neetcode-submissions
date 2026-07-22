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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode();
        ListNode list3 = dummy;

        while (list1 != null && list2 != null) 
        {
            int least = list1.val <= list2.val ? list1.val : list2.val; 
            list3.next = new ListNode(least);

            list3 = list3.next;
            
            if(list1.val > list2.val)
                list2 = list2.next; //progresses list2
            
            else
                list1 = list1.next; //progresses list1     
        }
        list3.next = list1 ?? list2;
        return dummy.next;
    }
}
