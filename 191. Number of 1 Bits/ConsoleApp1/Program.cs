using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int HammingWeight(uint n)
        {
            int index = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    index++;
                }
                n = n / 2;
            }
            return index;
        }//Runtime 31 ms Beats 23.11% Memory 23.7 MB Beats 48.38%
        public int HammingWeight1(uint n)
        {
            int index = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)       //缺少()，就会报错。没搞清楚&和&&的区别。
                {
                    index++;
                }
                n = n >> 1;
            }
            return index;
        }//Runtime 25 ms Beats 62.86% Memory 23.7 MB Beats 65.20%
        //&是按位与运算符（或取地址运算符）
        //&&是条件与运算符（也叫逻辑与运算符）
        //&优先级高于&&
        public int HammingWeight2(uint n)
        {
            int index = 0;
            while (n > 0)
            {
                index += (int)(n % 2);
                n /= 2;
            }
            return index;
        }//Runtime 24 ms Beats 70.41% Memory 23.8 MB Beats 18.97%
        static void Main(string[] args)
        {
            uint n1= 0b00000000000000000000000000001011;
            Console.WriteLine(Convert.ToString(n1,2));
            Console.WriteLine(HammingWeight(n1));
            uint n2= 0b00000000000000000000000010000000;
            Console.WriteLine(n2);
            Console.WriteLine(HammingWeight(n2));
            uint n3= 0b11111111111111111111111111111101;
            Console.WriteLine(n3);
            Console.WriteLine(HammingWeight(n3));
            Console.ReadKey();
        }
    }
}
