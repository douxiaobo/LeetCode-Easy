using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public bool IsAnagram_HashTable(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            if (s == t)
            {
                return true;
            }
            Dictionary<char, int> dt = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dt.ContainsKey(s[i]))
                {
                    dt[s[i]]++;
                }
                else
                {
                    dt.Add(s[i], 1);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dt.ContainsKey(t[i]))
                {
                    dt[t[i]]--;
                }
                else
                {
                    return false;
                }
            }
            foreach (char ch in dt.Keys)
            {
                if (dt[ch] != 0)
                {
                    return false;
                }
            }
            return true;
        }//Runtime 81 ms Beats 76.46% Memory 39.7 MB Beats 75.62%
        public bool IsAnagram_Sorting(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            if (s == t)
            {
                return true;
            }
            char[] chs = s.ToCharArray();
            char[] cht = t.ToCharArray();
            Array.Sort(chs);
            Array.Sort(cht);
            for (int i = 0; i < s.Length; i++)
            {
                if (chs[i] != cht[i])
                {
                    return false;
                }
            }
            return true;
        }//Runtime 88 ms Beats 49.64% Memory 39.8 MB Beats 58.31%
        static void Main(string[] args)
        {
        }
        public bool IsAnagram(string s, string t)
        {
            int[] record = new int[26];
            for (int i = 0; i < 26; i++)
            {
                record[i] = 0;
            }
            for (int i = 0; i < s.Length; i++)
            {
                record[s[i] - 'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                record[t[i] - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (record[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }//Runtime:79 ms Beats:76.14% Memory:39.9 MB Beats:50.76%
        public bool IsAnagram1(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] counts = new int[26];
            foreach (char ch in s)
            {
                counts[ch - 'a']++;
            }
            foreach (char ch in t)
            {
                if (counts[ch - 'a'] == 0)
                {
                    return false;
                }
                counts[ch - 'a']--;
            }
            return true;
        }//Runtime:63 ms Beats:99.53% Memory:39.7 MB Beats:84.67%
    }
}
