using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public bool IsPerfectSquare(int num)
        {
            long low = 0, high = num;
            while (low <= high)
            {
                long mid = low + (high - low) / 2;
                if (mid * mid == num)
                {
                    return true;
                }
                else if (mid * mid > num)
                {
                    high = mid - 1;
                }
                else if (mid * mid < num)
                {
                    low = mid + 1;
                }
            }
            return false;
        }//Runtime 42 ms Beats 38.34% Memory 28.4 MB Beats 31.63%
        static void Main(string[] args)
        {
        }
    }
}
