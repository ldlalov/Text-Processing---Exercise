using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var username in usernames)
            {
                bool valid = true;
                if (username.Length < 3 || username.Length > 16)
                {
                    continue;
                }
                char[] validUsername = username.ToCharArray();
                foreach (char ch in validUsername)
                {
                    if (!(char.IsLetterOrDigit(ch) || ch.ToString() == "-" || ch.ToString() == "_"))
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    Console.WriteLine(username);
                }
            }

        }
    }
}
