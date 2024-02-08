using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
            int row = grid.Length;
            int col = grid[0].Length;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        perimeter += 4;
                        if (i + 1 < row && grid[i + 1][j] == 1)
                        {
                            perimeter--;
                        }
                        if (i - 1 >= 0 && grid[i - 1][j] == 1)
                        {
                            perimeter--;
                        }
                        if (j - 1 >= 0 && grid[i][j - 1] == 1)
                        {
                            perimeter--;
                        }
                        if (j + 1 < col && grid[i][j + 1] == 1)
                        {
                            perimeter--;
                        }
                    }
                }
            }
            return perimeter;
        }
        static void Main(string[] args)
        {
            int[][] grid1 = { new int[] { 0, 1, 0, 0 }, new int[] { 1, 1, 1, 0 }, new int[] { 0, 1, 0, 0 }, new int[] { 1, 1, 0, 0 } };
            Console.WriteLine(IslandPerimeter(grid1));
            int[][] grid2 =  { new int[] { 1 } };
            Console.WriteLine(IslandPerimeter(grid2));
            int[][] grid3 =  { new int[] {  1, 0 } };
            Console.WriteLine(IslandPerimeter(grid3));
            Console.ReadKey();
        }
        public int IslandPerimeter1(int[][] grid)
        {
            int res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (i - 1 < 0 || grid[i - 1][j] == 0)
                        {
                            res++;
                        }
                        if (i + 1 > grid.Length - 1 || grid[i + 1][j] == 0)
                        {
                            res++;
                        }
                        if (j - 1 < 0 || grid[i][j - 1] == 0)
                        {
                            res++;
                        }
                        if (j + 1 > grid[i].Length - 1 || grid[i][j + 1] == 0)
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }
        public int IslandPerimeter2(int[][] grid)
        {
            int res = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        if (i == 0 || grid[i - 1][j] == 0)
                        {
                            res++;
                        }
                        if (i == grid.Length - 1 || grid[i + 1][j] == 0)
                        {
                            res++;
                        }
                        if (j == 0 || grid[i][j - 1] == 0)
                        {
                            res++;
                        }
                        if (j == grid[i].Length - 1 || grid[i][j + 1] == 0)
                        {
                            res++;
                        }
                    }
                }
            }
            return res;
        }
    }
}
