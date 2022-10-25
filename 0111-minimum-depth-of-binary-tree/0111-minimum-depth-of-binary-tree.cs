/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    int minDepth = (int)1e6;
    public int MinDepth(TreeNode root) {
        if(root == null) return 0;
        Solve(root, 1);
        return minDepth;
    }

    public void Solve(TreeNode currentNode, int currentDepth){
        if(currentDepth >= minDepth) return;

        if(currentNode.left == null && currentNode.right == null){
            minDepth = Math.Min(minDepth, currentDepth);
            return;
        }
        if(currentNode.left != null) Solve(currentNode.left, currentDepth + 1);
        if(currentNode.right != null) Solve(currentNode.right, currentDepth + 1);
    }
}

