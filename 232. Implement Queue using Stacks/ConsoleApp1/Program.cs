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
    public class MyQueue
    {
        int index;
        int[] stack;

        public MyQueue()
        {
            index = 0;
            stack = new int[100];
        }

        public void Push(int x)
        {
            stack[index++] = x;
        }

        public int Pop()
        {
            int num = stack[0];
            for (int i = 0; i < index; i++)
            {
                stack[i] = stack[i + 1];
            }
            index--;
            return num;
        }

        public int Peek()
        {
            return stack[0];
        }

        public bool Empty()
        {
            return index == 0;
        }
    }//Runtime:120 ms Beats:36.21% Memory:40.4 MB Beats:73.55%
    public class MyQueue1
    {
        Stack<int> stack;

        public MyQueue1()
        {
            stack = new Stack<int>();
        }

        public void Push(int x)
        {
            stack.Push(x);
        }

        public int Pop()
        {
            Stack<int> tmp = new Stack<int>();
            while (stack.Count > 1)
            {
                tmp.Push(stack.Pop());
            }
            int num = stack.Pop();
            while (tmp.Count > 0)
            {
                stack.Push(tmp.Pop());
            }
            return num;
        }

        public int Peek()
        {
            Stack<int> tmp = new Stack<int>();
            while (stack.Count > 1)
            {
                tmp.Push(stack.Pop());
            }
            int num = stack.Peek();
            while (tmp.Count > 0)
            {
                stack.Push(tmp.Pop());
            }
            return num;
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }
    }//Runtime:120 ms Beats:36.21% Memory:40.6 MB Beats:63.23%
}
/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
