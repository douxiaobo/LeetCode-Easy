using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int LengthOfLastWord(string s)
        {
            int index = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    index++;
                }
                else
                {
                    if (index > 0)
                        return index;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            string s1 = "Hello World";
            Console.WriteLine(LengthOfLastWord(s1));
            string s2 = "   fly me   to   the moon  ";
            Console.WriteLine(LengthOfLastWord(s2));
            string s3 = "luffy is still joyboy";
            Console.WriteLine(LengthOfLastWord(s3));
            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int len = 0;
            bool word = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && word == false)
                {
                    continue;
                }
                else if (s[i] == ' ' && word == true)
                {
                    break;
                }
                else
                {
                    word = true;
                    len++;
                }
            }
            return len;
        }
    }//Runtime:74 ms Beats:12.85% Memory:36.3 MB Beats:86.58%
}
