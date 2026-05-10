
var root = new TreeNode(1,
new TreeNode(2, new TreeNode(3), new TreeNode(4)),
new TreeNode(2, new TreeNode(3), new TreeNode(4)));

var result = new Solution().IsSymmetric(root);
System.Console.WriteLine(result);

public class Solution {
    public bool IsSymmetric(TreeNode root) {
        var right = InvertTree(root.right);
        return IsSameTree(root.left, right);
    }

    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return root;
        var left = root.left;
        root.left = InvertTree(root.right);
        root.right = InvertTree(left);
        return root;
    }

    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null) return true;
        if(p?.val != q?.val) return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}


  //Definition for a binary tree node.
  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left = null, TreeNode right = null) {
         this.val = val;
          this.left = left;
         this.right = right;
      }
  }
