using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int slow = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[slow]) nums[++slow] = nums[i];
            }
            return slow + 1;
        }
        static void Main(string[] args)
        {
            int[] nums1 = new int[3] { 1, 1, 2 };
            int k;
            k=RemoveDuplicates(nums1);
            Console.WriteLine(k);
            for(int i=0;i<k; i++)
            {
                Console.Write(nums1[i]);
            }
            Console.WriteLine();
            
            int[] nums2 = new int[10] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            k=RemoveDuplicates(nums2);
            Console.WriteLine(k);
            for (int i = 0; i < k; i++)
            {
                Console.Write(nums2[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
