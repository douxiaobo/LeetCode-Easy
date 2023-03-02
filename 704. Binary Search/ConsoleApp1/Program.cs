using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            if (nums[left] > target || nums[right] < target)
            {
                return -1;
            }
            else
            {
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (nums[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        return mid;
                    }
                }
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 },9));
            Console.WriteLine(Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2));
            Console.ReadKey();
        }
    }
}
