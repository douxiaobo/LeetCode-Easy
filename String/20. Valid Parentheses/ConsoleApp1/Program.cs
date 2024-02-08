using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            foreach (char n in s)
            {
                switch (n)
                {
                    case '(':
                        st.Push('(');
                        break;
                    case ')':
                        if (st.Count == 0)
                            return false;
                        if (st.Peek() != '(')
                            return false;
                        else
                            st.Pop();
                        break;
                    case '[':
                        st.Push('[');
                        break;
                    case ']':
                        if (st.Count == 0)
                            return false;
                        if (st.Peek() != '[')
                            return false;
                        else
                            st.Pop();
                        break;
                    case '{':
                        st.Push('{');
                        break;
                    case '}':
                        if (st.Count == 0)
                            return false;
                        if (st.Peek() != '{')
                            return false;
                        else
                            st.Pop();
                        break;
                }
            }
            if (st.Count == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            string s1 = "()";
            Console.WriteLine(IsValid2(s1));
            string s2 = "()[]{}";
            Console.WriteLine(IsValid(s2));
            string s3 = "(]";
            Console.WriteLine(IsValid(s3));
            string s4 = "([)]";
            Console.WriteLine(IsValid(s4));
            string s5 = "{[]}";
            Console.WriteLine(IsValid(s5));
            string s6 = "]";
            Console.WriteLine(IsValid(s6));
            Console.ReadKey();
        }
        public bool IsValid1(string s)
        {
            Stack<char> st = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    st.Push(s[i]);
                }
                else if (st.Count == 0 && (s[i] == ')' || s[i] == '}' || s[i] == ']'))
                {
                    return false;
                }
                else
                {
                    if (s[i] == ')' && st.Peek() == '(')
                    {
                        st.Pop();
                    }
                    else if (s[i] == '}' && st.Peek() == '{')
                    {
                        st.Pop();
                    }
                    else if (s[i] == ']' && st.Peek() == '[')
                    {
                        st.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (st.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsValid2(string s)
        {
            if (s.Length % 2 == 1)
            {
                return false;
            }
            char[] stack = new char[s.Length];
            int stacktop = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack[stacktop++] = ')';
                }
                else if (s[i] == '[')
                {
                    stack[stacktop++] = ']';
                }
                else if (s[i] == '{')
                {
                    stack[stacktop++] = '}';
                }
                else if (stacktop > 0 && s[i] == stack[stacktop - 1])
                {
                    stacktop--;
                }
                else
                {
                    return false;
                }
            }
            if (stacktop > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
