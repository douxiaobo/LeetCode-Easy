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
        }//Runtime:170ms, Beats:69.63%; Memory:54MB, Beats:37.41%
        public void MoveZeroes1(int[] nums)
        {
            int i = 0, j = 0;
            while (i < nums.Length)
            {
                if (nums[i] != 0)
                {
                    int tmp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = tmp;
                    j++;
                }
                i++;
            }
        }//Runtime:180ms, Beats:49.91%; Memory:54.3MB, Beats:12.68%
        public void MoveZeroes2(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    index++;
                }
                else if (index > 0)
                {
                    int tmp = nums[i];
                    nums[i] = 0;
                    nums[i - index] = tmp;
                }
            }
        }//Runtime:165ms, Beats:80.63%; Memory:54.1MB, Beats:37.41%
        public void MoveZeroes3(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    index++;
                }
                else if (index > 0)
                {
                    nums[i - index] = nums[i];
                    nums[i] = 0;
                }
            }
        }//Runtime:186 ms, Beats:42.71% ; Memory:54.2 MB, Beats: 12.68%.
        public void MoveZeroes4(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == 0 && nums[j] != 0)
                    {
                        nums[i] = nums[j];
                        nums[j] = 0;
                        break;
                    }
                }
            }
        }//Runtime:214 ms, Beats:30.43%; Memory:54.3 MB, Beats:6.17%
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
        public void MoveZeroes5(int[] nums)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != 0)
                {
                    nums[slow++] = nums[fast];
                }
            }
            while (slow < nums.Length)
            {
                nums[slow++] = 0;
            }
        }//Runtime 162 ms Beats 82.27% Memory 54 MB Beats 40%
    }
}
