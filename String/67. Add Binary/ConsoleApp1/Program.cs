using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string AddBinary(string a, string b)
        {
            int BiLength = 0,DifLength=0;
            if (a.Length > b.Length)
            {
                BiLength = a.Length - 1;
                DifLength=a.Length-b.Length;
                //Console.WriteLine(BiLength);
                for (int z = 0; z < DifLength; z++)
                {
                    b = b.Insert(0, "0");   //OK
                }
                //Console.WriteLine(b);
            }
            else if (a.Length < b.Length)
            {
                BiLength = b.Length - 1;
                DifLength=b.Length-a.Length;
                //Console.WriteLine(BiLength);
                for (int z = 0; z < DifLength; z++)
                {
                    a = a.Insert(0, "0");   //OK
                }
                //Console.WriteLine(a);
            }
            else
            {
                BiLength = a.Length - 1;
            }
            int add = 0;
            string result = "";
            while (BiLength >= 0)
            {
                if (add == 0)
                {
                    if (a[BiLength] == '1' && b[BiLength] == '1')
                    {
                        result += '0';
                        add = 1;
                    }
                    else if (a[BiLength] == '0' && b[BiLength] == '0')
                    {
                        result += '0';
                    }
                    else
                    {
                        result += '1';
                    }
                }
                else
                {
                    if (a[BiLength] == '1' && b[BiLength] == '1')
                    {
                        result += '1';
                    }
                    else if (a[BiLength] == '0' && b[BiLength] == '0')
                    {
                        result += '1';
                        add = 0;
                    }
                    else
                    {
                        result += '0';
                    }
                }
                BiLength--;
            }
            if (add == 1)
            {
                result += '1';
            }
            string resultre = "";
            for (int k = result.Length - 1; k >= 0; k--)
            {
                resultre += result[k];
            }
            return resultre;
        }
        public static string AddBinary1(string a, string b)
        {
            int BiLength = 0, DifLength = 0;
            if (a.Length > b.Length)
            {
                BiLength = a.Length - 1;
                DifLength = a.Length - b.Length;

                for (int z = 0; z < DifLength; z++)
                {
                    b = b.Insert(0, "0");   //OK
                }
            }
            else if (a.Length < b.Length)
            {
                BiLength = b.Length - 1;
                DifLength = b.Length - a.Length;

                for (int z = 0; z < DifLength; z++)
                {
                    a = a.Insert(0, "0");   //OK
                }

            }
            else
            {
                BiLength = a.Length - 1;
            }
            int add = 0;
            string result = "";
            while (BiLength >= 0)
            {
                if (add == 0)
                {
                    if (a[BiLength] == '1' && b[BiLength] == '1')
                    {
                        result = result.Insert(0, "0");
                        add = 1;
                    }
                    else if (a[BiLength] == '0' && b[BiLength] == '0')
                    {
                        result = result.Insert(0, "0");
                    }
                    else
                    {
                        result = result.Insert(0, "1");
                    }
                }
                else
                {
                    if (a[BiLength] == '1' && b[BiLength] == '1')
                    {
                        result = result.Insert(0, "1");
                    }
                    else if (a[BiLength] == '0' && b[BiLength] == '0')
                    {
                        result = result.Insert(0, "1");
                        add = 0;
                    }
                    else
                    {
                        result = result.Insert(0, "0");
                    }
                }
                BiLength--;
            }
            if (add == 1)
            {
                result = result.Insert(0, "1");
            }
            return result;
        }
        static void Main(string[] args)
        {
            string a1 = "11";
            string b1 = "1";
            Console.WriteLine(AddBinary(a1, b1));
            string a2 = "1010";
            string b2 = "1011";
            Console.WriteLine(AddBinary1(a2, b2));
            string a3 = "1";
            string b3 = "111";
            Console.WriteLine(AddBinary(a3, b3));
            string a4 = "100";
            string b4 = "110010";
            Console.WriteLine(AddBinary1(a4, b4));
            Console.ReadKey();
        }
        public string AddBinary2(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            while (i >= 0 || j >= 0)
            {
                int digitA = i >= 0 ? a[i--] - '0' : 0;
                int digitB = j >= 0 ? b[j--] - '0' : 0;
                int sum = digitA + digitB + carry;
                carry = sum >= 2 ? 1 : 0;
                sum = sum >= 2 ? sum - 2 : sum;
                result.Append(sum);
            }
            if (carry == 1)
            {
                result.Append(1);
            }
            i = 0;
            j = result.Length - 1;
            while (i < j)
            {
                char temp;
                temp = result[i];
                result[i] = result[j];
                result[j] = temp;
                i++;
                j--;
            }
            return result.ToString();
        }//Runtime:86 ms Beats:40.83% Memory:38.6 MB Beats:73.83%
    }
}
