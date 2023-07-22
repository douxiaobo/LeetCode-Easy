using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> nums = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        if (nums == null)
                        {
                            nums.Add(nums1[i]);
                            break;
                        }
                        else
                        {
                            int flag = 0;
                            foreach (int item in nums)
                            {
                                if (item == nums1[i])
                                {
                                    flag = 1;
                                    break;
                                }
                            }
                            if (flag == 0)
                            {
                                nums.Add(nums1[i]);
                                break;
                            }

                        }

                    }
                }
            }
            return nums.ToArray();
        }//Runtime:145 ms Beats:56.87% Memory:42.7 MB Beats:87.21%
        static void Main(string[] args)
        {
            int[] nums1 = Intersection(new int[]{1,2,2,1 }, new int[]{2,2 });       //2
            int[] nums2 = Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }); //4 9
            Print(nums1);
            Print(nums2);
            Console.Read();
        }
        static void Print(int[] nums)
        {
            for(int i=0;i<nums.Length;i++)
            {
                Console.Write(nums[i]+" ");
            }
            Console.WriteLine();
        }
        public int[] Intersection1(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            HashSet<int> hs = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (hs.Contains(nums1[i]))
                {
                    continue;
                }
                else
                {
                    hs.Add(nums1[i]);
                }
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (hs.Contains(nums2[i]) && !result.Contains(nums2[i]))
                {
                    result.Add(nums2[i]);
                }
                else
                {
                    continue;
                }
            }
            return result.ToArray();
        }//Runtime:130 ms Beats:96.18% Memory:42.7 MB Beats:87.21%
        public int[] Intersection2(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            int[] hash = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                hash[i] = 0;
            }
            foreach (int num in nums1)
            {
                hash[num] = 1;
            }
            foreach (int num in nums2)
            {
                if (hash[num] == 1 && !result.Contains(num))
                {
                    result.Add(num);
                }
            }
            return result.ToArray();

        }//Runtime:128 ms Beats:97.71% Memory:43.3 MB Beats:30.73%
    }
}
