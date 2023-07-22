using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool BackspaceCompare(string s, string t)
        {
            Stack<char> ss = new Stack<char>();
            Stack<char> tt = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (ss.Count > 0 && s[i] == '#')
                {
                    ss.Pop();
                }
                else if (s[i] != '#')
                {
                    ss.Push(s[i]);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (tt.Count > 0 && t[i] == '#')
                {
                    tt.Pop();
                }
                else if (t[i] != '#')
                {
                    tt.Push(t[i]);
                }
            }
            if (ss.Count != tt.Count)
            {
                return false;
            }
            else
            {
                while (ss.Count > 0 && tt.Count > 0)
                {
                    if (ss.Peek() == tt.Peek())
                    {
                        ss.Pop();
                        tt.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }//Runtime:72 ms Beats:85.80% Memory:38.2 MB Beats:72.16%
        static void Main(string[] args)
        {
            Console.WriteLine(BackspaceCompare("y#fo##f", "y#f#o##f"));
            Console.ReadKey();
        }
    }
}
