namespace C_;
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
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root == null) {  
            return 0;  
        }  
          
        int sum = 0;  
        // 如果当前节点的值在范围内，则加入总和  
        if (root.val >= low && root.val <= high) {  
            sum += root.val;  
        }  
        // 递归检查左子树，范围仍然是[low, high]  
        sum += RangeSumBST(root.left, low, high);  
        // 递归检查右子树，范围仍然是[low, high]  
        sum += RangeSumBST(root.right, low, high);  
          
        return sum;  
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

// douxiaobo@192 C# % dotnet new console --framework net8.0 --use-program-main
// 已成功创建模板“控制台应用”。

// 正在处理创建后操作...
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Tree/938. Range Sum of BST/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Tree/938. Range Sum of BST/C#/C#.csproj (in 516 ms).
// 已成功还原。


// douxiaobo@192 C# % 
