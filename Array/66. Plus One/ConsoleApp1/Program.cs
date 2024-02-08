using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }
            int[] newNumber = new int[digits.Length + 1];
            for (int i = 0; i < newNumber.Length; i++)
            {
                if (i == 0)
                {
                    newNumber[i] = 1;
                }
                else
                {
                    newNumber[i] = digits[i - 1];
                }
            }
            return newNumber;
        }
        public static void PrintArray(int[] digits)
        {
            for(int i=0;i<digits.Length;i++) { Console.Write(digits[i]+" "); }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3 };
            int[] num2 = { 4, 3, 2, 1 };
            int[] num3 = { 9 };
            int[] num4 = { 0 };
            PrintArray(PlusOne(num1));
            PrintArray(PlusOne(num2));
            PrintArray(PlusOne(num3));
            PrintArray(PlusOne(num4));
            Console.Read();
        }
        public int[] PlusOne1(int[] digits)
        {
            int plus = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                digits[i] += plus;
                if (i == digits.Length - 1)
                {
                    digits[i]++;
                }
                if (digits[i] > 9)
                {
                    plus = 1;
                    digits[i] -= 10;
                }
                else
                {
                    plus = 0;
                }
            }
            if (plus == 1)
            {
                int[] res = new int[digits.Length + 1];
                res[0] = 1;
                for (int i = 1; i < res.Length; i++)
                {
                    res[i] = digits[i - 1];
                }
                return res;
            }
            else
            {
                return digits;
            }
        }//Runtime:145 ms Beats:29.5% Memory:42.6 MB Beats:38.14%
    }
}
