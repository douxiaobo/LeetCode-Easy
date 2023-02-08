using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //蛮力法
        public static int MissingNumber(int[] nums)
        {
            int index = 0, mark;
            for (int i = 1; i <= nums.Length; i++)
            {
                mark = 0;//不存在数字
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] == i)
                    {
                        mark = 1;//存在数字
                        break;
                    }
                }
                if (mark == 1)
                {
                    continue;
                }
                else
                {
                    index = i;
                    break;
                }
            }
            return index;
        }//Rumtime:213ms, Beats:10.1%；Memory:43.8MB, Beats:52.13%
        //异或法
        public int MissingNumbe1r(int[] nums)
        {
            int nums1 = 0, nums2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                nums1 ^= nums[i];
                nums2 ^= (i + 1);
            }
            return nums1 ^ nums2;
        }//Runtime:110ms, Beats:55.88%; Memory:44.1MB, Beats:20.52%
        //总和减法
        public int MissingNumber3(int[] nums)
        {
            int sums1 = (nums.Length * (nums.Length + 1)) / 2;
            int sums2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sums2 += nums[i];
            }
            return sums1 - sums2;
        }//Runtime:97ms, Beats:93.41;Memory:43.7MB, Beats:52.13%
        public int MissingNumber4(int[] nums)
        {
            int sums = (nums.Length * (nums.Length + 1)) / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sums -= nums[i];
            }
            return sums;
        }//Runtime:90ms,Beats:98.58%; Memory:43.8MB, Beats:40.28%
        public int MissingNumber5(int[] nums)
        {
            int sums = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sums += i + 1 - nums[i];
            }
            return sums;
        }//Runtimes:103ms, Beats:79.9%; Memory:43.7MB, Beats:61.80%
        static void Main(string[] args)
        {
            int[] nums1 = { 3, 0, 1 };
            Console.WriteLine(MissingNumber(nums1));        //2
            int[] nums2 = { 0, 1 };
            Console.WriteLine(MissingNumber(nums2));        //2
            int[] nums3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.WriteLine(MissingNumber(nums3));        //8
            int[] nums4 = { 0 };
            Console.WriteLine(MissingNumber(nums4));        //1
            Console.ReadKey();
        }
    }
}
