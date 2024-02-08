using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            List<int> res = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                int flag = 0;
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        flag = 1;
                    }
                    if (flag == 1)
                    {
                        if (nums1[i] < nums2[j])
                        {
                            res.Add(nums2[j]);
                            break;
                        }
                        if (j == nums2.Length - 1)
                        {
                            res.Add(-1);
                        }
                    }
                }
            }
            return res.ToArray();
        }//Runtime:147 ms Beats:50.14% Memory:43.2 MB Beats:73.58%
        static void Main(string[] args)
        {
        }
        public int[] NextGreaterElement1(int[] nums1, int[] nums2)
        {
            Stack<int> st = new Stack<int>();
            int[] res = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                res[i] = -1;
            }
            if (nums1.Length == 0)
            {
                return res;
            }
            Dictionary<int, int> di = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                di[nums1[i]] = i;
            }
            st.Push(0);
            for (int i = 1; i < nums2.Length; i++)
            {
                while (st.Count != 0 && nums2[i] > nums2[st.Peek()])
                {
                    if (di.ContainsKey(nums2[st.Peek()]))
                    {
                        int index = di[nums2[st.Peek()]];
                        res[index] = nums2[i];
                    }
                    st.Pop();
                }
                st.Push(i);
            }
            return res;
        }//Runtime:128 ms Beats:97.1% Memory:43.8 MB Beats:6.25%
        public int[] NextGreaterElement2(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            foreach (var num in nums2)
            {
                while (stack.Count > 0 && num > stack.Peek())
                {
                    dic.Add(stack.Pop(), num);
                }
                stack.Push(num);
            }
            int[] res = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                res[i] = dic.ContainsKey(nums1[i]) ? dic[nums1[i]] : -1;
            }
            return res;
        }//Runtime:154 ms Beats:15.14% Memory:43.8 MB Beats:12.30%
    }
}
