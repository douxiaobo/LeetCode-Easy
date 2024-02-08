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
    public class MyHashMap
    {
        private int[] set;

        public MyHashMap()
        {
            set = new int[1000001];
            for (int i = 0; i < 1000000; i++)
            {
                set[i] = -1;
            }
        }

        public void Put(int key, int value)
        {
            set[key] = value;
        }

        public int Get(int key)
        {
            return set[key];
        }

        public void Remove(int key)
        {
            set[key] = -1;
        }
    }//Runtime:288 ms Beats:14.22% Memory:57.2 MB Beats:93.36%
}
