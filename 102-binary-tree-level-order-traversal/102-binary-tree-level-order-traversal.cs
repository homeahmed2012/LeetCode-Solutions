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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res = new List<IList<int>>();
        var q = new Queue<Tuple<TreeNode, int>>();
        if(root == null) return res;
        q.Enqueue(Tuple.Create(root, 0));
        int level = 0;
        var currentLevel = new List<int>();
        while(q.Count > 0){
            var current = q.Dequeue();
            if(current.Item2 > level){
                if(currentLevel.Count > 0){
                    res.Add(currentLevel);
                    currentLevel = new List<int>();                    
                }
                level = current.Item2;
                currentLevel.Add(current.Item1.val);
            }else{
                currentLevel.Add(current.Item1.val);
            }
            
            if(current.Item1.left != null){
                q.Enqueue(Tuple.Create(current.Item1.left, current.Item2 +1));
            } 
            if(current.Item1.right != null){
                q.Enqueue(Tuple.Create(current.Item1.right, current.Item2 +1));
            }
        }
        if(currentLevel.Count > 0) res.Add(currentLevel);
        return res;
    }
}