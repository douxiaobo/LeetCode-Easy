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
        public IList<string> CommonChars(string[] words)
        {
            List<string> res = new List<string>();
            int[][] hash = new int[words.Length][];
            for (int i = 0; i < words.Length; i++)
            {
                hash[i] = new int[26];
                foreach (char ch in words[i])
                {
                    hash[i][ch - 'a']++;
                }
            }
            for (int i = 0; i < 26; i++)
            {
                int minCount = int.MaxValue;
                for (int j = 0; j < words.Length; j++)
                {
                    minCount = Math.Min(minCount, hash[j][i]);
                }
                for (int k = 0; k < minCount; k++)
                {
                    res.Add(((char)(i + 'a')).ToString());
                }
            }
            return res;
        }
    }//Runtime:163 ms Beats:49.23% Memory:44.7 MB Beats:89.23%
}
