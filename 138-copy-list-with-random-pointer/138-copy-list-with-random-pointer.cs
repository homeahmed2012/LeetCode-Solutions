/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if(head == null) return head;
        var dict = new Dictionary<Node, Node>();
        Node dummy = head;
        while (dummy != null) {
            dict[dummy] = new Node(dummy.val);
            dummy = dummy.next;
        }
        dummy = head;
        while (dummy != null) {
            if (dummy.next != null) {
                dict[dummy].next = dict[dummy.next];
            }
            if (dummy.random != null) {
                dict[dummy].random = dict[dummy.random];
            }
            dummy = dummy.next;
        }
        return dict[head];
    }
}