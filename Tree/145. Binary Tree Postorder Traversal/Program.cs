namespace _145._Binary_Tree_Postorder_Traversal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> res=new List<int>();
        if(root==null){
            return new List<int>();
        }
        res.AddRange(PostorderTraversal(root.left));        
        res.AddRange(PostorderTraversal(root.right));        
        res.Add(root.val);
        return res;
    }
}