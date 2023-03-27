using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int TitleToNumber1(string columnTitle)
        {
            int len = columnTitle.Length - 1;
            int sum = 0;
            for (int i = len; i >= 0; i--)
            {
                sum += (columnTitle[i] - 'A' + 1) * (int)Math.Pow(26, len - i);
            }
            return sum;
        }//Runtime: 62 ms Beats:83.24% Memory:38.2 MB Beats: 78.69%

        public static int TitleToNumber2(string columnTitle)
        {
            int len = columnTitle.Length;
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += (columnTitle[i] - 'A' + 1) * (int)Math.Pow(26, len - i - 1);
            }
            return sum;
        }//Runtime:69 ms Beats:55.68% Memory:38.6 MB Beats:43.75%
        static void Main(string[] args)
        {
            Console.WriteLine(TitleToNumber1("A"));
            Console.WriteLine(TitleToNumber2("AB"));
            Console.WriteLine(TitleToNumber1("ZY"));
            Console.ReadKey();
        }
    }
}
