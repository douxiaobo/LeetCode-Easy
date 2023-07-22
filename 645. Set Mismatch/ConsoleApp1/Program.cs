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
        public int[] FindErrorNums(int[] nums)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(nums[i]);
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                if (list.Contains(i))
                {
                    list.Remove(i);
                }
                else
                {
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
    }
}
