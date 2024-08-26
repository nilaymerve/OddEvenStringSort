using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenStringSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Given a string s,
            //your task is to return another string such that even-indexed and odd-indexed characters of s are grouped and the groups are space-separated.
            //Even-indexed group comes as first, followed by a space, and then by the odd-indexed part.
            string s = "0N1i2l3a4y5M6e7r8v9e0";
            string result = GroupEvenOdd(s);
            Console.WriteLine(result);
        }
        public static string GroupEvenOdd(string s)
        {
            List<string> evenChars = new List<string>();
            List<string> oddChars = new List<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                    evenChars.Add(s[i].ToString());
                else
                    oddChars.Add(s[i].ToString());
            }
                string result1 = "";
                foreach (string evenChar in evenChars)
                {
                    result1 += evenChar + " ";
                }
           // evenChars = null;
            result1 += "\n";
                foreach (string oddChar in oddChars)
                {
                    result1 += oddChar + " ";
                }
            return result1;
        }
    }
}
    
 
