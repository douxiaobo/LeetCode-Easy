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
        public int FindGCD(int[] nums)
        {
            int largest = nums[0];
            int smallest = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > largest)
                {
                    largest = nums[i];
                }
                if (nums[i] < smallest)
                {
                    smallest = nums[i];
                }
            }
            int divisor = smallest;
            while (divisor > 0)
            {
                if (largest % divisor == 0 && smallest % divisor == 0)
                {
                    break;
                }
                divisor--;
            }
            return divisor;
        }
    }//Runtime:89 ms Beats:70.91% Memory:39.8 MB Beats:35.45%
}
