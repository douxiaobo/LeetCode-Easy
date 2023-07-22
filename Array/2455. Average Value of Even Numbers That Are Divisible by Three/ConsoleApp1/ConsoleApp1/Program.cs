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
        public int AverageValue(int[] nums)
        {
            int count = 0, result = 0;
            foreach (int num in nums)
            {
                if (num % 6 == 0)
                {
                    result += num;
                    count++;
                }
            }
            return count == 0 ? 0 : result / count;
        }
    }//Runtime:93 ms Beats:71.15% Memory:40.6 MB Beats:69.23%
}
