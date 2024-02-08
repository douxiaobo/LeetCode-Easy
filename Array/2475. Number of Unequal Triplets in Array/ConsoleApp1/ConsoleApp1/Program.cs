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
        public int UnequalTriplets(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] != nums[j] && nums[i] != nums[k] && nums[j] != nums[k])
                        {
                            result++;
                        }
                    }
                }
            }
            return result;
        }
    }//Runtime:90 ms Beats:71.88% Memory:38.5 MB Beats:56.25%
}
