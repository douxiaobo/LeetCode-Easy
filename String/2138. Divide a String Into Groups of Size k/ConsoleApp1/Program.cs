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
        public string[] DivideString(string s, int k, char fill)
        {
            int numGroups = (s.Length + k - 1) / k;
            string[] res = new string[numGroups];
            int i = 0;
            int index = 0;
            while (index < s.Length)
            {
                if (index % k == 0 && i < numGroups)
                {      //缺少考虑这个
                    res[i] = "";
                }
                res[i] += s[index];
                if ((index + 1) % k == 0)
                {             //清楚了
                    i++;
                }
                index++;
            }
            while ((index % k) != 0)
            {              //原本k-index>0，缺少考虑这个。
                res[numGroups - 1] += fill;
                index++;
            }
            return res;
        }
    }//Runtime:162 ms Beats:11.43% Memory:45.8 MB Beats:5.71%
}
