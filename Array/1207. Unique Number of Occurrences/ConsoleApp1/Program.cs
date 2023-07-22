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
        public bool UniqueOccurrences(int[] arr)
        {
            int[] hash = new int[2001];
            int min = 1000;
            for (int i = 0; i < arr.Length; i++)
            {
                hash[arr[i] + 1000]++;
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            for (int i = min + 1000; i < hash.Length - 1; i++)
            {
                for (int j = i + 1; j < hash.Length; j++)
                {
                    if (hash[i] != 0 && hash[i] == hash[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }//Runtime:117 ms Beats:5.88% Memory:40.9 MB Beats:5.88%
        public bool UniqueOccurrences1(int[] arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            HashSet<int> set = new HashSet<int>();
            foreach (int num in arr)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }
            foreach (int value in dict.Values)
            {
                if (set.Contains(value))
                {
                    return false;
                }
                else
                {
                    set.Add(value);
                }
            }
            return true;
        }//Runtime:105 ms Beats:38.82% Memory:40.3 MB Beats:64.31%
    }
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr)
        {
            int[] arrindex = new int[2001];
            int min = 2001;
            int max = 0;
            foreach (int num in arr)
            {
                arrindex[num + 1000]++;
                if (min > (num + 1000))
                {
                    min = num + 1000;
                }
                if (max < (num + 1000))
                {
                    max = num + 1000;
                }
            }
            bool[] index = new bool[1001];
            for (int i = 0; i < 1001; i++)
            {
                index[i] = false;
            }
            for (int i = min; i <= max; i++)
            {
                if (arrindex[i] == 0) continue;
                if (index[arrindex[i]] == true)
                {
                    return false;
                }
                else
                {
                    index[arrindex[i]] = true;
                }
            }
            return true;
        }
    }//Runtime:95 ms Beats:90.33% Memory:40.9 MB Beats:5.95%
}
