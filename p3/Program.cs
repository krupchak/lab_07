using System;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            ICar ferrari = new Ferrari(name);
            Console.WriteLine(ferrari);
        }
    }
}
