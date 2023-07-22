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
        public int CountPairs(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] == nums[j]) && ((i * j) % k == 0))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }//Runtime:95 ms Beats:43.55% Memory:39.3 MB Beats:75.81%
}
