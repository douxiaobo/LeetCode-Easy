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
        public int MaxProductDifference(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length - 1] * nums[nums.Length - 2] - nums[0] * nums[1];
        }
    }//Runtime:114 ms Beats:74.42% Memory:46 MB Beats:11.63%
}
