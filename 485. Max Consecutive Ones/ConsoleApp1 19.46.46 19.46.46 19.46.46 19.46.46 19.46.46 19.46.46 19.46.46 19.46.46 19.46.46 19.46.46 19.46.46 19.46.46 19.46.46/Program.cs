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
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int res = 0;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    sum += 1;
                }
                else if (nums[i] == 0)
                {
                    sum = 0;
                }
                if (sum > res)
                {
                    res = sum;
                }
            }
            return res;
        }//Runtime:144 ms Beats:9.97% Memory:52.6 MB Beats:43.40%
    }
}
