using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n < 1)      //不能写成(n<1||n%3!=0)
            {
                return false;
            }
            else if (n == 1)
            {

                return true;
            }
            else if (n % 3 != 0)
            {
                return false;
            }
            return IsPowerOfThree(n / 3);
        }//Runtime 70 ms Beats 41.65% Memory 30 MB Beats 55.45%
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfThree(27));
            Console.WriteLine(IsPowerOfThree(0));
            Console.WriteLine(IsPowerOfThree(-1));
            Console.WriteLine(IsPowerOfThree(9));
            Console.WriteLine(IsPowerOfThree(45));
            Console.ReadKey();
        }
    }
}
