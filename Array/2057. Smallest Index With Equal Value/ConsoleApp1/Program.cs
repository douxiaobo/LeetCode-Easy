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
        public int SmallestEqual(int[] nums)
        {
            int smallest = 101;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 10 == nums[i] && i < smallest)
                {
                    smallest = i;
                }
            }
            if (smallest == 101)
            {
                return -1;
            }
            else
            {
                return smallest;
            }
        }
    }//Runtime:99 ms Beats:36% Memory:41.8 MB Beats:96%
}
