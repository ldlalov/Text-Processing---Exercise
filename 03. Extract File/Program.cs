using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split(':', '\\');
            string[] file = path.Last().Split('.');
            Console.WriteLine($"File name: {file[0].ToString()}");
            Console.WriteLine($"File extension: {file[1].ToString()}");
        }
    }
}
