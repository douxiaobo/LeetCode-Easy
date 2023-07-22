using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static int[] nums1A = { 1, 2, 3, 0, 0, 0 };      //
        public static int m1A = 3;
        public static int[] nums1B = { 2, 5, 6 };
        public static int n1B = 3;

        public static int[] nums2A = { 1 };
        public static int m2A = 1;
        public static int[] nums2B = {  };
        public static int n2B = 0;

        public static int[] nums3A = {  0 };
        public static int m3A = 0;
        public static int[] nums3B = { 1};
        public static int n3B = 1;

        public static int[] nums4A = { 1, 2, 3, 0, 0, 0 };    //{1,2,2,3,5,6}   重点
        public static int m4A = 3;
        public static int[] nums4B = { 2, 5, 6 };
        public static int n4B = 3;

        public static int[] nums5A = { -1, 0, 0, 3, 3, 3, 0, 0, 0 };    //{-1,0,0,1,2,2,3,3,3}
        public static int m5A = 6;
        public static int[] nums5B = { 1, 2, 2 };
        public static int n5B = 3;

        public static int[] nums6A = { -1, 0, 1, 1, 0, 0, 0, 0, 0 };    //{-1,-1,0,0,1,1,2,2,3}
        public static int m6A = 4;
        public static int[] nums6B = { -1, 0, 2, 2, 3 };
        public static int n6B = 5;

        public static int[] nums7A = { 4, 5, 6, 0, 0, 0 };    //{1,2,2,3,5,6}
        public static int m7A = 3;
        public static int[] nums7B = { 1, 2, 3 };
        public static int n7B = 3;

        public static int[] nums8A = { 0, 0, 0, 0, 0 };    //{1,2,3,4,5}
        public static int m8A = 0;
        public static int[] nums8B = { 1, 2, 3, 4, 5 };
        public static int n8B = 5;

        public static int[] nums9A = { -1, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0 };    //{-1,-1,-1,0,0,0,0,0,1,2,3}      //重点
        public static int m9A = 5;
        public static int[] nums9B = { -1, -1, 0, 0, 1, 2 };
        public static int n9B = 6;

        public static int[] nums10A = { 1, 0 };    //{1,2}  重点
        public static int m10A = 1;
        public static int[] nums10B = { 2 };
        public static int n10B = 1;

        public static int[] nums11A = { 0, 0, 3, 0, 0, 0, 0, 0, 0 };    //{[-1,0,0,1,1,1,2,3,3]}  重点
        public static int m11A = 3;
        public static int[] nums11B = { -1, 1, 1, 1, 2, 3 };
        public static int n11B = 6;

        public static int[] nums12A = { -12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };    //{[-1,0,0,1,1,1,2,3,3]}  重点
        public static int m12A = 1;
        public static int[] nums12B = { -49, -45, -42, -41, -40, -39, -39, -39, -38, -36, -34, -34, -33, -33, -32, -31, -29, -28, -26, -26, -24, -21, -20, -20, -18, -16, -16, -14, -11, -7, -6, -5, -4, -4, -3, -3, -2, -2, -1, 0, 0, 0, 2, 2, 6, 7, 7, 8, 10, 10, 13, 13, 15, 15, 16, 17, 17, 19, 19, 20, 20, 20, 21, 21, 22, 22, 24, 24, 25, 26, 27, 29, 30, 30, 30, 35, 36, 36, 36, 37, 39, 40, 41, 42, 45, 46, 46, 46, 47, 48 };
        public static int n12B = 90;
        //{-49,-45,-42,-41,-40,-39,-39,-39,-38,-36,-34,-34,-33,-33,-32,-31,-29,-28,-26,-26,-24,-21,-20,-20,-18,-16,-16,-14,-12,-11,-7,-6,-5,-4,-4,-3,-3,-2,-2,-1,0,0,0,2,2,6,7,7,8,10,10,13,13,15,15,16,17,17,19,19,20,20,20,21,21,22,22,24,24,25,26,27,29,30,30,30,35,36,36,36,37,39,40,41,42,45,46,46,46,47,48}


        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            
            int i = m - 1, j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] < nums2[j]) nums1[k--] = nums2[j--];
                else nums1[k--] = nums1[i--];
            }
            while (j >= 0) nums1[k--] = nums2[j--];            
        }

        public static void Merge1(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1, j = n - 1;
            int k = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] >= nums2[j]) nums1[k--] = nums1[i--];
                else nums1[k--] = nums2[j--];
            }
            while (j >= 0) nums1[k--] = nums2[j--];
        }
        public static void Print(int[] nums,int m)
        {
            for(int i=0;i<m;i++)
            {
                Console.Write(nums[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Merge1(nums1A, m1A, nums1B, n1B);
            Print(nums1A,m1A+n1B);
            Merge1(nums2A, m2A, nums2B, n2B);
            Print(nums2A, m2A + n2B);
            Merge1(nums3A, m3A, nums3B, n3B);
            Print(nums3A, m3A + n3B);
            Merge1(nums4A, m4A, nums4B, n4B);
            Print(nums4A, m4A + n4B);
            Merge1(nums5A, m5A, nums5B, n5B);
            Print(nums5A, m5A + n5B);
            Merge1(nums6A, m6A, nums6B, n6B);
            Print(nums6A, m6A + n6B);
            Merge1(nums7A, m7A, nums7B, n7B);
            Print(nums7A, m7A + n7B);
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m + n - 1;
            while (i >= 0 && m - 1 >= 0 && n - 1 >= 0)
            {
                if (nums1[m - 1] <= nums2[n - 1])
                {
                    nums1[i] = nums2[n - 1];
                    n--;
                }
                else
                {
                    nums1[i] = nums1[m - 1];
                    m--;
                }
                i--;
            }
            while (n - 1 >= 0)
            {
                nums1[i] = nums2[n - 1];
                n--;
                i--;
            }
        }
    }//Runtime:136 ms Beats:82.59% Memory:43.1 MB Beats:22.54%
}
