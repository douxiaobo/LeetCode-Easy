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
        public int MaxAscendingSum(int[] nums)
        {
            int sum = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0 || (i > 0 && nums[i] <= nums[i - 1]))
                {
                    sum = nums[i];
                }
                else
                {
                    sum += nums[i];
                }
                if (sum > max)
                {
                    max = sum;
                }
            }
            return max;
        }
    }//Runtime：95 ms Beats：16.67% Memory：38.6 MB Beats:27.78%
}
