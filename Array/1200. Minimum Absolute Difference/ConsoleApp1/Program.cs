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
    public class Solution
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            int min = 1000000;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (min > (arr[i + 1] - arr[i]))
                {
                    min = arr[i + 1] - arr[i];
                }
            }
            IList<IList<int>> res = new List<IList<int>>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                List<int> tmp = new List<int>();
                if (arr[i + 1] - arr[i] == min)
                {
                    tmp.Add(arr[i]);
                    tmp.Add(arr[i + 1]);
                    res.Add(tmp);
                }
            }
            return res;
        }
    }//Runtime:201 ms Beats:91.55% Memory:60.5 MB Beats:5.63%

}
