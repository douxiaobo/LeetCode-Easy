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
    public class Solution_Example
    {
        public int MaxLengthBetweenEqualCharacters(string s)
        {
            int[] firstIndex = new int[26];
            int[] lastIndex = new int[26];
            for (int i = 0; i < 26; i++)
            {
                firstIndex[i] = -1;
                lastIndex[i] = -1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                int index = s[i] - 'a';
                if (firstIndex[index] == -1)
                {
                    firstIndex[index] = i;
                }
                lastIndex[index] = i;
            }

            int maxLength = -1;
            for (int i = 0; i < 26; i++)
            {
                maxLength = Math.Max(maxLength, lastIndex[i] - firstIndex[i] - 1);
            }
            return maxLength;
        }
    }//Runtime:69 ms Beats:42.86% Memory:36.4 MB Beats:28.57%
}
