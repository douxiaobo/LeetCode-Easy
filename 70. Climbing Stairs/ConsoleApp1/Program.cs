using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int ClimbStairs(int n)
        {
            int a = 1, b = 1;
            for (int i = 2; i <= n; i++)
            {
                int c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
        static void Main(string[] args)
        {
        }
    }
}
