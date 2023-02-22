using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {
                int index = 0;
                ListNode cur = head;
                while (cur != null)
                {
                    index++;
                    cur = cur.next;
                }
                index = index / 2 + 1;
                cur = head;
                while (index > 1)
                {
                    index--;
                    cur = cur.next;
                }
                return cur;
            }
        }//Runtime 95 ms Beats 19.7% Memory 38 MB Beats 47.87%
        public ListNode MiddleNode1(ListNode head)
        {
            int index = 0;
            ListNode cur = head;
            while (cur != null)
            {
                index++;
                cur = cur.next;
            }
            index = index / 2;
            cur = head;
            while (index > 0)
            {
                index--;
                cur = cur.next;
            }
            return cur;
        }//Runtime 89 ms Beats 45.12% Memory 37.9 MB Beats 62.57%
        static void Main(string[] args)
        {
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0,ListNode next=null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
