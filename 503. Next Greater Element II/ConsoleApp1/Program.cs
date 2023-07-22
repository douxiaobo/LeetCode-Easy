using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int[] NextGreaterElements(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = -1;
            }
            if (nums.Length == 0)
            {
                return result;
            }
            Stack<int> st = new Stack<int>();
            for (int i = 0; i < nums.Length * 2; i++)
            {
                while (st.Count() > 0 && nums[i % nums.Length] > nums[st.Peek()])
                {
                    result[st.Peek()] = nums[i % nums.Length];  //如果删除%nums.Length，出现一句话：Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
                    st.Pop();
                }
                st.Push(i % nums.Length);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] result = NextGreaterElements(new int[] { 1, 2, 3, 4, 3 });
            for(int i=0;i<result.Length;i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
