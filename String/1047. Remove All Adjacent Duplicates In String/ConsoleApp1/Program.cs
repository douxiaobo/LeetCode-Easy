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
        public string RemoveDuplicates(string s)
        {
            char[] stack = new char[s.Length];
            int stacktop = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == 0)
                {
                    stack[stacktop++] = s[i];
                }
                else if (stacktop > 0 && stack[stacktop - 1] == s[i])
                {
                    stacktop--;
                }
                else
                {
                    stack[stacktop++] = s[i];
                }
            }
            string result = "";
            for (int i = 0; i < stacktop; i++)
            {
                result += stack[i];
            }
            return result;
        }//Runtime:566 ms Beats:29.75% Memory:56.2 MB Beats:19.62%
        public string RemoveDuplicates1(string s)
        {
            char[] stack = new char[s.Length];
            int stacktop = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (stacktop > 0 && stack[stacktop - 1] == s[i])
                {
                    stacktop--;
                }
                else
                {
                    stack[stacktop++] = s[i];
                }
            }
            string result = "";
            for (int i = 0; i < stacktop; i++)
            {
                result += stack[i];
            }
            return result;
        }//Runtime:536 ms Beats:33.54% Memory:56.4 MB Beats:17.72%
        public string RemoveDuplicates2(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count() > 0 && stack.Peek() == s[i])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            int count = stack.Count();
            char[] res = new char[count];
            for (int i = count - 1; i >= 0; i--)
            {
                res[i] = stack.Pop();
            }
            return new string(res);
        }//Runtime:93 ms Beats:53.80% Memory:46.6 MB Beats:71.52%
    }
}
