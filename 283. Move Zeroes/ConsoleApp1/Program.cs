using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void MoveZeroes(int[] nums)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                    j++;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 0, 3, 12 };
            Print(nums1);
            MoveZeroes(nums1);
            Print(nums1);
            int[] nums2 = { 0 };
            Print(nums2);
            MoveZeroes(nums2);
            Print(nums2);
            Console.ReadKey();
        }
        public static void Print(int[] nums)
        {
            foreach (int i in nums) { Console.Write(i + " "); }
            Console.WriteLine();
        }
    }
}
