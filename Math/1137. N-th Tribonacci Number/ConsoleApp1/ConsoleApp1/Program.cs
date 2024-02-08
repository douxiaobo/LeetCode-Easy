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
        public int Tribonacci(int n)
        {
            int t0 = 0, t1 = 1, t2 = 1;
            int result = 0;
            int[] t = new int[3] { 0, 1, 1 };
            if (n <= 2)
            {
                return t[n];
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    result = t0 + t1 + t2;
                    t0 = t1;
                    t1 = t2;
                    t2 = result;
                }
            }
            return result;
        }
    }
    public class Solution1
    {
        public int Tribonacci(int n)
        {
            int[] t = new int[3] { 0, 1, 1 };
            if (n <= 2)
            {
                return t[n];
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    int temp = sum(t);
                    t[0] = t[1];
                    t[1] = t[2];
                    t[2] = temp;
                }
            }
            return t[2];
        }
        public int sum(int[] t)
        {
            int total = 0;
            foreach (int i in t)
            {
                total += i;
            }
            return total;
        }
    }//Runtime:18 ms Beats:83.30% Memory:26.5 MB Beats:85.91%
    public class Solution2
    {
        public int Tribonacci(int n)
        {
            int[] t = new int[3] { 0, 1, 1 };
            if (n <= 2)
            {
                return t[n];
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    int total = 0;
                    foreach (int temp in t)
                    {
                        total += temp;
                    }
                    t[0] = t[1];
                    t[1] = t[2];
                    t[2] = total;
                }
            }
            return t[2];
        }
    }
}
