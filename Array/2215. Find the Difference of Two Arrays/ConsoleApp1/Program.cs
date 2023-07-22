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
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            List<List<int>> result = new List<List<int>>();

            bool[] index = new bool[2001];
            for (int i = 0; i < nums2.Length; i++)
            {
                index[nums2[i] + 1000] = true;
            }
            List<int> tmp = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (index[nums1[i] + 1000] == false && !tmp.Contains(nums1[i]))
                {
                    tmp.Add(nums1[i]);
                }
            }
            result.Add(tmp);

            index = new bool[2001];
            for (int i = 0; i < nums1.Length; i++)
            {
                index[nums1[i] + 1000] = true;
            }
            tmp = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (index[nums2[i] + 1000] == false && !tmp.Contains(nums2[i]))
                {
                    tmp.Add(nums2[i]);
                }
            }
            result.Add(tmp);

            return result.Cast<IList<int>>().ToList();
        }
    }//Runtime:179 ms Beats:65.16% Memory:55.6 MB Beats:86.74%
}
