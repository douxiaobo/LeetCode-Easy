using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool IsPalindrome(string s)
        {
            List<char> str = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z'))
                {
                    str.Add(Char.ToLower(s[i]));
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    str.Add(s[i]);
                }
            }
            for (int i = 0; i < str.Count() / 2; i++)
            {
                if (str[i] != str[str.Count() - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));  //缺少大写的考虑，就用了ToLower。
            Console.WriteLine(IsPalindrome("race a car"));
            Console.WriteLine(IsPalindrome(" "));
            Console.WriteLine(IsPalindrome("0P"));  //缺少数字的考虑，就增加数字范围。
            Console.ReadKey();
        }
        public bool IsPalindrome_TwoPointers(string s)
        {
            s = s.ToLower();
            int left = 0, right = s.Length - 1;
            while (left <= right)
            {
                if (!((s[left] >= 'a' && s[left] <= 'z') || (s[left] >= '0' && s[left] <= '9')))    //不能使用while，只能使用if。
                {
                    left++;
                    continue;
                }
                if (!((s[right] >= 'a' && s[right] <= 'z') || (s[right] >= '0' && s[right] <= '9')))
                {
                    right--;
                    continue;
                }
                if (s[left] != s[right])
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}
