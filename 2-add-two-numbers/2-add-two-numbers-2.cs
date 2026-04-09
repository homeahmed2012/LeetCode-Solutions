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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int rem = 0;
        ListNode head = null;
        ListNode current = null;
        while(l1 != null || l2 != null){
            if(current != null) current = current.next = new ListNode();
            else current = new ListNode();
            if(head == null) head = current;
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + rem;
            current.val = sum % 10;
            rem = sum / 10;
            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
        }
        if(rem > 0){
            current = current.next = new ListNode(rem);
        }
        return head;
    }
}