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
        public int DayOfYear(string date)
        {
            int result = 0;
            result += (date[8] - '0') * 10 + (date[9] - '0');
            int year = (date[0] - '0') * 1000 + (date[1] - '0') * 100 + (date[2] - '0') * 10 + (date[3] - '0');
            int month = (date[5] - '0') * 10 + (date[6] - '0');
            for (int i = 1; i < month; i++)
            {
                if (i == 2)
                {
                    result += 28;
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        result++;
                    }
                }
                else if (i == 4 || i == 6 || i == 9 || i == 11)
                {
                    result += 30;
                }
                else
                {
                    result += 31;
                }
            }
            return result;
        }
    }//Runtime:86 ms Beats:73.53% Memory:65.3 MB Beats:39.71%
}
