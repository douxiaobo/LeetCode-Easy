using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int MySqrt(int x)
        {
            int low = 1, high = x / 2, mid = 0, ans = 0;
            if (x < 2) return x;
            while (low <= high)
            {
                mid = (high - low) / 2 + low;
                if (mid <= x / mid)     //可能是数字太大的原因。
                {
                    ans = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;
        }//Runtime 21 ms Beats 91.20% Memory 26.8 MB Beats 15.22%
        public static int MySqrt1(int x)
        {
            int low = 1, high = x / 2, mid = 0, ans = 0;
            if (x < 2) return x;
            while (low <= high)
            {
                mid = (high - low) / 2 + low;
                if (mid == x / mid)
                {
                    return mid;
                }
                else if (mid < x / mid)
                {
                    ans = mid;
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ans;
        }//Runtime 14 ms Beats 99.40% Memory 26.8 MB Beats 34.48%
        static void Main(string[] args)
        {
            Console.WriteLine(MySqrt(4));
            Console.WriteLine(MySqrt(8));
            Console.ReadKey();
        }
        public int MySqrt2(int x)
        {
            int left = 1;
            int right = x;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid <= x / mid)
                {
                    if ((mid + 1) > x / (mid + 1))
                    {
                        return mid;
                    }
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return 0;
        }//Runtime:28 ms Beats:63.72% Memory:26.3 MB Beats:99.30%
    }
}
