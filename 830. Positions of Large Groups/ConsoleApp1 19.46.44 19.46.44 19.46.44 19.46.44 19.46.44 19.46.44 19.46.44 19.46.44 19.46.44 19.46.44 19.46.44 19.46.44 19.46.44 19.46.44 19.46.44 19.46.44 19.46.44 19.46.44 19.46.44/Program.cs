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
        public int FindLucky(int[] arr)
        {
            int[] index = new int[501];
            int min = 500;
            int max = 0;
            foreach (int num in arr)
            {
                index[num]++;
                if (min > num)
                {
                    min = num;
                }
                if (max < num)
                {
                    max = num;
                }
            }
            for (int i = max; i >= min; i--)
            {
                if (index[i] == i)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
