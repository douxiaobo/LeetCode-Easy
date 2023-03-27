using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                int count = 0;
                int a = i;
                while (a != 0)
                {
                    count += a % 2;
                    a = a / 2;
                }
                result[i] = count;
            }
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
