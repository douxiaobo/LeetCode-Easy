using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public uint reverseBits(uint n)
        {
            Stack<uint> st = new Stack<uint>();
            uint num = 0;
            for (int i = 0; i < 32; i++)
            {
                st.Push(n % 2);
                n = n / 2;
            }
            for (int i = 0; i < 32; i++)
            {
                num += st.Pop() * (uint)(Math.Pow(2, i));
            }
            return num;
        }//Runtime:25 ms Beats:63.22% Memory:25 MB Beats:12.33%
        static void Main(string[] args)
        {
        }
    }
}
