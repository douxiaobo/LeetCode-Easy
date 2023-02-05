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
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 2, 3 };
            Console.WriteLine(MajorityElement(nums1));
            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(nums2));
            Console.ReadKey();
        }
    }
}
