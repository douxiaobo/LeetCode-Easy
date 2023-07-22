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
            public ListNode(int x) { val = x; }
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null && headB == null)
            {
                return null;
            }
            else if (headA != null && headB == null)
            {
                return headA;
            }
            else if (headA == null && headB != null)
            {
                return headB;
            }
            else
            {
                ListNode LNA = headA;
                while (LNA != null)
                {
                    ListNode LNB = headB;
                    while (LNB != null)
                    {
                        if (LNA == LNB)
                        {
                            return LNA;
                        }
                        LNB = LNB.next;
                    }
                    LNA = LNA.next;
                }
            }
            return null;
        }//Runtime:699 ms Beats:5.12% Memory:51.8 MB Beats:66.45%
        static void Main(string[] args)
        {
        }
        public ListNode GetIntersectionNode1(ListNode headA, ListNode headB)
        {
            int count1 = countList(headA);
            int count2 = countList(headB);
            int delta = Math.Abs(count1 - count2);
            ListNode longer = count1 > count2 ? headA : headB;
            ListNode shorter = count1 > count2 ? headB : headA;
            ListNode node1 = longer;
            for (int i = 0; i < delta; i++)
            {
                node1 = node1.next;
            }
            ListNode node2 = shorter;
            while (node1 != node2)
            {
                node2 = node2.next;
                node1 = node1.next;
            }
            return node1;
        }
        private int countList(ListNode head)
        {
            int count = 0;
            while (head != null)
            {
                count++;
                head = head.next;
            }
            return count;
        }//Runtime:118 ms 70.91% Memory:52 MB Beats:45.29%
    }
}
