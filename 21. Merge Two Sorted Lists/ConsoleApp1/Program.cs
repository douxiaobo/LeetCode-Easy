using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            public ListNode(int val=0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public class ListListNodeConversion
        {
            #region List集合转换为ListNode
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
            #endregion

            #region ListNode转换为List
            public static List<int> ListNodeToList(ListNode listNode)
            {
                if (listNode == null)
                {
                    return null;
                }

                var list = new List<int>();

                ListNode tail = listNode;
                while (tail != null)
                {
                    list.Add(tail.val);
                    tail = tail.next;
                }

                return list;
            }
            #endregion
        }
        public class ArrayListNodeConversion
        {
            public static ListNode ArrayToListNode(int[] Array)
            {
                if(Array == null)
                {
                    return null;
                }
                ListNode head=null, tail = null;
                for(int i=0;i<Array.Length;i++)
                {
                    if(head==null)
                    {
                        head= tail = new ListNode(Array[i]);
                    }
                    else
                    {
                        tail.next=new ListNode(Array[i]);
                        tail = tail.next;
                    }
                }
                return head;
            }
        }
        public static void Print(ListNode list)
        {
            ListNode current=list;
            while(current!=null)
            {
                if(current.next!=null)
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
        public static void Insert(ListNode Node, int np)
        {
            ListNode newNode = new ListNode(np);
            while (Node!=null)
            {
                Node.next = Node;                
            }
            Node.next = newNode;

        }
        public static ListNode MergeTwoLists2(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }
            ListNode head = new ListNode();
            ListNode tail = head;
            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    while (list2 != null)
                    {
                        tail.next = list2;
                        list2 = list2.next;
                        tail = tail.next;
                    }
                }
                else if (list2 == null)
                {
                    while (list1 != null)
                    {
                        tail.next = list1;
                        list1 = list1.next;
                        tail = tail.next;
                    }
                }
                else if (list1.val >= list2.val)
                {
                    tail.next = list2;
                    list2 = list2.next;
                    tail = tail.next;
                }
                else
                {
                    tail.next = list1;
                    list1 = list1.next;
                    tail = tail.next;
                }
                //tail=tail.next;   不可行
            }
            return head.next;
        }
        public static ListNode MergeTwoLists1(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }
            ListNode head = null;
            ListNode tail = null;
            while (list1 != null || list2 != null)
            {
                ListNode nextNode = new ListNode();
                if ((list1 == null) || ((list2 != null) && (list1.val > list2.val)))
                {
                    nextNode.val = list2.val;
                    list2 = list2.next;
                }
                else if ((list2 == null) || ((list1 != null) && (list1.val <= list2.val)))     //if后面语句可删除，意思一样的。
                {
                    nextNode.val = list1.val;
                    list1 = list1.next;
                }
                if (head == null)
                {
                    head = nextNode;
                }
                if (tail != null)
                {
                    tail.next = nextNode;       //这个语句完成后，head和tail同部syns
                }
                tail = nextNode;
            }
            return head;        //如果写上tail，结果是最后一个结点的。
        }//Runtime 90 ms, Beats 57.38%; Memory 40.1 MB,Beats 10.70%
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else if (list1 == null)
            {
                return list2;
            }
            else if (list2 == null)
            {
                return list1;
            }
            ListNode head = new ListNode();
            ListNode result = head;
            while (list1 != null && list2 != null)
            {
                if (list1.val > list2.val)
                {
                    result.next = list2;
                    list2 = list2.next;
                }
                else if (list1.val <= list2.val)
                {
                    result.next = list1;
                    list1 = list1.next;
                }
                result = result.next;
            }
            if (list1 == null)
            {
                result.next = list2;
            }
            if (list2 == null)
            {
                result.next = list1;
            }
            return head.next;       //如果不写.next，链表的开头是0。
        }//Runtime:66 ms, Beats 99.98%; Memory: 39.9 MB, Beats 35.45%

        static void Main(string[] args)
        {
            List<int> l1 = new List<int>() { 1, 2, 4 };
            List<int> l2=new List<int>() { 1, 3, 4 };
            var l1tolist1 =ListListNodeConversion.ListToListNode(l1);
            var l2tolist2=ListListNodeConversion.ListToListNode(l2);
            Print(l1tolist1);
            Print(l2tolist2);
            var Listnode = MergeTwoLists1(l1tolist1, l2tolist2);
            Print(Listnode); 
            int[] array1 = new int[] {-9,3 };
            int[] array2 = new int[] {5,7 };
            var array1tolist1 = ArrayListNodeConversion.ArrayToListNode(array1);
            var array1tolist2 = ArrayListNodeConversion.ArrayToListNode(array2);
            Print(array1tolist1);
            Print(array1tolist2);
            var Listnode1 = MergeTwoLists2(array1tolist1, array1tolist2);
            Print(Listnode1);
            Console.ReadKey();
        }
    }
}
