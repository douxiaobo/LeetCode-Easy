using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution   //利用哈希表，空间复杂度为O(n)的解法
    {
        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> set = new HashSet<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;
            while (cur != null || stack.Count > 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                if (set.Contains(k - cur.val))
                {
                    return true;
                }
                set.Add(cur.val);
                cur = cur.right;
            }
            return false;
        }
    }//Runtime:109 ms Beats:98.78% Memory:50.7 MB Beats:54.27%
    public class Solution
    {
        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }
            BSTIterator iterNext = new BSTIterator(root);
            BSTIteratorReversed iterPrev = new BSTIteratorReversed(root);
            int next = iterNext.next();
            int prev = iterPrev.prev();
            while (next != prev)
            {
                if (next + prev == k)
                {
                    return true;
                }
                if (next + prev < k)
                {
                    next = iterNext.next();
                }
                else
                {
                    prev = iterPrev.prev();
                }
            }
            return false;
        }
        public class BSTIteratorReversed
        {
            TreeNode cur;
            Stack<TreeNode> stack;
            public BSTIteratorReversed(TreeNode root)
            {
                cur = root;
                stack = new Stack<TreeNode>();
            }
            //public bool hasPrev(){
            //    return cur!=null||stack.Count>0;
            //}
            public int prev()
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.right;
                }
                cur = stack.Pop();
                int val = cur.val;
                cur = cur.left;
                return val;
            }
        }
        public class BSTIterator
        {
            TreeNode cur;
            Stack<TreeNode> stack;

            public BSTIterator(TreeNode root)
            {
                cur = root;
                stack = new Stack<TreeNode>();
            }

            public int next()
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                int val = cur.val;
                cur = cur.right;
                return val;
            }

            //public bool hasNext() {
            //    return cur!=null||stack.Count>0;
            //}
        }
    }//Runtime:130 ms Beats:47.33% Memory:50.3 MB Beats:80.92%
}
