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
        }
    }
    public class NumArray
    {
        int[] num;

        public NumArray(int[] nums)
        {
            num = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                num[i] = nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            int sum = 0;
            for (int i = left; i <= right; i++)
            {
                sum += num[i];
            }
            return sum;
        }
    }//Runtime:199 ms Beats:13.61% Memory:57.2 MB Beats:18.71%
    public class NumArray1
    {
        int[] sum;

        public NumArray1(int[] nums)
        {
            sum = new int[nums.Length];
            sum[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum[i] = sum[i - 1] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            return sum[right] - (left == 0 ? 0 : sum[left - 1]);
        }
    }//Runtime:147 ms Beats:63.95% Memory:57 MB Beats:29.25%
}
/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */
