using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution1 solution1 = new Solution1();
            Console.WriteLine(solution1.BuildArray(new int[] { 0, 2, 1, 5, 3, 4 }));
            //0，2，1，5，3，4
            //0，8，13，29，33，22
            //0，1，2，4，5，3
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }
    }//Runtime:158 ms Beats:39.55% Memory:50 MB Beats:49.76%
    public class Solution1
    {
        public int[] BuildArray(int[] nums)
        {
            int n = nums.Length;
            // 第一次遍历，将 nums[i] 的值存储在 nums[nums[i]] 的位置上
            for (int i = 0; i < n; i++)
            {
                nums[i] += n * (nums[nums[i]] % n);
            }
            // 第二次遍历，将 nums[i] 还原成原来的值
            for (int i = 0; i < n; i++)
            {
                nums[i] /= n;
            }
            return nums;
        }
    }//Runtime：160 ms Beats：30.96% Memory：49.6 MB Beats：93.84%
}
