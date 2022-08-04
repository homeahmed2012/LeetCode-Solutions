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
        l1 = l1;
        l2 = l2;
        
        ListNode res = null;
        int rem = 0;
        while(l1 != null && l2 != null){
            int temp = l1.val + l2.val + rem;
            var newNode = new ListNode()
            {
                val = temp%10,
                next = res
            };
            res = newNode;
            rem = temp/10;
            l1 = l1.next;
            l2 = l2.next;
        }
        
        while(l1 != null){
            int temp = l1.val + rem;
            var newNode = new ListNode()
            {
                val = temp%10,
                next = res
            };
            res = newNode;
            rem = temp/10;
            l1 = l1.next;
        }
        
        while(l2 != null){
            int temp = l2.val + rem;
            var newNode = new ListNode()
            {
                val = temp%10,
                next = res
            };
            res = newNode;
            rem = temp/10;
            l2 = l2.next;
        }
        if(rem > 0){
            var newNode = new ListNode()
            {
                val = rem,
                next = res
            };
            res = newNode;
        }
        return Reverse(res);
    }
    
    public ListNode Reverse(ListNode head)
    {
        ListNode prev = null;
        while(head != null){
            var temp = head.next;
            head.next = prev;
            prev = head;
            head = temp;    
        }
        return prev;
    }
}