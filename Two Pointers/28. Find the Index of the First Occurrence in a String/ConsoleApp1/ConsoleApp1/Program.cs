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
        public int StrStr(string haystack, string needle)
        {
            int i, j;
            if (haystack.Length < needle.Length)
            {
                return -1;
            }
            for (i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                for (j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }
                if (j == needle.Length)
                {
                    return i;
                }
            }
            return -1;
        }
    }//Runtime:51 ms Beats:93.24% Memory:36.7 MB Beats:59.58%
}
