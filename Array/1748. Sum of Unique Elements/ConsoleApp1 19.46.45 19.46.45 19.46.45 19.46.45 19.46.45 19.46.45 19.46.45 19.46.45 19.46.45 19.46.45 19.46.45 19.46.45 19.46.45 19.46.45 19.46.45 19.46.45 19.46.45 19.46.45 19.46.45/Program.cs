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
        public int SumOfUnique(int[] nums)
        {
            int result = 0;
            int[] index = new int[101];
            foreach (int num in nums)
            {
                index[num]++;
            }
            for (int i = 1; i <= 100; i++)
            {
                if (index[i] == 1)
                {
                    result += i;
                }
            }
            return result;
        }
    }//Runtime:89 ms Beats:53.15% Memory:38.2 MB Beats:90.91%
}
