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
        public int SearchInsert1(int[] nums, int target)
        {
            int left = 0, right = nums.Length, index = 0;
            if (target < nums[left])
            {
                return 0;
            }
            else if (nums[right - 1] < target)
            {
                return right;
            }
            while (left < right)
            {
                int middle = left + ((right - left) / 2);
                if (target < nums[middle])
                {
                    right = middle;
                    index = right;
                }
                else if (nums[middle] < target)
                {
                    left = middle + 1;
                    index = left;
                }
                else
                {
                    index = middle;
                    break;
                }
            }
            return index;
        }//Runtime:89 ms Beats:56.78% Memory:39.2 MB Beats:73.84%
        public int SearchInsert2(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] >= target)
                {
                    if (mid == 0 || nums[mid - 1] < target)
                    {
                        return mid;
                    }
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return nums.Length;
        }//Runtime:90 ms Beats:50.56% Memory:39.3 MB Beats:61%
    }
}
