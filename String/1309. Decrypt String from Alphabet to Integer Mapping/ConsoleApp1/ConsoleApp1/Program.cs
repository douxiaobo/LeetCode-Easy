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
        public string FreqAlphabets(string s)
        {
            string result = "";
            int i = 0;
            while (i < s.Length)
            {
                int num = 0;
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    num += (s[i] - '0') * 10 + (s[i + 1] - '0');
                    i += 3;
                }
                else
                {
                    num += s[i] - '0';
                    i++;
                }
                result += (char)('a' + num - 1);
            }
            return result;
        }
    }//Runtime:62 ms Beats:100% Memory:37.9 MB Beats:29.31%
}
