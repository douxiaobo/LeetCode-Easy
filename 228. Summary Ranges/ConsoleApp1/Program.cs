using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            IList<string> str = new List<string>();
            int i = 0;
            while (i < nums.Length)
            {
                int start = i;
                i++;
                while ((i < nums.Length) && (nums[i - 1] + 1 == nums[i]))
                {
                    i++;
                }
                str.Add(start == i - 1 ? $"{nums[start]}" : $"{nums[start]}->{nums[i - 1]}");
            }
            return str;
        }
        public static void Print(IList<string> strs)
        {
            for(int i=0;i<strs.Count;i++)
            {
                if (i==strs.Count-1)
                {
                    Console.Write("\"" + strs[i] + "\"");
                }
                else
                {
                    Console.Write("\"" + strs[i] + "\"" + ", ");
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 0, 1, 2, 4, 5, 7 };
            Print(SummaryRanges(nums1));
            int[] nums2 = { 0, 2, 3, 4, 6, 8, 9 };
            Print(SummaryRanges(nums2));
            Console.ReadKey();
        }
    }
}
