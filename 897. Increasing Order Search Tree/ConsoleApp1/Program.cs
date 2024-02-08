using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(4);
            root.left.left.left = new TreeNode(1);
            root.right = new TreeNode(6);
            root.right.right = new TreeNode(8);
            root.right.right.left = new TreeNode(7);
            root.right.right.right = new TreeNode(9);
            Console.WriteLine(IncreasingBST(root));
            Console.ReadKey();
        }
        public static TreeNode IncreasingBST(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;
            TreeNode prev = null;
            TreeNode first = null;
            while (cur != null || stack.Count > 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                if (prev != null)
                {
                    prev.right = cur;
                }
                else
                {
                    first = cur;
                }
                prev = cur;
                cur.left = null;
                cur = cur.right;
            }
            return first;
        }
    }
}
