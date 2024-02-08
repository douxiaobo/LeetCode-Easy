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
        public int MinCostClimbingStairs(int[] cost)
        {
            int[] dp = new int[cost.Length + 1];
            dp[0] = 0;
            dp[1] = 0;
            for (int i = 2; i <= cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
            }
            return dp[cost.Length];
        }//Runtime:83 ms Beats:86.23% Memory:39.9 MB Beats:15.52%
        public int MinCostClimbingStairs1(int[] cost)
        {
            int[] dp = new int[cost.Length + 1];
            dp[0] = 0;
            dp[1] = 0;
            for (int i = 2; i <= cost.Length; i++)
            {
                if ((dp[i - 1] + cost[i - 1]) > (dp[i - 2] + cost[i - 2]))
                {
                    dp[i] = dp[i - 2] + cost[i - 2];
                }
                else
                {
                    dp[i] = dp[i - 1] + cost[i - 1];
                }
            }
            return dp[cost.Length];
        }//Runtime:78 ms Beats:95.1% Memory:39.5 MB Beats:59.92%
        public int MinCostClimbingStairs2(int[] cost)
        {
            int length = 0;
            foreach (int num in cost)
            {
                length++;
            }
            int[] dp = new int[length + 1];
            dp[0] = 0;
            dp[1] = 0;
            for (int i = 2; i <= length; i++)
            {
                if ((dp[i - 1] + cost[i - 1]) > (dp[i - 2] + cost[i - 2]))
                {
                    dp[i] = dp[i - 2] + cost[i - 2];
                }
                else
                {
                    dp[i] = dp[i - 1] + cost[i - 1];
                }
            }
            return dp[length];
        }//Runtime:95 ms Beats:33.20% Memory:39.1 MB Beats:94.33%
        public int MinCostClimbingStairs3(int[] cost)
        {
            int length = 0;
            try
            {
                while (true)
                {
                    int element = cost[length];
                    length++;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
            int[] dp = new int[length + 1];
            dp[0] = 0;
            dp[1] = 0;
            for (int i = 2; i <= length; i++)
            {
                if ((dp[i - 1] + cost[i - 1]) > (dp[i - 2] + cost[i - 2]))
                {
                    dp[i] = dp[i - 2] + cost[i - 2];
                }
                else
                {
                    dp[i] = dp[i - 1] + cost[i - 1];
                }
            }
            return dp[length];
        }//Runtime:88 ms Beats:70.45% Memory:40.8 MB Beats:9.72%
        public int MinCostClimbingStairs4(int[] cost)
        {
            int dp0 = 0;
            int dp1 = 0;
            for (int i = 2; i <= cost.Length; i++)
            {
                int dpi = Math.Min(dp1 + cost[i - 1], dp0 + cost[i - 2]);
                dp0 = dp1;
                dp1 = dpi;
            }
            return dp1;
        }//Runtime:90 ms Beats:59.11% Memory:39.2 MB Beats:92.44%
        public int MinCostClimbingStairs5(int[] cost)
        {
            int dp0 = 0;
            int dp1 = 0;
            for (int i = 2; i <= cost.Length; i++)
            {
                int dpi;
                if ((dp1 + cost[i - 1]) > (dp0 + cost[i - 2]))
                {
                    dpi = dp0 + cost[i - 2];
                }
                else
                {
                    dpi = dp1 + cost[i - 1];
                }
                dp0 = dp1;
                dp1 = dpi;
            }
            return dp1;
        }//Runtime:85 ms Beats:80.97% Memory:39.6 MB Beats：48.4%
        public int MinCostClimbingStairs6(int[] cost)
        {
            int[] dp = new int[cost.Length];
            dp[0] = cost[0];
            dp[1] = cost[1];
            for (int i = 2; i < cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1], dp[i - 2]) + cost[i];
            }
            return Math.Min(dp[cost.Length - 1], dp[cost.Length - 2]);
        }//Runtime:93 ms Beats:42.78% Memory:39.6 MB Beats:48.4%
        public int MinCostClimbingStairs７(int[] cost)
        {
            int len = cost.Length;
            return Math.Min(helper(cost, len - 2), helper(cost, len - 1));
        }
        private int helper(int[] cost, int i)
        {
            if (i < 2)
            {
                return cost[i];
            }
            return Math.Min(helper(cost, i - 2), helper(cost, i - 1)) + cost[i];
        }//Time Limit Exceeded
        public int MinCostClimbingStairs8(int[] cost)
        {
            int len = cost.Length;
            int[] dp = new int[len];
            dp[0] = cost[0];
            dp[1] = cost[1];
            for (int i = 2; i < len; i++)
            {
                dp[i] = Math.Min(dp[i - 2], dp[i - 1]) + cost[i];
            }
            return Math.Min(dp[len - 2], dp[len - 1]);
        }//Runtime：92 ms　Beats：48.14%　Memory：39.8 MB　Beats：47.48%
        public int MinCostClimbingStairs9(int[] cost)
        {
            int[] dp = new int[] { cost[0], cost[1] };
            for (int i = 2; i < cost.Length; i++)
            {
                dp[i % 2] = Math.Min(dp[0], dp[1]) + cost[i];
            }
            return Math.Min(dp[0], dp[1]);
        }//Runtime：89 ms　Beats：66.45%　Memory：39.3 MB　Beats：89.39%
    }
}
