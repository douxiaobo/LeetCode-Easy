using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public bool IsSubsequence(string s, string t)
        {
            int si = 0, ti = 0;
            while ((si < s.Length) && (ti < t.Length))      //使用for是不行了
            {
                if (s[si] == t[ti])
                {
                    si++;
                }
                ti++;
            }
            if (si == s.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
