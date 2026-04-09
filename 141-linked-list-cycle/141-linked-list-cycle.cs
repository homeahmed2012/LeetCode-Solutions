/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    int visited = (int)1e6;
    public bool HasCycle(ListNode head) {
        while (head != null)
        {
            if(head.val == visited) return true;
            head.val = visited;
            head = head.next;
        }
        return false;
    }
}