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
        public IList<IList<int>> LargeGroupPositions(string s)
        {
            IList<IList<int>> res = new List<IList<int>>();
            int i = 0;
            while (i < s.Length)
            {
                List<int> tmp = new List<int>();
                if (i + 2 < s.Length && s[i] == s[i + 1] && s[i] == s[i + 2])
                {
                    tmp.Add(i);
                    while (i < s.Length)
                    {
                        if (i + 1 < s.Length && s[i] == s[i + 1])
                        {
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    tmp.Add(i);
                    res.Add(tmp);
                }
                else
                {
                    i++;
                }

            }
            return res;
        }
    }//Runtime：138 ms Beats：48.84% Memory:44.1 MB Beats:27.91%
}
