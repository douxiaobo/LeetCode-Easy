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
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            int[] counts = new int[1001];
            foreach (int num in arr1)
            {
                counts[num]++;
            }
            int i = 0;
            foreach (int num in arr2)
            {
                while (counts[num] > 0)
                {
                    arr1[i++] = num;
                    counts[num]--;
                }
            }
            for (int num = 0; num < counts.Length; num++)
            {
                while (counts[num] > 0)
                {
                    arr1[i++] = num;
                    counts[num]--;
                }
            }
            return arr1;
        }//Runtime:157 ms Beats:8.6% Memory:42.2 MB Beats:72.58%
    }
}
