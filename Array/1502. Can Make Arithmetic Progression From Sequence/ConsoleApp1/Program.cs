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
        public bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
            int num = arr[1] - arr[0];
            int i = 1;
            while (i < arr.Length)
            {
                if (arr[i] - arr[i - 1] != num)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }//Runtime:107 ms Beats:24.25% Memory:40.4 MB Beats:82.35%
}
