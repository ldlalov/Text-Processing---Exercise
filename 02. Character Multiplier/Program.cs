using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string first = input[0];
            string second = input[1];
            int charCount = 0;
            int total = 0;
            int restCharSum = 0;
                if (first.Length < second.Length)
                {
                    charCount = first.Length;
                for (int i = charCount; i < second.Length; i++)
                {
                    restCharSum += second[i];
                }
                }
                else
                {
                    charCount = second.Length;
                for (int i = charCount; i < first.Length; i++)
                {
                    restCharSum += first[i];
                }
            }
            for (int j = 0; j < charCount; j++)
                {
                total += first[j] * second[j];
                }
            total += restCharSum;
            Console.WriteLine(total);
        }
    }
}
