using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int start = 0;
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == ">")
                {
                    start = i + 1;
                    count = int.Parse(char.ToString(input[start]));

                    for (int j = start; j <= count; j++)
                    {
                        if (input[j].ToString() == ">")
                        {
                            count += int.Parse(char.ToString(input[j+1]));
                        }
                    }
                    input = input.Remove(start, count);
                }
                
            }
            Console.WriteLine(input);
        }
    }
}
