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
        public int MaximumProduct(int[] nums)
        {
            int max = 1;
            Array.Sort(nums);
            int l = nums.Length - 1;
            int n = 3;
            while (n > 0)
            {
                max *= nums[l--];
                n--;
            }
            if (max < nums[0] * nums[1] * nums[nums.Length - 1])
            {
                max = nums[0] * nums[1] * nums[nums.Length - 1];
            }
            return max;
        }//Runtime:130 ms Beats:70.19% Memory:49.9 MB Beats:68.27%
        public int MaximumProduct1(int[] nums)
        {
            Array.Sort(nums);
            int max1 = nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];
            int max2 = nums[0] * nums[1] * nums[nums.Length - 1];
            return Math.Max(max1, max2);
        }//Runtime:134 ms Beats:59.62% Memory:50.4 MB Beats:16.35%
    }
}
