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
        public class MyHashSet
        {
            private bool[] set;

            public MyHashSet()
            {
                set = new bool[1000001];
            }

            public void Add(int key)
            {
                set[key] = true;
            }

            public void Remove(int key)
            {
                set[key] = false;
            }

            public bool Contains(int key)
            {
                return set[key];
            }
        }//Runtime:239 ms Beats:50% Memory:66.8 MB Beats:31.58%
    }
}
