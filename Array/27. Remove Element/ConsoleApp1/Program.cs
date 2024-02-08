using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int length = nums.Length, index = 0;
            while (index < length)
            {
                if (nums[index] == val)
                {
                    nums[index] = nums[--length];
                }
                else
                {
                    index++;
                }
            }
            return length;
        }
        static void Main(string[] args)
        {
            int[] nums1 = new int[]{3,2,2,3};
            int length = RemoveElement(nums1,3);
            Console.WriteLine(length);
            for(int i=0;i<length;i++)
            {
                Console.Write(nums1[i] + " ");
            }
            Console.WriteLine();
            int[] nums2 =new int[]{ 0,1,2,2,3,0,4,2};
            length = RemoveElement(nums2, 2);
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                Console.Write(nums2[i]+" ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int left = 0, right = 0;
            while (right < nums.Length)
            {
                if (nums[right] != val)
                {
                    nums[left] = nums[right];
                    left++;
                }
                right++;
            }
            return left;
        }
    }
}
