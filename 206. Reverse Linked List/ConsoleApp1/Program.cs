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
        public ListNode ReverseList13(ListNode head)    //双指针法
        {
            ListNode pre = null;
            ListNode cur = head;
            ListNode temp;
            while (cur != null)
            {
                temp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = temp;
            }
            return pre;
        }//Runtime:83 ms Beats:78.9% Memory:38.8 MB Beats:74.91%
        public ListNode ReverseList14(ListNode head)    //递归法
        {
            return reverse(null, head);
        }
        ListNode reverse(ListNode pre, ListNode cur)
        {
            if (cur == null)
            {
                return pre;
            }
            ListNode temp = cur.next;
            cur.next = pre;
            return reverse(cur, temp);
        }//Runtime:81 ms Beats:85.83% Memory:39.3 MB Beats:5.4%
        public ListNode ReverseList15(ListNode head)    //从后往前翻转指针指向方法
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return head;
            }
            ListNode last = ReverseList15(head.next);
            head.next.next = head;
            head.next = null;
            return last;
        }//Runtime:98 ms Beats:9.59% Memory:38.8 MB Beats:74.91%
        public ListNode ReverseList16(ListNode head)    //使用虚拟头结点，通过头插法实现链表的翻转。
        {
            ListNode dumpyHead = new ListNode(-1);
            dumpyHead.next = null;
            ListNode cur = head;
            while (cur != null)
            {
                ListNode temp = cur.next;
                cur.next = dumpyHead.next;
                dumpyHead.next = cur;
                cur = temp;
            }
            return dumpyHead.next;
        }//Runtime：94 ms Beats：22.30% Memory：38.7 MB Beats：84.30%
        public ListNode ReverseList17(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            if (head.next == null)
            {
                return head;
            }
            Stack<ListNode> stack = new Stack<ListNode>();
            ListNode cur = head;
            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.next;
            }
            ListNode pHead = new ListNode();
            cur = pHead;
            while (stack.Count != 0)
            {
                ListNode node = stack.Pop();
                cur.next = node;
                cur = cur.next;
            }
            cur.next = null;
            return pHead.next;
        }//Runtime：83 ms Beats：78.9% Memory：38.9 MB Beats：61.90%
        public ListNode ReverseList8(ListNode head)
        {
            ListNode prev = null;
            ListNode cur = head;
            while (cur != null)
            {
                ListNode next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
            return prev;
        }//Runtime:90 ms Beats:40.54% Memory:39.2 MB Beats:17.66%
    }
}
