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
        public int FindSpecialInteger(int[] arr)
        {
            int max = arr.Length / 4;
            int res = arr[0];
            int[] index = new int[100001];
            foreach (int num in arr)
            {
                index[num]++;
                if (index[num] > max)
                {
                    max = index[num];
                    res = num;
                }
            }
            return res;
        }
    }//Runtime:96 ms Beats:84.78% Memory:42.6 MB Beats:6.52%
}
