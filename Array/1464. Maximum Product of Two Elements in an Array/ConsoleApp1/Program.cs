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
        public int MaxProduct(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] - 1) * (nums[j] - 1) > max)
                    {
                        max = (nums[i] - 1) * (nums[j] - 1);
                    }
                }
            }
            return max;
        }
    }//Runtime:89 ms Beats:69.78% Memory:39.3 MB Beats:46.4%
}
