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
        public string ReverseWords(string s)
        {
            string res = "";
            string str = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' || i == s.Length - 1)
                {
                    if (i == s.Length - 1)
                    {
                        str += s[i];
                    }
                    string rev = "";
                    for (int j = str.Length - 1; j >= 0; j--)
                    {
                        rev += str[j];
                    }
                    str = "";
                    res += rev;
                    if (i != s.Length - 1)
                    {
                        res += ' ';
                    }
                }
                else
                {
                    str += s[i];
                }
            }
            return res;
        }//Runtime:173 ms Beats:10.60% Memory:59.1 MB Beats:21.19%
    }
}
