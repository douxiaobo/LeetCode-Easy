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
        public bool IsPowerOfTwo(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else if (n > 1)
            {
                while (n > 1)
                {
                    if (n % 2 == 1)
                    {
                        return false;
                    }
                    n = n / 2;
                }
                return true;
            }
            else
            {
                return false;
            }
        }//Runtime:42 ms Beats:21.87% Memory:28.4 MB Beats:36.73%
        public bool IsPowerOfTwo1(int n)
        {
            if (n > 0)
            {
                return (n & (n - 1)) == 0;
            }
            return false;
        }//Runtime:35 ms Beats:72.79% Memory:28.5 MB Beats:36.73%
    }
}
