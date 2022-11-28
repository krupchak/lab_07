using System;
using System.Collections.Generic;

namespace p6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citizens> citizens = new List<Citizens>();
            List<Robots> robots = new List<Robots>();
            List<Pet> pet = new List<Pet>();

            bool end = false;
            while (!end)
            {
                var input = Console.ReadLine().Split(" ");
                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    citizens.Add(new Citizens(name, age, id));
                }
                else if (input.Length == 2)
                {
                    string model = input[0];
                    string id = input[1];
                    robots.Add(new Robots(model, id));
                }
                else if (input.Length == 1 && input[0] == "End")
                {
                    end = true;
                }
            }

            string year = Console.ReadLine();

            foreach (var c in citizens)
            {
                Console.WriteLine(c.Control(year));
            }

            foreach (var p in pet)
            {
                Console.WriteLine(p.Control(year));
            }
        }
    }
}
