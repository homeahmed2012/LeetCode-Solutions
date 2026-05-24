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

    public IList<double> AverageOfLevels(TreeNode root) {
        var levels = new List<List<int>>();
        FillLevels(levels, root, 0);
        return levels.Select(l => l.Average()).ToList();         
    }

    private void FillLevels(List<List<int>> levels, TreeNode root, int level)
    {
        if(root == null) return;
        if(levels.Count < level + 1) levels.Add(new List<int>());
        levels[level].Add(root.val);
        FillLevels(levels, root.left, level+1);
        FillLevels(levels, root.right, level+1);
    }
}