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
        public string FirstPalindrome(string[] words)
        {
            string result = "";
            foreach (string word in words)
            {
                int left = 0;
                int right = word.Length - 1;
                while (left <= right)
                {
                    if (word[left] == word[right])
                    {
                        left++;
                        right--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (left > right)
                {
                    result += word;
                    break;
                }
            }
            return result;
        }
    }//Runtime:110 ms Beats:76.74% Memory:52.4 MB Beats:93.2%
}
