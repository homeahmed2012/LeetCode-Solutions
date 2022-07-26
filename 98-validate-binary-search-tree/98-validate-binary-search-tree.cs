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
    public bool IsValidBST(TreeNode root, long low = 100000000000 * -1, long high = 100000000000)     {
        if(root == null) return true;
        if(root.val <= low || root.val >= high) return false;
        return IsValidBST(root.left, low, Math.Min(root.val, high)) 
            && IsValidBST(root.right, Math.Max(root.val, low) , high);
    }
}