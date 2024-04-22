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
    public class Solution_Example
    {
        public bool CheckIfExist(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                if (seen.Contains(num * 2) || (num % 2 == 0 && seen.Contains(num / 2)))
                {
                    return true;
                }
                seen.Add(num);
            }

            return false;
        }
    }
    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            bool[] index = new bool[2001];
            foreach (int num in arr)
            {
                int doubleNum = num * 2;
                int halfNum = num / 2;
                if (num != 0 && doubleNum >= -1000 && doubleNum <= 1000 && index[doubleNum + 1000])
                {
                    return true;
                }
                if (num % 2 == 0 && halfNum >= -1000 && halfNum <= 1000 && index[halfNum + 1000])
                {
                    return true;
                }
                index[num + 1000] = true;
            }
            return false;
        }
    }//Runtime:87 ms Beats:99.46% Memory:41.1 MB Beats:37.3%
}
