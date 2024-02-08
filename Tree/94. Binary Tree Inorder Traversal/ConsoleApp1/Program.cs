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
            public TreeNode(int val=0,TreeNode left=null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public class Solution
        {
            static List<int> list = new List<int> { };  //这个语y
            public static IList<int> InorderTraversal(TreeNode root)
            {
                if (root != null)
                {
                    InorderTraversal(root.left);
                    list.Add(root.val);
                    InorderTraversal(root.right);
                }
                return list;
            }
        }//Runtime 172 ms Beats 12.2% Memory 40.9 MB Beats 91.2%
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            TreeNode rootr= new TreeNode();
            TreeNode rootl= new TreeNode();
            root.val = 1;
            rootr.val = 2;
            rootl.val = 3;
            root.right = rootr;
            rootr.left = rootl;
            root.left = rootr.right = rootl.left = rootl.right = null;
            foreach(int x in Solution.InorderTraversal(root))
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
