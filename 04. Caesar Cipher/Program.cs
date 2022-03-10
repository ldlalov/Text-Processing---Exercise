using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            foreach (char ch in input)
            {
                char newChar = (char)(ch + 3);
                result.Append(newChar);
            }
            Console.WriteLine(result);
        }
    }
}
