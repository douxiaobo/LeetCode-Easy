using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int[] TwoSum(int[]nums,int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }
        static void Main(string[] args)
        {
            int[] nums1 = new int[]{ 2, 7, 11, 15 };
            Console.WriteLine(TwoSum(nums1, 9)[0]+" "+ TwoSum(nums1, 9)[1]);

            int[] nums2 = new int[] { 3, 2, 4 };
            Console.WriteLine(TwoSum(nums2, 6)[0] + " " + TwoSum(nums2, 6)[1]);

            int[] nums3 = new int[] { 3, 3 };
            Console.WriteLine(TwoSum(nums3, 6)[0] + " " + TwoSum(nums3, 6)[1]);
            Console.ReadKey();
        }
    }
}
