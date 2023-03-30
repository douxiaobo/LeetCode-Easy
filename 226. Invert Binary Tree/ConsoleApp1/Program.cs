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
        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                var temp = root.left;
                root.left = root.right;
                root.right = temp;
            }
            InvertTree(root.left);
            InvertTree(root.right);
            return root;
        }
        static void Main(string[] args)
        {
        }
    }
}
