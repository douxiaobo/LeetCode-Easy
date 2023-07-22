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
        public int PrefixCount(string[] words, string pref)
        {
            int count = 0;
            foreach (string word in words)
            {
                int i = 0;
                for (; i < pref.Length && i < word.Length; i++)
                {
                    if (word[i] != pref[i])
                    {
                        break;
                    }
                }
                if (i == pref.Length)
                {
                    count++;
                }
            }
            return count;
        }
    }//Runtime:99 ms Beats:13.70% Memory:40.7 MB Beats:85.92%
}
