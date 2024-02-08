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
        public string ConvertToBase7(int num)
        {
            string res = "";
            bool negative = false;
            if (num == 0)
            {
                res = "0";
            }
            if (num < 0)
            {
                num = 0 - num;
                negative = true;
            }
            while (num > 0)
            {
                int tmp = num % 7;
                res = tmp.ToString() + res;
                num /= 7;
            }
            if (negative == true)
            {
                res = "-" + res;
            }
            return res;
        }//Runtime:66 ms Beats:80.33% Memory:37.3 MB Beats:18.3%
    }
}
