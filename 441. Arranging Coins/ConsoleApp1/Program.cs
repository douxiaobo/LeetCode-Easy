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
        public int ArrangeCoins(int n)
        {
            int i = 1;
            while (n >= i)
            {
                n -= i;
                i++;
            }
            return i - 1;
        }//Runtime:29 ms Beats:63.86% Memory:27 MB Beats:9.41%
    }
}
