using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string ConvertToTitle(int columnNumber)
        {
            string str = "";
            while (columnNumber > 0)
            {
                columnNumber--;
                str = str.Insert(0, ((char)('A' + columnNumber % 26)).ToString());
                columnNumber = columnNumber / 26;
            }
            return str;
        }//Runtime 74 ms Beats 40.59% Memory 36.7 MB Beats 29.29%
        public string ConvertToTitle1(int columnNumber)
        {
            string str = "";
            while (columnNumber > 0)
            {
                str = str.Insert(0, ((char)('A' + (--columnNumber) % 26)).ToString());
                columnNumber = columnNumber / 26;
            }
            return str;
        }//Runtime 64 ms Beats 88.70% Memory 36.7 MB Beats 29.29%
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToTitle(1));
            Console.WriteLine(ConvertToTitle(28));
            Console.WriteLine(ConvertToTitle(701));
            Console.ReadKey();
        }
    }
}
