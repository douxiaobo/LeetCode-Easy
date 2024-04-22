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
        public int RomanToInt1(string s)
        {
            int sum = 0;
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] == 'C')
                {
                    if (i < s.Length - 1 && s[i + 1] == 'D')
                    {
                        sum += 400;
                        i++;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'M')
                    {
                        sum += 900;
                        i++;
                    }
                    else
                    {
                        sum += 100;
                    }
                }
                else if (s[i] == 'M')
                {
                    sum += 1000;
                }
                else if (s[i] == 'D')
                {
                    sum += 500;
                }
                else if (s[i] == 'C')
                {
                    sum += 100;
                }
                else if (s[i] == 'X')
                {
                    if (i < s.Length - 1 && s[i + 1] == 'L')
                    {
                        sum += 40;
                        i++;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'C')
                    {
                        sum += 90;
                        i++;
                    }
                    else
                    {
                        sum += 10;
                    }
                }
                else if (s[i] == 'L')
                {
                    sum += 50;
                }
                else if (s[i] == 'I')
                {
                    if (i < s.Length - 1 && s[i + 1] == 'V')
                    {
                        sum += 4;
                        i++;
                    }
                    else if (i < s.Length - 1 && s[i + 1] == 'X')
                    {
                        sum += 9;
                        i++;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                else if (s[i] == 'V')
                {
                    sum += 5;
                }
                i++;
            }
            return sum;
        }
    }
}
