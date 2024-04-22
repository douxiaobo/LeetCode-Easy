using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void ReverseString(char[] s)
        {
            int low = 0, high = s.Length - 1;
            while (low < high)
            {
                char ch = s[low];
                s[low] = s[high];
                s[high] = ch;
                low++;
                high--;
            }
        }//Runtime 236 ms Beats 97.65% Memory 61.6 MB Beats 25.52%
        static void Main(string[] args)
        {
            char[] s1 = { 'H', 'e', 'l', 'l', 'o' };
            Console.WriteLine(s1);
            ReverseString(s1);
            Console.WriteLine(s1);
            char[] s2 = { 'H', 'a', 'n', 'n', 'a', 'h' };
            Console.WriteLine(s2);
            ReverseString(s2);
            Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
