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
    public bool IsPalindrome(ListNode head) {
        int length = GetLength(head);
        if(length < 2) return true;
        bool res = true;
        ListNode prev = null;
        for(int i = 0; i < length/2; i++){
            var temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;
        }
        if(length %2 == 1) head = head.next;
        ListNode left, right;
        left = prev; right = head;
        while(left != null){
            if(left.val != right.val){
                res = false;
                break;
            }
            left = left.next;
            right = right.next;
        }
        return res;
    }
    
    public int GetLength(ListNode head){
        int count = 0;
        while(head != null){
            count++;
            head = head.next;        
        } 
        return count;
    }
}