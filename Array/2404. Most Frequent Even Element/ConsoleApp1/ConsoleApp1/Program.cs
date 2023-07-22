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
        public int MostFrequentEven(int[] nums)
        {
            int[] index = new int[100001];
            int small = 100001;
            int large = 0;
            int count = 0;
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    index[num]++;
                    if (small > num)
                    {
                        small = num;
                    }
                    if (large < num)
                    {
                        large = num;
                    }
                    if (index[num] > count)
                    {
                        count = index[num];
                    }
                }
            }
            for (int i = small; i <= large; i++)
            {
                if (index[i] == count)
                {
                    return i;
                }
            }
            return -1;
        }
    }//Runtime:129 ms Beats:94.3% Memory:42.2 MB Beats:94.3%
}
