using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int[] ReplaceElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    arr[i] = -1;
                }
                else
                {
                    int max = 0;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] > max)
                        {
                            max = arr[j];
                        }
                    }
                    arr[i] = max;
                    if (arr[i] == arr[i + 1])
                    {
                        arr[i + 1] = -1;
                    }
                }
            }
            return arr;
        }//Runtime:1870 ms Beats:11.71% Memory:62.6 MB Beats:34.49%
        static void Main(string[] args)
        {
        }
    }
}
