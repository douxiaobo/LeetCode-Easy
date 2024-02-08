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
        public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int count = 0;
            foreach (int num1 in arr1)
            {
                bool ok = true;
                int diff = 0;
                foreach (int num2 in arr2)
                {
                    if (num2 > num1)
                    {
                        diff = num2 - num1;
                    }
                    else
                    {
                        diff = num1 - num2;
                    }
                    if (diff <= d)
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok == true)
                {
                    count++;
                }
            }
            return count++;
        }
    }//Runtime:91 ms Beats:80.33% Memory:40.2 MB Beats：65.57%
}
