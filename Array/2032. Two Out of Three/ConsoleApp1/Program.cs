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
        public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
        {
            List<int> res = new List<int>();
            int[] index1 = new int[100];
            foreach (int num in nums1)
            {
                index1[num - 1]++;
            }
            int[] index2 = new int[100];
            foreach (int num in nums2)
            {
                index2[num - 1]++;
            }
            int[] index3 = new int[100];
            foreach (int num in nums3)
            {
                index3[num - 1]++;
            }
            for (int i = 0; i < 100; i++)
            {
                if ((index1[i] > 0 && index2[i] > 0) || (index1[i] > 0 && index3[i] > 0) || (index2[i] > 0 && index3[i] > 0))
                {
                    res.Add(i + 1);
                }
            }
            return res;
        }
    }
}
