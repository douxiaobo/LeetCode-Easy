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
        public int FirstUniqChar(string s)
        {
            int[] hash = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                hash[s[i] - 'a']++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (hash[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }
            return -1;
        }//Runtime:69 ms Beats:93.63% Memory:45.3 MB Beats:82.72%
    }
}
