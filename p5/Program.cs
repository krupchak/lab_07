using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace p5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ICitizens> citizens = new List<ICitizens>();
            List<IRobots> robots = new List<IRobots>();

            bool end = false;
            while (!end)
            {
                var input = Console.ReadLine().Split(" ");
                if(input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    citizens.Add(new Person(name, age, id));
                }
                else if(input.Length == 2)
                {
                    string model = input[0];
                    string id = input[1];
                    robots.Add(new Person(model, id));
                }
                else if(input.Length == 1 && input[0] == "End")
                {
                    end = true;
                }
            }

            string x = Console.ReadLine();
            
            foreach(var c in citizens)
            {
                Console.WriteLine(c.Control(x));
            }

            foreach(var r in robots)
            {
                Console.WriteLine(r.Control(x));
            }
        }
    }
}
