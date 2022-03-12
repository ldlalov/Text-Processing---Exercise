using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
            int position = 0;
            decimal total = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char[] chars = input[i].ToCharArray();
                int last = chars.Length - 1;
                decimal number = decimal.Parse(input[i].Substring(1, input[i].Length -2));
                decimal result = number;
                if (char.IsUpper(chars[0]))
                {
                    position = chars[0] - 64;
                    result /= position;
                }
                else
                {
                    position = chars[0] - 96;
                    result *= position;
                }
                    if (char.IsUpper(chars[last]))
                {
                    position = chars[chars.Length - 1] - 64;
                    result -= position;
                }
                else
                {
                    position = chars[chars.Length-1] - 96;
                    result += position;
                }
                total += result;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
