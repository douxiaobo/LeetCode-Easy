using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public bool IsHappy(int n)
        {
            HashSet<int> hs = new HashSet<int>();
            while (n != 1)
            {
                int a = n;
                n = 0;
                while (a > 0)
                {
                    n += (a % 10) * (a % 10);
                    a = a / 10;
                }
                if (!hs.Contains(n))
                {
                    hs.Add(n);
                }
                else if (hs.Contains(n))
                {
                    return false;
                }
            }
            return true;
        }//Runtime：38 ms Beats：65.27% Memory：28.9 MB Beats：62.86%
        static void Main(string[] args)
        {
        }
    }
}
