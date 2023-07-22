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
        public int MaximumWealth(int[][] accounts)
        {
            int richest = 0;
            foreach (int[] account in accounts)
            {
                int sum = 0;
                foreach (int num in account)
                {
                    sum += num;
                }
                if (richest < sum)
                {
                    richest = sum;
                }
            }
            return richest;
        }
    }//Runtime:94 ms Beats:41.89% Memory:39.3 MB Beats:40.82%
}
