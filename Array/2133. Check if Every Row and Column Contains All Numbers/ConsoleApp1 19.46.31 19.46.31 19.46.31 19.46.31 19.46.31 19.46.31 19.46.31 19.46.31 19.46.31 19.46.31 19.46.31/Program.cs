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
        public bool CheckValid(int[][] matrix)
        {
            int numRows = matrix.Length;
            int numCols = matrix[0].Length;

            //Check the rows.
            for (int i = 0; i < numRows; i++)
            {
                HashSet<int> seen = new HashSet<int>();
                for (int j = 0; j < numCols; j++)
                {
                    if (seen.Contains(matrix[i][j]))
                    {
                        return false;
                    }
                    seen.Add(matrix[i][j]);
                }
            }

            //Check the colums.
            for (int j = 0; j < numCols; j++)
            {
                HashSet<int> seen = new HashSet<int>();
                for (int i = 0; i < numRows; i++)
                {
                    if (seen.Contains(matrix[i][j]))
                    {
                        return false;
                    }
                    seen.Add(matrix[i][j]);
                }
            }
            return true;
        }
    }//Runtime：238 ms Beats：41.67% Memory:58.4 MB Beats:62.50%
    public class Solution1
    {
        public bool CheckValid(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int[] index = new int[matrix.Length];
                for (int j = 0; j < matrix.Length; j++)
                {
                    index[matrix[i][j] - 1]++;
                    if (index[matrix[i][j] - 1] > 1)
                    {
                        return false;
                    }
                }
            }
            for (int j = 0; j < matrix.Length; j++)
            {
                int[] index = new int[matrix.Length];
                for (int i = 0; i < matrix.Length; i++)
                {
                    index[matrix[i][j] - 1]++;
                    if (index[matrix[i][j] - 1] > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }//Runtime：201 ms Beats：97.92% Memory：58.1 MB Beats：95.83%
}
