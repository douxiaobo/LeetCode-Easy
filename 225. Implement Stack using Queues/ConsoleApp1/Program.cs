using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class MyStack
    {
        int left;
        int right;
        int[] queue;

        public MyStack()
        {
            left = 0;
            right = 0;
            queue = new int[100];
        }

        public void Push(int x)
        {
            queue[right++] = x;
        }

        public int Pop()
        {
            return queue[(right--) - 1];
        }

        public int Top()
        {
            return queue[right - 1];
        }

        public bool Empty()
        {
            return left == right;
        }
    }//Runtime:125 ms Beats:12.96% Memory:40.8 MB Beats:37.87%
}
/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
