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
        public bool IsAlienSorted(string[] words, string order)
        {
            int[] orderArray = new int[order.Length];
            for (int i = 0; i < order.Length; i++)
            {
                orderArray[order[i] - 'a'] = i;
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (!isSorted(words[i], words[i + 1], orderArray))
                {
                    return false;
                }
            }
            return true;
        }
        private bool isSorted(string word1, string word2, int[] order)
        {
            int i = 0;
            for (; i < word1.Length && i < word2.Length; i++)
            {
                char ch1 = word1[i];
                char ch2 = word2[i];
                if (order[ch1 - 'a'] < order[ch2 - 'a'])
                {
                    return true;
                }
                else if (order[ch1 - 'a'] > order[ch2 - 'a'])
                {
                    return false;
                }
            }
            return i == word1.Length;
        }//Runtime:93 ms Beats:83.64% Memory:41.2 MB Beats:53.64%
    }
}
