using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
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
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode outerCur = head;   //第一个结点
            ListNode innerPre = null;   //前序结点
            ListNode innerCur = null;   //当前结点
            for (; outerCur != null; outerCur = outerCur.next)
            {
                for (innerCur = outerCur.next, innerPre = outerCur; innerCur != null;)
                {
                    if (outerCur.val == innerCur.val)
                    {
                        innerPre.next = innerCur.next;  //innerPre的结点没有变动。
                        innerCur = innerCur.next;
                    }
                    else
                    {
                        innerPre = innerCur;
                        innerCur = innerCur.next;
                    }
                }
            }
            return head;
        }
        static void Main(string[] args)
        {
            ListNode List1 = ListToListNode(new List<int> { 1, 1, 2 });
            Print(List1);
            Print(DeleteDuplicates(List1));
            ListNode List2 = ListToListNode(new List<int> { 1, 1, 2, 3, 3 });
            Print(List2);
            Print(DeleteDuplicates(List2));
            Console.ReadKey();
        }
        public static ListNode ListToListNode(List<int> list)
        {
            if (list == null)
            {
                return null;
            }

            ListNode head = null, tail = null;
            foreach (var t in list)
            {
                if (head == null)
                {
                    head = tail = new ListNode(t);
                }
                else
                {
                    tail.next = new ListNode(t);
                    tail = tail.next;
                }
            }

            return head;
        }
        public static void Print(ListNode head)
        {
            for (ListNode cur = head; cur != null; cur = cur.next)
            {
                if(cur.next!=null)
                {
                    Console.Write(cur.val + "->");
                }
                else
                {
                    Console.Write(cur.val);
                }
            }
            Console.WriteLine();
        }
    }
}
