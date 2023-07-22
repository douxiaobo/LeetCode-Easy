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
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            List<int> res = new List<int>();
            int[] index = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                index[nums[i] - 1]++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (index[i] == 0)
                {
                    res.Add(i + 1);
                }
            }
            return res;
        }//Runtime:207 ms Beats:49.79% Memory:54.2 MB Beats:80.59%
        public IList<int> FindDisappearedNumbers1(int[] nums)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                res.Add(i + 1);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (res.Contains(nums[i]))
                {
                    res.Remove(nums[i]);
                }
            }
            return res;
        }//Runtime:2641 ms Beats:5.6% Memory:55.3 MB Beats:22.57%
    }
}
