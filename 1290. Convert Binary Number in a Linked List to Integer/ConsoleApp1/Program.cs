using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int GetDecimalValue(ListNode head)
        {
            int num = 0;
            while (head != null)
            {
                num = num * 2 + head.val;
                head = head.next;
            }
            return num;
        }//Runtime 89 ms Beats 47.65%  Memory 38.3 MB Beats 37.91%
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
