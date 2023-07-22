using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        }//Runtime:18 ms Beats:96.19% Memory:26.6 MB Beats:55.8%
        public int Fib1(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            int[] dp = new int[2];
            dp[0] = 0;
            dp[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                int sum = dp[0] + dp[1];
                dp[0] = dp[1];
                dp[1] = sum;
            }
            return dp[1];
        }//Runtime:16 ms Beats:98.66% Memory:26.4 MB Beats:69.28%
        public int Fib2(int n)
        {
            if (n < 2) return n;
            return Fib2(n - 1) + Fib2(n - 2);
        }//Runtime:39 ms Beats:25.35% Memory:26.7 MB Beats:33.33%
        static void Main(string[] args)
        {
        }
    }
}
