using System;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char current = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == current)
                {
                    input = input.Remove(i, 1);
                    i--;
                }
                else
                {
                    current = input[i];
                }
            }
            Console.WriteLine(input);
        }
    }
}
