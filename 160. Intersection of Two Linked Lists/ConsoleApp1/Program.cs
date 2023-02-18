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
        }
        static void Main(string[] args)
        {
        }
    }
}
