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
    public int GetMinimumDifference(TreeNode root) {
        if(root.right == null && root.left == null) return (int)1e6;
        
        var results = new List<int>();
        if(root.left != null)
        {
            results.Add(GetMinimumDifference(root.left));
            results.Add(root.val - GoRight(root.left).val);
        }

        if(root.right != null)
        {
            results.Add(GetMinimumDifference(root.right));
            results.Add(GoLeft(root.right).val - root.val);
        }

        return results.Min();
    }

    private TreeNode GoRight(TreeNode root)
    {
        if(root.right == null) return root;
        return GoRight(root.right);
    }

    private TreeNode GoLeft(TreeNode root)
    {
        if(root.left == null) return root;
        return GoLeft(root.left);
    }
}