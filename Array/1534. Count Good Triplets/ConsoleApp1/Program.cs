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
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int counts = 0;
            int a1 = 0, b1 = 0, c1 = 0;
            bool ba = false, bb = false, bc = false;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[j] < arr[k])
                        {
                            b1 = arr[k] - arr[j];
                        }
                        else
                        {
                            b1 = arr[j] - arr[k];
                        }
                        if (b1 > b)
                        {
                            bb = false;
                        }
                        else
                        {
                            bb = true;
                        }
                        if (arr[i] < arr[k])
                        {
                            c1 = arr[k] - arr[i];
                        }
                        else
                        {
                            c1 = arr[i] - arr[k];
                        }
                        if (c1 > c)
                        {
                            bc = false;
                        }
                        else
                        {
                            bc = true;
                        }
                        if (arr[i] < arr[j])
                        {
                            a1 = arr[j] - arr[i];
                        }
                        else
                        {
                            a1 = arr[i] - arr[j];
                        }
                        if (a1 > a)
                        {
                            ba = false;
                        }
                        else
                        {
                            ba = true;
                        }
                        if (ba == true && bb == true && bc == true)
                        {
                            counts++;
                        }
                    }

                }

            }
            return counts;
        }
    }//Runtime:116 ms Beats:21.69% Memory:38.2 MB Beats:96.39%
}
