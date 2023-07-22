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
        public int GetCommon(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    return nums1[i];
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return -1;
        }
    }//Runtime:172 ms Beats:87.67% Memory:48.9 MB Beats:72.60%
    public class Solution1
    {
        public int GetCommon(int[] nums1, int[] nums2)
        {
            int small = nums1[0] > nums2[0] ? nums2[0] : nums1[0];
            int large = nums1[nums1.Length - 1] > nums2[nums2.Length - 1] ? nums1[nums1.Length - 1] : nums2[nums2.Length - 1];
            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            foreach (int num in nums1)
            {
                if (!dict1.ContainsKey(num))
                {
                    dict1[num] = 0;
                }
                dict1[num]++;
            }
            foreach (int num in nums2)
            {
                if (!dict2.ContainsKey(num))
                {
                    dict2[num] = 0;
                }
                dict2[num]++;
            }
            for (int i = small; i <= large; i++)
            {
                if (dict1.ContainsKey(i) && dict2.ContainsKey(i))
                {
                    return i;
                }
            }
            return -1;
        }
    }//Runtime:1706 ms Beats:5.48% Memory:68.2 MB Beats:5.48%
}
