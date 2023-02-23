using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null && q != null)
            {
                return false;
            }
            else if (p != null && q == null)
            {
                return false;
            }
            else if (p.val == q.val)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
            else
            {
                return false;
            }
        }//Runtime 90 ms Beats 93.96% Memory 39 MB Beats 92.83%
        static void Main(string[] args)
        {
        }
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val=0,TreeNode left=null, TreeNode right = null)
            {
                this .val = val;
                this.left= left;
                this.right = right;
            }
        }
    }
}
