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
        public bool IsUgly(int n)
        {
            if (n == 0)
            {
                return false;
            }
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else if (n % 3 == 0)
                {
                    n = n / 3;
                }
                else if (n % 5 == 0)
                {
                    n = n / 5;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }//Runtime:28 ms Beats:97.36% Memory:28.4 MB Beats:23.76%
    }
}
