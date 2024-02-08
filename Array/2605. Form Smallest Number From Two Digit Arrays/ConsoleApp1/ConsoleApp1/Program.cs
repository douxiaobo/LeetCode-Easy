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
        public int MinNumber(int[] nums1, int[] nums2)
        {
            int result = 0;
            int[] hash1 = new int[10];
            int small1 = 10;
            foreach (int num in nums1)
            {
                hash1[num]++;
                if (num < small1)
                {
                    small1 = num;
                }
            }
            int[] hash2 = new int[10];
            int small2 = 10;
            foreach (int num in nums2)
            {
                hash2[num]++;
                if (num < small2)
                {
                    small2 = num;
                }
            }
            for (int i = 1; i <= 9; i++)
            {
                if (hash1[i] == 1 && hash2[i] == 1)
                {
                    return i;
                }
            }
            if (small1 < small2)
            {
                result = small1 * 10 + small2;
            }
            else
            {
                result = small2 * 10 + small1;
            }
            return result;
        }
    }//Runtime:82 ms Beats:86% Memory:40.3 MB Beats:53%
}
