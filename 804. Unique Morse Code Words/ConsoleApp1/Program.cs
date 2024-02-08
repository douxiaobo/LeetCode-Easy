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
        public int UniqueMorseRepresentations(string[] words)
        {
            string[] morsecode = new string[26] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string str = "";
            List<string> list = new List<string>();
            foreach (string word in words)
            {
                foreach (char ch in word)
                {
                    str += morsecode[ch - 'a'];
                }
                if (!list.Contains(str))
                {
                    list.Add(str);
                }
                str = "";
            }
            int res = 0;
            foreach (string ls in list)
            {
                res++;
            }
            return res;
        }
    }
}
