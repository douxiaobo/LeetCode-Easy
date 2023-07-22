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
        public int FindLengthOfLCIS(int[] nums)
        {
            int index = 1;
            int max = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((i + 1 < nums.Length) && (nums[i] < nums[i + 1]))
                {
                    index++;
                    if (index > max)
                    {
                        max = index;
                    }
                }
                else
                {
                    index = 1;
                }
            }
            return max;
        }
    }
}
