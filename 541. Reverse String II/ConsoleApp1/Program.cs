using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public string ReverseStr(string s, int k)
        {
            // 将字符串转为字符数组，方便进行字符的交换
            char[] arr = s.ToCharArray();
            // 每2k个字符为一组，对于每一组，交换前k个字符
            for (int i = 0; i < s.Length; i += 2 * k)
            {
                // 记录下标范围
                int start = i;    //起始下标
                int end = Math.Min(i + k - 1, s.Length - 1); //终止下标
                //对于范围内的前k个字符，进行翻转
                while (start < end)
                {
                    char temp = arr[start];
                    arr[start++] = arr[end];
                    arr[end--] = temp;
                }
            }
            //返回翻转后的字符串
            return new string(arr);
        }//Runtime:88 ms Beats:46.41% Memory:39.3 MB Beats:84.53%
        static void Main(string[] args)
        {
        }
        public string ReverseStr1(string s, int k)
        {
            // 将字符串转为字符数组，方便进行字符的交换
            char[] arr = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = s[i];
            }
            // 每2k个字符为一组，对于每一组，交换前k个字符
            for (int i = 0; i < s.Length; i += 2 * k)
            {
                // 记录下标范围
                int start = i;    //起始下标
                int end = Math.Min(i + k - 1, s.Length - 1); //终止下标
                                                             //对于范围内的前k个字符，进行翻转
                while (start < end)
                {
                    char temp = arr[start];
                    arr[start++] = arr[end];
                    arr[end--] = temp;
                }
            }
            //返回翻转后的字符串
            s = "";
            for (int i = 0; i < arr.Length; i++)
            {
                s += arr[i];
            }
            return s;
        }//Runtime:193 ms Beats:11.60% Memory:56.6 MB Beats:5.52%
        public string ReverseStr2(string s, int k)
        {
            if (k == 1)     //特殊情况，k=1时不需要翻转
            {
                return s;
            }
            char[] array = s.ToCharArray();
            for (int i = 0; i < array.Length; i += 2 * k)
            {
                int left = i;
                int right = Math.Min(i + k - 1, array.Length - 1);  //保证右边界不越界
                while (left < right)
                {
                    char temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;
                    left++;
                    right--;
                }
            }
            return new string(array);
        }//Runtime:85 ms Beats:59.67% Memory:39.5 MB Beats:63.54%
    }
}
