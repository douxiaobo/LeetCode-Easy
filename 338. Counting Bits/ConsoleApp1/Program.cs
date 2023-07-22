using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i < n + 1; i++)
            {
                int count = 0;
                int a = i;
                while (a != 0)
                {
                    count += a % 2;
                    a = a / 2;
                }
                result[i] = count;
            }
            return result;
        }//Runtime:103 ms Beats:51.2% Memory:39.1 MB Beats:93.91%
        static void Main(string[] args)
        {
        }
        public int[] CountBits1(int n)
        {
            int[] result = new int[n + 1];
            int index = 0;
            for (int i = 0; i <= n; i++)
            {
                int count = 0;
                int num = i;
                while (num > 0)
                {
                    count += num % 2;
                    num = num / 2;
                }
                result[index++] = count;
            }
            return result;
        }//Runtime:105 ms Beats:43.79% Memory:39.6 MB Beats:44.92%
        public int[] CountBits2(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                int j = i;
                while (j != 0)
                {
                    result[i]++;
                    j = j & (j - 1);
                }
            }
            return result;
        }//Runtime:104 ms Beats:46.31% Memory:39.7 MB Beats:32.72%
        public int[] CountBits3(int n)  //根据“i&(i-1)”计算i的二进制形式中1的个数
        {
            int[] result = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                result[i] = result[i & (i - 1)] + 1;
            }
            return result;
        }//Runtime:97 ms Beats:77.65% Memory:39.4 MB Beats:69.82%
        public int[] CountBits4(int n)
        {
            int[] result = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                result[i] = result[i >> 1] + (i & 1);   //“i>>1”计算“i/2”，“i&1”计算“i%2”。
            }
            return result;
        }//Runtime：93 ms Beats：88.25% Memory：39.5 MB Beats：69.82%
    }
}
