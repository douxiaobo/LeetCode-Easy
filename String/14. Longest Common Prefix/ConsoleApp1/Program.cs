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
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string res = "";
            int index = 0, shortlength = 200;
            bool noprefix = true;
            foreach (string str in strs)
            {
                if (shortlength > str.Length)
                {
                    shortlength = str.Length;
                }
            }
            while (index < shortlength)
            {
                char chtmp = strs[0][index];
                foreach (string str in strs)
                {
                    if (str[index] != chtmp)
                    {
                        noprefix = false;
                        break;
                    }
                }
                if (noprefix == false)
                {
                    break;
                }
                res += chtmp;
                index++;
            }
            return res;
        }
    }//Runtime:108 ms Beats:21.76% Memory:40.1 MB Beats:56.67%
}
