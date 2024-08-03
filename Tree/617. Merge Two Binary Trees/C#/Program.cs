namespace C_;
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Solution {
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if (root1 != null && root2 != null) {
            TreeNode result = new TreeNode(root1.val + root2.val);
            result.left = MergeTrees(root1.left, root2.left);
            result.right = MergeTrees(root1.right, root2.right);
            return result;
        } else if (root1 != null && root2 == null) {
            return root1; // 直接返回root1，因为root2为空，无需合并
        } else if (root1 == null && root2 != null) {
            return root2; // 直接返回root2，因为root1为空，无需合并
        } else {
            // 当root1和root2都为null时，可以返回一个null或者一个新的空节点
            return null; // 或者 return new TreeNode(0);
        }
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
// 正在还原 /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Tree/617. Merge Two Binary Trees/C#/C#.csproj:
//   Determining projects to restore...
//   Restored /Users/douxiaobo/Documents/Practice in Coding/LeetCode-Easy/Tree/617. Merge Two Binary Trees/C#/C#.csproj (in 1.57 sec).
// 已成功还原。


// douxiaobo@192 C# % 