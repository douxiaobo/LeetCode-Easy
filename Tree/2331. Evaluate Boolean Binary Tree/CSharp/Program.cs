namespace CSharp;
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
    public bool EvaluateTree(TreeNode root) {
        bool result;
        if(root.left==null&&root.right==null){
            if(root.val==1){
                return true;
            } else {
                return false;
            }
        }
        if(root.val==2){
            result=EvaluateTree(root.left)||EvaluateTree(root.right);
        } else {
            result=EvaluateTree(root.left)&&EvaluateTree(root.right);
        }
        return result;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
// douxiaobo@192 CSharp % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Tree/2331. Evaluate Boolean Binary Tree/CSharp/CSharp.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Tree/2331. Evaluate Boolean Binary Tree/CSharp/CSharp.csproj (in 37.83 sec).
// 已成功还原。


// douxiaobo@192 CSharp % 

public class Solution1 {
    public bool EvaluateTree(TreeNode root) {
        if(root.left == null && root.right == null) {
            return root.val == 1;
        }
        if(root.val == 2) {
            return EvaluateTree(root.left) || EvaluateTree(root.right);
        } else {
            return EvaluateTree(root.left) && EvaluateTree(root.right);
        }
    }
}