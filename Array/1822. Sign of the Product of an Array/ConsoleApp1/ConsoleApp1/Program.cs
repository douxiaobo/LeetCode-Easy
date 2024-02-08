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
        public int ArraySign(int[] nums)
        {
            int result = 1;
            foreach (int num in nums)
            {
                if (num < 0)
                {
                    result *= -1;
                }
                else if (num == 0)
                {
                    result = 0;
                    break;
                }
            }
            return result;
        }
    }//Runtime:87 ms Beats:26.76% Memory:39.8 MB Beats:35.68%
}
