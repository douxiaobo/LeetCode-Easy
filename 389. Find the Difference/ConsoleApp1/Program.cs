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
        public char FindTheDifference(string s, string t)
        {
            char a = t[0];
            for (int i = 1; i < t.Length; i++)
            {
                a ^= t[i];
            }
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    a ^= s[i];
                }
            }
            return a;
        }//Runtime：90 ms Beats：73.19% Memory：38.9 MB Beats：93.6%
        public char FindTheDifference1(string s, string t)
        {
            int[] hash = new int[26];
            for (int i = 0; i < t.Length; i++)
            {
                hash[t[i] - 'a']++;
            }
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    hash[s[i] - 'a']--;
                }
            }
            char ch = ' ';
            for (int i = 0; i < t.Length; i++)
            {
                if (hash[t[i] - 'a'] == 1)
                {
                    ch = t[i];
                }
            }
            return ch;
        }//Runtime：93 ms Beats:61.20% Memory:39.5 MB Beats:36.59%
    }
}
