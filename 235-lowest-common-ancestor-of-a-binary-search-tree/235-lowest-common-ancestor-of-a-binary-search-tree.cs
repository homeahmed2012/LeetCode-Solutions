/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    
    List<TreeNode> PRout = new List<TreeNode>();
    List<TreeNode> QRout = new List<TreeNode>();
    
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        Solve(root, p.val, q.val, new List<TreeNode>());
        var res = PRout.First();
        for(int i = 0; i < Math.Min(PRout.Count, QRout.Count); i++){
            if(PRout[i] == QRout[i])
                res = PRout[i];
            else
                break;
        }
        return res;
    }
    
    public void Solve(TreeNode root, int p, int q, List<TreeNode> path){
        if(root == null) return;
        path.Add(root);
        if(root.val == p){
            PRout.AddRange(path);
        }
        if(root.val == q){
            QRout.AddRange(path);
        }
        Solve(root.left, p, q, path);
        Solve(root.right, p, q, path);
        path.RemoveAt(path.Count -1);
    }
}