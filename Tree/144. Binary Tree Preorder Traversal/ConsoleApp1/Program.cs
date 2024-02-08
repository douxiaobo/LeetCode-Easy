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
            public TreeNode(int val=0,TreeNode left=null, TreeNode right=null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            if (root == null)
            {
                return new List<int>();
            }
            res.Add(root.val);
            res.AddRange(PreorderTraversal(root.left));
            res.AddRange(PreorderTraversal(root.right));
            return res;
        }
        static void Main(string[] args)
        {
        }
    }
}
