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
        public int CountSeniors(string[] details)
        {
            int count = 0;
            foreach (string detail in details)
            {
                int age = 0;
                for (int i = 11; i <= 12; i++)
                {
                    age = age * 10 + (detail[i] - '0');
                }
                if (age > 60)
                {
                    count++;
                }
            }
            return count;
        }
    }//Runtime:91 ms Beats:55.56% Memory:40.1 MB Beats:80.56%
}
