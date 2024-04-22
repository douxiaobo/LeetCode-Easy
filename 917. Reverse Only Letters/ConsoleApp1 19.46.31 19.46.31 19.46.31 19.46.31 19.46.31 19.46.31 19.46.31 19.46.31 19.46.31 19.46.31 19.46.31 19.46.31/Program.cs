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
        public string ReverseOnlyLetters(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] chars = s.ToCharArray();
            while (left < right)
            {
                while (left < right && !(chars[left] >= 'A' && chars[left] <= 'Z') && !(chars[left] >= 'a' && chars[left] <= 'z'))
                {
                    left++;
                }
                while (left < right && !(chars[right] >= 'A' && chars[right] <= 'Z') && !(chars[right] >= 'a' && chars[right] <= 'z'))
                {
                    right--;
                }
                char ch = chars[left];
                chars[left] = chars[right];
                chars[right] = ch;
                left++;
                right--;
            }
            return new string(chars);
        }
    }//Runtime:82 ms Beats:52.42% Memory:36.6 MB Beats:96.77%
    public class Solution1
    {
        public string ReverseOnlyLetters(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char[] chars = s.ToCharArray();
            while (left < right)
            {
                while (left < right && !Char.IsLetter(chars[left]))
                {
                    left++;
                }
                while (left < right && !Char.IsLetter(chars[right]))
                {
                    right--;
                }
                char ch = chars[left];
                chars[left] = chars[right];
                chars[right] = ch;
                left++;
                right--;
            }
            return new string(chars);
        }
    }//Runtime:81 ms Beats:58.6% Memory:36.7 MB Beats:95.16%
}
