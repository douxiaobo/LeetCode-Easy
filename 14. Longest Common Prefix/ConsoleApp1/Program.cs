using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string strresult = "";
            int i = 0, smallest = 201;
            foreach (var str in strs)
            {
                if (smallest > str.Length)
                {
                    smallest = str.Length;
                }
            }
            while (i < smallest)
            {
                char strtmp = strs[0][i];
                int flag = 0;
                foreach (string str in strs)
                {
                    if (str[i] != strtmp)
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    break;
                }
                else
                {
                    strresult = strresult + strtmp;
                    i++;
                }
            }
            return strresult;
        }
        static void Main(string[] args)
        {
            string[] strs1 = { "flower", "flow", "flight" };
            string[] strs2 = { "dog", "racecar", "car" };
            Console.WriteLine(LongestCommonPrefix(strs1));
            Console.WriteLine(LongestCommonPrefix(strs2));
            Console.ReadKey();
        }
    }
}
