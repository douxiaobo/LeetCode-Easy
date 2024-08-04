using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public bool IsSymmetric(TreeNode root)
        {
            Queue<TreeNode> QL = new Queue<TreeNode>();
            Queue<TreeNode> QR = new Queue<TreeNode>();
            QL.Enqueue(root.left);
            QR.Enqueue(root.right);
            while (QL.Count > 0 || QR.Count > 0)
            {
                TreeNode TNL = QL.Dequeue();
                TreeNode TNR = QR.Dequeue();
                if (TNL == null && TNR == null)
                {
                    continue;
                }
                if (TNL == null || TNR == null || TNL.val != TNR.val)
                {
                    return false;
                }
                QL.Enqueue(TNL.left);
                QL.Enqueue(TNL.right);
                QR.Enqueue(TNR.right);
                QR.Enqueue(TNR.left);
            }
            if (QL.Count == 0 && QR.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
        }
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
    }
}
