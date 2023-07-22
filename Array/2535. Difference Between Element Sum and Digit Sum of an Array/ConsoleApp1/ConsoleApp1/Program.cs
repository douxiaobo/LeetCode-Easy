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
        public int DifferenceOfSum(int[] nums)
        {
            int element = 0, digit = 0;
            foreach (int num in nums)
            {
                element += num;
                int tmp = num;
                while (tmp > 0)
                {
                    digit += tmp % 10;
                    tmp /= 10;
                }
            }
            return Math.Abs(element - digit);
        }
    }
}
