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
            Console.WriteLine(IsValid(s1));
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
    }
}
