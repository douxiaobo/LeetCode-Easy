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
        public int MaximumDifference(int[] nums)
        {
            int maximum = -1;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i] && nums[j] - nums[i] > maximum)
                    {
                        maximum = nums[j] - nums[i];
                    }
                }
            }
            return maximum;
        }
    }//Runtime:93 ms Beats:45.78% Memory:38.8 MB Beats:75.90%
    public class Solution1
    {
        public int MaximumDifference(int[] nums)
        {
            int maximum = -1;
            int minimum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > minimum)
                {
                    maximum = Math.Max(maximum, nums[i] - minimum);
                }
                else
                {
                    minimum = nums[i];
                }
            }
            if (maximum == 0)
            {
                return -1;
            }
            else
            {
                return maximum;
            }
        }
    }//Runtime:90 ms Beats:63.86% Memory:39.1 MB Beats:37.35%
}
