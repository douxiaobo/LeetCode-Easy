using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int[][] Construct2DArray(int[] original, int m, int n)
        {
            int[][] arr;
            arr = new int[m][];
            if (original.Length == m * n)
            {
                for (int i = 0; i < original.Length; i++)
                {
                    if (i % n == 0)
                    {
                        arr[i / n] = new int[n];
                    }
                    arr[i / n][i % n] = original[i];
                }
                return arr;
            }
            else
            {
                return new int[0][];
            }
        }//Runtime 326 ms Beats 16.87% Memory 57.7 MB Beats 85.54%
        static void Main(string[] args)
        {
            int[][] biarray1= Construct2DArray(new int[] { 1, 2, 3, 4 }, 2, 2);
            Print(biarray1);
            int[][] biarray2 = Construct2DArray(new int[] { 1, 2, 3 }, 1, 3);
            Print(biarray2);
            int[][] biarray3 = Construct2DArray(new int[] { 1, 2 }, 1, 1);
            Print(biarray3);
            Console.Read();
        }
        public static void Print(int[][]arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.GetLength(0);i++)
            {                
                for(int j = 0; j < arr[i].Length;j++)
                {
                    if(j==0)
                    {
                        Console.Write("[" + arr[i][j]+", ");
                    }                    
                    else if (j == arr[i].Length-1)
                    {
                        Console.Write(arr[i][j] +"]");
                    }
                    else
                    {
                        Console.Write(arr[i][j] + ", ");
                    }
                }                
            }
            Console.WriteLine("]");
        }
    }
}
