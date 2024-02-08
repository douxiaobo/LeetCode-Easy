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
        public int MaxDistance(int[] colors)
        {
            int result = 0;
            for (int i = 0; i < colors.Length - 1; i++)
            {
                for (int j = i + 1; j < colors.Length; j++)
                {
                    if (colors[i] != colors[j] && (j - i) > result)
                    {
                        result = j - i;
                    }
                }
            }
            return result;
        }
    }
}
