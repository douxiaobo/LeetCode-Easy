using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int[] GetConcatenation(int[] nums)
        {
            int len = nums.Length;
            int[] ans = new int[len * 2];
            for (int i = 0; i < len; i++)
            {
                ans[i] = ans[i + len] = nums[i];
            }
            return ans;
        }
        static void Main(string[] args)
        {
        }
    }
}
