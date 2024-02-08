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
        public int CalPoints(string[] operations)
        {
            int total = 0;
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "+")
                {
                    int num = stack.Pop();
                    int sum = num + stack.Peek();
                    stack.Push(num);
                    stack.Push(sum);
                }
                else if (operations[i] == "D")
                {
                    int num = 2 * stack.Peek();
                    stack.Push(num);
                }
                else if (operations[i] == "C")
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(Convert.ToInt32(operations[i]));
                }

            }
            while (stack.Count > 0)
            {
                total += stack.Pop();
            }
            return total;
        }//Runtime:89 ms Beats:55.33% Memory:39.3 MB Beats:20.30%
    }
}
