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
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (n == 0)
                {
                    break;
                }
                if (i == 0 && flowerbed[i] == 0 && (i + 1 >= flowerbed.Length || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                }
                else if (i == flowerbed.Length - 1 && flowerbed[i] == 0 && (i - 1 < 0 || flowerbed[i - 1] == 0))
                {
                    flowerbed[i] = 1;
                    n--;
                }
                else if (i - 1 >= 0 && i + 1 < flowerbed.Length && flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    flowerbed[i] = 1;
                    n--;
                }
            }
            return n == 0;
        }
    }//Runtime:107 ms Beats:82.67% Memory:45.9 MB Beats:46.55%
}
