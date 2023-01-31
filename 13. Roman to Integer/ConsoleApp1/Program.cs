using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int RomanToInt(string s)
        {
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'M': num += 1000; break;
                    case 'D': num += 500; break;
                    case 'L': num += 50; break;
                    case 'V': num += 5; break;
                    case 'C':
                        if (i != s.Length - 1)
                            switch (s[i + 1])
                            {
                                case 'M': num -= 100; break;
                                case 'D': num -= 100; break;
                                default: num += 100; break;
                            }
                        else
                            num += 100;
                        break;
                    case 'X':
                        if (i != s.Length - 1)
                            switch (s[i + 1])
                            {
                                case 'L': num -= 10; break;
                                case 'C': num -= 10; break;
                                default: num += 10; break;
                            }
                        else
                            num += 10;
                        break;
                    case 'I':
                        if (i != s.Length - 1)
                            switch (s[i + 1])
                            {
                                case 'V': num -= 1; break;
                                case 'X': num -= 1; break;
                                default: num += 1; break;
                            }
                        else
                            num += 1;
                        break;
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            string s1 = "III", s2 = "LVIII",s3= "MCMXCIV";
            Console.WriteLine(s1 + "\t" +RomanToInt(s1));
            Console.WriteLine(s2 + "\t" + RomanToInt(s2));
            Console.WriteLine(s3 + "\t" + RomanToInt(s3));
            Console.ReadKey();
        }
    }
}
