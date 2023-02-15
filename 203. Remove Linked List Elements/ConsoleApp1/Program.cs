using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode cur = head;
            while (cur != null)
            {
                if (cur.next != null && cur.next.val == val)    //缺少考虑，未填写cur.next!=null
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    if (cur.val == val)     //缺少考虑，未填写这个ygk qkd 。这个语句是链表的头部。
                    {
                        head = cur.next;
                    }
                    cur = cur.next;
                }
            }
            return head;
        }//Runtime 88 ms Beats 88.22% Memory 42.3 MB Beats 23.37%
        public static ListNode RemoveElements1(ListNode head, int val)     //Recursion
        {
            if (head == null)
            {
                return null;
            }
            else if (head.val == val)
            {
                return RemoveElements1(head.next, val);
            }
            else
            {
                head.next = RemoveElements1(head.next, val);
            }
            return head;
        }//Runtime 92 ms Beats 73.19% Memory 42.5 MB Beats 9.60%
        static void Main(string[] args)
        {
            Print(ArrayToListNode(new int[] { 1, 2, 6, 3, 4, 5, 6 }));
            Print(RemoveElements1(ArrayToListNode(new int[] { 1, 2, 6, 3, 4, 5, 6 }), 6));
            Print(ArrayToListNode(new int[] { }));
            Print(RemoveElements(ArrayToListNode(new int[] {  }), 1));
            Print(ArrayToListNode(new int[] { 7, 7, 7, 7 }));
            Print(RemoveElements(ArrayToListNode(new int[] { 7, 7, 7, 7 }), 7));
            Console.ReadKey();
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
        public static ListNode ArrayToListNode(int[]Array)
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
        public static void Print(ListNode list)
        {
            ListNode current = list;
            while (current != null)
            {
                if (current.next != null)
                {
                    Console.Write(current.val + "->");
                }
                else
                {
                    Console.Write(current.val);
                }
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
