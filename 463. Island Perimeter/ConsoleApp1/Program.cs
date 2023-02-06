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
    }
}
