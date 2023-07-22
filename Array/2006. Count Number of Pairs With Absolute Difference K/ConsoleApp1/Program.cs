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
        public int CountKDifference(int[] nums, int k)
        {
            int[] hash = new int[200];
            int min = 200;
            int max = 1;
            int res = 0;
            foreach (int num in nums)
            {
                hash[num]++;
                if (min > num)
                {
                    min = num;
                }
                if (max < num)
                {
                    max = num;
                }
            }
            for (int i = min; i <= max; i++)
            {
                if ((i + k <= max) && hash[i] > 0 && hash[i + k] > 0)
                {
                    res += hash[i] * hash[i + k];
                }
            }
            return res;
        }
    }
}
