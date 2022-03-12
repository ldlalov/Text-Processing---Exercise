using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int end = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == ">")
                {
                    if (char.IsDigit(input[i+1]))
                    {
                        end += int.Parse(char.ToString(input[i+1]));
                    }
                }
                if (end > 0)
                {
                    if (input[i].ToString() != ">")
                    {
                input = input.Remove(i, 1);
                        end--;
                        i--;
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
