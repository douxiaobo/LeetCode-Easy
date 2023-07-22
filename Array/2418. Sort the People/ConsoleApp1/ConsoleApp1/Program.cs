using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public string[] SortPeople(string[] names, int[] heights)
        {
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (heights[j] > heights[j - 1])
                    {
                        int tmpint = heights[j];
                        heights[j] = heights[j - 1];
                        heights[j - 1] = tmpint;
                        string tmpstr = names[j];
                        names[j] = names[j - 1];
                        names[j - 1] = tmpstr;
                    }
                }
            }
            return names;
        }
    }//Runtime:230 ms Beats:13.76% Memory:60.6 MB Beats:66.14%
}
