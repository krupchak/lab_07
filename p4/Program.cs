using System;
using System.Collections.Generic;

namespace p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPhones> number = new List<IPhones>();
            List<IWorldWideWeb> sites = new List<IWorldWideWeb>();
            var input1 = Console.ReadLine().Split(" ");
            foreach (var inp in input1)
            {
                int n = int.Parse(inp);
                number.Add(new Smartphone(n));
            }

            var input2 = Console.ReadLine().Split(" ");
            foreach (var inp in input2)
            {
                sites.Add(new Smartphone(inp));
            }

            foreach (var n in number)
            {
                Console.WriteLine($"Calling... {n.PhoneNumber}");
            }

            foreach (var s in sites)
            {
                Console.WriteLine($"Browsing: {s.Sites}!");
            }
        }
    }
}
