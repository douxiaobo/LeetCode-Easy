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
    public class Solution
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int num = 0;
            foreach (string operation in operations)
            {
                foreach (char ch in operation)
                {
                    if (ch == '+')
                    {
                        num++;
                        break;
                    }
                    if (ch == '-')
                    {
                        num--;
                        break;
                    }
                }
            }
            return num;
        }
    }//Runtime:92 ms Beats:44.78% Memory:40 MB Beats:68.52%
}
