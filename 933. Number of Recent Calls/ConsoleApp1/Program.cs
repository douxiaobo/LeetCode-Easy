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
        public class RecentCounter
        {
            private Queue<int> times;
            private int windowSize;

            public RecentCounter()
            {
                times = new Queue<int>();
                windowSize = 3000;
            }

            public int Ping(int t)
            {
                times.Enqueue(t);
                while (times.Peek() + windowSize < t)
                {
                    times.Dequeue();
                }
                return times.Count();
            }
        }//Runtime:283 ms Beats:69.40% Memory:68.9 MB Beats:61.94%
    }
}
/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
