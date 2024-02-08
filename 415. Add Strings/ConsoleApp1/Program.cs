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
        public string AddStrings(string num1, string num2)
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            foreach (char num in num1)
            {
                stack1.Push(num - '0');
            }
            foreach (char num in num2)
            {
                stack2.Push(num - '0');
            }
            string str = "";
            int sum = 0;
            int plus = 0;
            while (stack1.Count > 0 || stack2.Count > 0)
            {
                if (stack1.Count > 0 && stack2.Count > 0)
                {
                    sum = stack1.Pop() + stack2.Pop() + plus;
                    if (sum > 9)
                    {
                        plus = 1;
                        sum = sum - 10;
                    }
                    else
                    {
                        plus = 0;
                    }
                }
                else if (stack1.Count > 0 && stack2.Count == 0)
                {
                    sum = stack1.Pop() + plus;
                    if (sum > 9)
                    {
                        plus = 1;
                        sum = sum - 10;
                    }
                    else
                    {
                        plus = 0;
                    }
                }
                else if (stack1.Count == 0 && stack2.Count > 0)
                {
                    sum = stack2.Pop() + plus;
                    if (sum > 9)
                    {
                        plus = 1;
                        sum = sum - 10;
                    }
                    else
                    {
                        plus = 0;
                    }
                }
                str = Convert.ToString(sum) + str;
            }
            if (plus == 1)
            {
                str = "1" + str;
            }
            return str;
        }//Runtime:110 ms Beats:5.93% Memory:55.7 MB Beats:6.72%
        public string AddStrings1(string num1, string num2)
        {
            int length1 = num1.Length - 1;
            int length2 = num2.Length - 1;
            string res = "";
            int plus = 0;
            while (length1 >= 0 || length2 >= 0)
            {
                int sum = 0;
                if (length1 >= 0 && length2 >= 0)
                {
                    sum = (num1[length1--] - '0') + (num2[length2--] - '0') + plus;
                }
                else if (length1 >= 0 && length2 < 0)
                {
                    sum = (num1[length1--] - '0') + plus;
                }
                else if (length1 < 0 && length2 >= 0)
                {
                    sum = (num2[length2--] - '0') + plus;
                }
                if (sum > 9)
                {
                    plus = 1;
                    sum = sum - 10;
                }
                else
                {
                    plus = 0;
                }
                res = Convert.ToString(sum) + res;
            }
            if (plus == 1)
            {
                res = "1" + res;
            }
            return res;
        }//Runtime:116 ms Beats:5.93% Memory:55.3 MB Beats:18.18%
    }
}
