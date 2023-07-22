using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool ValidPalindrome1(string s)       //不行
        {
            int i = 0, j = s.Length - 1, flag = 0;
            while (i < j)
            {
                if (s[i] == s[j])
                {
                    i++;
                    j--;
                }
                else if (s[i + 1] == s[j])
                {
                    i += 2;
                    j--;
                    flag++;
                }
                else if (s[i] == s[j - 1])
                {
                    i++;
                    j -= 2;
                    flag++;
                }
                else
                {
                    return false;
                }
                if (flag > 1)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidPalindrome(string s)
        {
            int left = 0, right = s.Length - 1, flag = 0;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    flag++;
                    break;
                }
                left++;
                right--;
            }
            if (flag == 0)
            {
                return true;
            }
            else
            {
                flag = 0;
                int left1 = left + 1, right1 = right;
                while (left1 < right1)
                {
                    if (s[left1] != s[right1])
                    {
                        flag++;
                        break;
                    }
                    left1++;
                    right1--;
                }
                left1 = left;
                right1 = right - 1;
                while (left1 < right1)
                {
                    if (s[left1] != s[right1])
                    {
                        flag++;
                        break;

                    }
                    left1++;
                    right1--;
                }
                if (flag > 1)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPalindrome3("aguokepatgbnvfqmgmlcupuufxoohdfpgjdmysgvhmvffcnqxjjxqncffvmhvgsymdjgpfdhooxfuupuculmgmqfvnbgtapekouga"));
            //Console.WriteLine(ValidPalindrome("abc"));
            Console.ReadKey();
        }
        public bool ValidPalindrome2(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            for (; start < s.Length / 2; start++, end--)
            {
                if (s[start] != s[end])
                {
                    break;
                }
            }
            return start == s.Length / 2 || isPalindrome(s, start, end - 1) || isPalindrome(s, start + 1, end);
        }
        private bool isPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    break;
                }
                start++;
                end--;
            }
            return start >= end;
        }//Runtime:104 ms Beats:17.75% Memory:50.8 MB Beats:73.96%
        public static bool ValidPalindrome3(string s)
        {
            int left = 0, right = s.Length - 1, flag = 0;
            while (left <= right)
            {
                if (s[left] != s[right])
                {
                    if (s[left + 1] == s[right])
                    {
                        left++;
                    }
                    if (s[left] == s[right - 1])
                    {
                        right--;
                    }
                    else
                    {
                        return false;
                    }
                    flag++;
                }//left=19,c,left=20,u;right=81,u,right=80,c;
                left++;
                right--;
            }
            return true;
        }
    }
}
