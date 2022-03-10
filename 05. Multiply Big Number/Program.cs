using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger first = BigInteger.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            BigInteger result = first * second;
            Console.WriteLine(result);
        }
    }
}
