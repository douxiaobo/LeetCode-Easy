using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int SingleNumber(int[] nums)
        {
            int num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num ^= nums[i];
            }
            return num;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 2, 1 };
            Console.WriteLine(SingleNumber(nums1));
            int[] nums2 = { 4, 1, 2, 1, 2 };
            Console.WriteLine(SingleNumber(nums2));
            int[] nums3 = { 1 };
            Console.WriteLine(SingleNumber(nums3));
            Console.ReadKey();
        }
        public int SingleNumber1(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result ^= num;
            }
            return result;
        }
    }
}
