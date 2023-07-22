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
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int index = s.Length - 1;
            int result = 0;
            for (int i = g.Length - 1; i >= 0; i--)
            {
                if (index >= 0 && s[index] >= g[i])
                {
                    result++;
                    index--;
                }
            }
            return result;
        }//Runtime:115 ms Beats:55.49% Memory:44.8 MB Beats:25.82%
        public int FindContentChildren1(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int i = 0, j = 0, count = 0;
            while (i < g.Length && j < s.Length)
            {
                if (s[j] >= g[i])
                {
                    count++;
                    i++;
                    j++;
                }
                else
                {
                    j++;
                }
            }
            return count;
        }//Runtime:120 ms Beats:36.81% Memory:44.7 MB Beats:25.82%
        public int FindContentChildren2(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (index < g.Length && g[index] <= s[i])
                {
                    index++;
                }
            }
            return index;
        }//Runtime:112 ms Beats:68.68% Memory:44.3 MB Beats:80.22%
    }
}
