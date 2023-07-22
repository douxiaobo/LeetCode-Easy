using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> Pascal = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                IList<int> list = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        list.Add(1);
                    }
                    else
                    {
                        list.Add(Pascal[i - 1][j - 1] + Pascal[i - 1][j]);
                    }
                }
                Pascal.Add(list);
            }
            return Pascal;
        }
        public IList<IList<int>> Generate1(int numRows)
        {
            var Pascal = new List<IList<int>>();
            for (int i = 0; i < numRows; i++)
            {
                int[] array = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        array[j] = 1;
                    }
                    else
                    {
                        array[j] = Pascal[i - 1][j - 1] + Pascal[i - 1][j];
                    }
                }
                Pascal.Add(array.ToList());
            }
            return Pascal;
        }
        public static void Print(IList<IList<int>> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                for(int j = 0; j <= i;j++)
                {
                    Console.Write(list[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int numRow1 = 1;
            int numRow2 = 5;
            int numRow3 = 10;
            Print(Generate(numRow1));
            Print(Generate(numRow2));
            Print(Generate(numRow3));
            Console.ReadKey();
        }
    }
}
