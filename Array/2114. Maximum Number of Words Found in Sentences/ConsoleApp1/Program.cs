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
        public int MostWordsFound(string[] sentences)
        {
            int result = 0;
            foreach (string sentence in sentences)
            {
                int count = 0;
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == ' ' || i == sentence.Length - 1)
                    {
                        count++;
                    }
                }
                if (count > result)
                {
                    result = count;
                }
            }
            return result;
        }
    }//Runtime:105 ms Beats:5.30% Memory:40 MB Beats:99.77%
}
