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
        public bool CheckPerfectNumber(int num)
        {
            List<int> lists = new List<int>();
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    lists.Add(i);
                }
            }
            int sum = 0;
            foreach (int list in lists)
            {
                sum += list;
            }
            if (sum == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Runtime:1554 ms Beats:44.76% Memory:28.5 MB Beats:11.89%
        public bool CheckPerfectNumber1(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Runtime:1648 ms Beats:34.97% Memory:28.1 MB Beats:73.43%
    }
}
