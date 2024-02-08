using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] record = new int[26];
            for (int i = 0; i < 26; i++)
            {
                record[i] = 0;
            }
            for (int i = 0; i < ransomNote.Length; i++)
            {
                record[ransomNote[i] - 'a']++;
            }
            for (int i = 0; i < magazine.Length; i++)
            {
                record[magazine[i] - 'a']--;
            }
            for (int i = 0; i < 26; i++)
            {
                if (record[i] >= 1)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
        }
    }
}
