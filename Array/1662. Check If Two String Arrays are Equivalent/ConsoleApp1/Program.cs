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
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string return1 = "", return2 = "";
            foreach (string word in word1)
            {
                return1 += word;
            }
            foreach (string word in word2)
            {
                return2 += word;
            }
            return return1 == return2;
        }
    }//Runtime:91 ms Beats:82.88% Memory:41.6 MB Beats:13.96%
}
