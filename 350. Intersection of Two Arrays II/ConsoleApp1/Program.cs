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
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            int[] hashnums1 = new int[1001];
            int[] hashnums2 = new int[1001];
            List<int> result = new List<int>();
            for (int i = 0; i < 1001; i++)
            {
                hashnums1[i] = 0;
                hashnums2[i] = 0;
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                hashnums1[nums1[i]]++;
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                hashnums2[nums2[i]]++;
            }
            for (int i = 0; i < 1001; i++)
            {
                int temp;
                if (hashnums1[i] > 0 && hashnums2[i] > 0)
                {
                    if (hashnums1[i] >= hashnums2[i])
                    {
                        temp = hashnums2[i];
                    }
                    else
                    {
                        temp = hashnums1[i];
                    }
                    for (int j = 0; j < temp; j++)
                    {
                        result.Add(i);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
