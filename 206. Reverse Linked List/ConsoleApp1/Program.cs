using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    class LinkedList
    {
        Node head;
        public void ReverseList()
        {
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
        public void PrintList()
        {
            Node n = head;
            while (n != null)
            {
                Console.Write(n.data + " ");
                n = n.next;
            }
        }
    }
    internal class Program
    {
        public static ListNode ReverseList(ListNode head)       //可能不对。
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode cur = head.next;
            ListNode next = null;
            while (cur != null)
            {
                next = cur.next;
                cur.next = head;
                head.next = next;
                cur = next;
            }
            return head;
        }
        static void Main(string[] args)
        {
            ListNode List1 = ListToListNode(new List<int> { 1, 2, 3, 4, 5 });
            Print(List1);
            Print(ReverseList(List1));
            ListNode List2 = ListToListNode(new List<int> { 1, 2 });
            Print(List2);
            Print(ReverseList(List2));
            ListNode List3 = ListToListNode(new List<int> {  });
            Print(List3);
            Print(ReverseList(List3));
            Console.ReadKey();
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
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
                if (cur.next != null)
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
        public ListNode ReverseListfromChatGPT(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode prev = null;
            ListNode current = head;
            ListNode next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            return head;
        }
        public ListNode ReverseList10(ListNode head)    //from Sargerous
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode resultNode = null;
            while (head != null)
            {
                resultNode = new ListNode(head.val, resultNode);
                head = head.next;
            }
            return resultNode;
        }
        public ListNode ReverseList11(ListNode head)    //from Sakhile_Msibi
        {
            if (head == null || head.next == null)
            {
                return null;
            }
            ListNode pre = null;
            ListNode cur = head;
            ListNode next = null;
            while (cur != null)
            {
                next = cur.next;
                cur.next = pre;
                pre = cur;
                cur = next;
            }
            head = pre;
            return head;
        }
        public ListNode ReverseList12(ListNode head)        //luongminhduy
        {
            Stack<int> st = new Stack<int>();
            ListNode temp = head;
            while (temp != null)
            {
                st.Push(temp.val);
                temp = temp.next;
            }
            temp = head;
            while (temp != null)
            {
                temp.val = st.Pop();
                temp = temp.next;
            }
            return head;
        }
    }
}
