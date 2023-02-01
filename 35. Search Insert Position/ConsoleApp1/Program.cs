using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            int index = nums.Length;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] >= target)
                {
                    index = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3, 5, 6 };
            int target;
            target = 5;
            Console.WriteLine(SearchInsert(nums1,target));
            target = 2;
            Console.WriteLine(SearchInsert(nums1, target));
            target = 7;
            Console.WriteLine(SearchInsert(nums1, target));
            Console.ReadKey();
        }
    }
}
