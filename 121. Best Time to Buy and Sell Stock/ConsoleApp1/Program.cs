using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int MaxProfit(int[] prices)
        {
            int diff = 0, min = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (min > prices[i])
                    min = prices[i];
                else
                    diff = (prices[i] - min) > diff ? prices[i] - min : diff;
            }
            return diff;
        }
        static void Main(string[] args)
        {
            int[] prices1 = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(prices1));
            int[] prices2 = { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit(prices2));
            Console.ReadKey();
        }
    }
}
