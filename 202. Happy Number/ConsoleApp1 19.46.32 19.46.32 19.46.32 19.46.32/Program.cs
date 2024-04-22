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
        public bool DetectCapitalUse(string word)
        {
            int index = 0;
            if (word[index] >= 'A' && word[index] <= 'Z')
            {
                index++;
                if (index < word.Length && word[index] >= 'A' && word[index] <= 'Z')
                {
                    while (index < word.Length && word[index] >= 'A' && word[index] <= 'Z')
                    {
                        index++;
                    }
                }
                else
                {
                    while (index < word.Length && word[index] >= 'a' && word[index] <= 'z')
                    {
                        index++;
                    }
                }

            }
            else
            {
                while (index < word.Length && word[index] >= 'a' && word[index] <= 'z')
                {
                    index++;
                }
            }
            if (index != word.Length)
            {
                return false;
            }
            return true;
        }//Runtime:77 ms Beats:68.18% Memory:39.3 MB Beats:22.8%
    }
}
