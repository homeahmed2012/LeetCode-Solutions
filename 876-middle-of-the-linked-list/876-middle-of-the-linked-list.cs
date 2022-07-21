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
    public ListNode MiddleNode(ListNode head) {
        int count = 0;
        var it = head;
        while(it != null){
            count++;
            it = it.next;
        }
        int mid = count /2;
        for(int i = 0; i < mid; i++){
            head = head.next;
        }
        return head;
    }
}