using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool IsPalindrome(ListNode head)
        {
            Stack<int> st = new Stack<int>();
            ListNode cur = head;
            while (cur != null)
            {
                st.Push(cur.val);
                cur = cur.next;
            }
            cur = head;
            while(cur!=null)
            {
                if(cur.val!=st.Peek())
                {
                    return false;
                }
                st.Pop();
                cur = cur.next;
            }
            return true;
        }//Runtime 242 ms Beats 85.93% Memory 62 MB Beats 20.61%
        static void Main(string[] args)
        {
            ListNode node = ArrayToListNode(new int[] { 1, 2, 2, 1 });
            Console.WriteLine(IsPalindrome(node));
            Console.ReadKey();
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val=0,ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public static ListNode ArrayToListNode(int[] Array)
        {
            if (Array == null)
            {
                return null;
            }
            ListNode head = null, tail = null;
            for (int i = 0; i < Array.Length; i++)
            {
                if (head == null)
                {
                    head = tail = new ListNode(Array[i]);
                }
                else
                {
                    tail.next = new ListNode(Array[i]);
                    tail = tail.next;
                }
            }
            return head;
        }
    }
}
