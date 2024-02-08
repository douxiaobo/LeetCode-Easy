using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public static bool IsPalindrome(int x)
        {
            int n = x, r = 0;
            if(x<0) { return false; }
            if (x == 0) { return true; }
            while (n > 0)
            {
                r=r*10+n % 10;
                n=n/10;
            }
            return r == x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(-121));
            Console.WriteLine(IsPalindrome(10));
            Console.ReadKey();
        }
    }
}
