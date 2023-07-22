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
        public int PivotIndex(int[] nums)
        {
            int total = 0;
            foreach (int num in nums)
            {
                total += num;
            }
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum - nums[i] == total - sum)
                {
                    return i;
                }
            }
            return -1;
        }//Runtime:119 ms Beats:31.71% Memory:46 MB Beats:46.57%
    }
}
