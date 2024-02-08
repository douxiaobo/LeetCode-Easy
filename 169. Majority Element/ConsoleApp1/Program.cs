using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }//Runtime 103 ms Beats:77.59% Memory:43.8 MB Beats:67.80%
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 2, 3 };
            Console.WriteLine(MajorityElement(nums1));
            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(nums2));
            Console.ReadKey();
        }
        public int MajorityElement1(int[] nums)
        {
            int res = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    res = nums[i];
                }
                count += (nums[i] == res) ? 1 : -1;
            }
            return res;
        }//Runtime 105 ms Beats:70.95% Memory:44 MB Beats:24.73%
    }
}
