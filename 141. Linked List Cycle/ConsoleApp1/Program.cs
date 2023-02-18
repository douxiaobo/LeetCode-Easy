using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //双指针，List,Dict,Hashtab，共四种方法
        public static bool HasCycle(ListNode head)
        {
            ListNode Quick = head;
            ListNode Slow = head;
            while (Quick != null && Quick.next != null)     //缺少考虑
            {
                Quick = Quick.next.next;
                Slow = Slow.next;
                if (Quick == Slow)      //不能写上.val
                {
                    return true;
                }
            }
            return false;
        }//Runtime 114 ms Beats 39.64% Memory 43.1 MB Beats 44.92%
        public bool HasCycle1(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            ListNode Quick = head.next;
            ListNode Slow = head;
            while (Quick != Slow)
            {
                if (Quick?.next == null)        //不点问号，运行失败。不了解问号是什么用处。
                {
                    return false;
                }
                Quick = Quick.next.next;
                Slow = Slow.next;
            }
            return true;
        }//Runtime 106 ms Beats 70.44% Memory 43.1 MB Beats 44.92%
        static void Main(string[] args)
        {
            Console.WriteLine(HasCycle(ArrayToListNode(new int[] { 3, 2, 0, -4 },1)));//LeetCode显示是True，pos=1;在VS显示是False.
            Console.WriteLine(HasCycle(ArrayToListNode(new int[] { 1, 2 },0)));//LeetCode显示是True,pos=0;
            Console.WriteLine(HasCycle(ArrayToListNode(new int[] { 1 },-1)));
            Console.ReadKey();
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        public static void PrintList(ListNode head)
        {
            ListNode n=head;
            while (n != null)
            {
                Console.Write(n.val + " ");
                n = n.next;
            }
            Console.WriteLine();
        }
        public static ListNode ArrayToListNode(int[] Array,int pos)     //晚点研究怎么实现环形链表
        {
            if (Array == null)
            {
                return null;
            }
            ListNode head = null, tail = null;
            ListNode Temp=null;
            for (int i = 0; i < Array.Length; i++)
            {
                if (head == null)
                {
                    head = tail = new ListNode(Array[i]);
                    tail = tail.next;
                }
                else
                {
                    tail = new ListNode(Array[i]);
                    if (i == pos)
                    {
                        Temp = tail;
                    }
                    tail = tail.next;
                    
                }
            }
            if(pos>=0)
            {
                tail = Temp;
            }
            return head;
        }
    }
}
