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
        public string DefangIPaddr(string address)
        {
            string result = "";
            foreach (char ch in address)
            {
                if (ch == '.')
                {
                    result += '[';
                    result += ch;
                    result += ']';
                }
                else
                {
                    result += ch;
                }
            }
            return result;
        }
    }//Runtime:72 ms Beats:72.21% Memory:36.7 MB Beats:82.90%
}
