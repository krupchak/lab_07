using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    internal class Person : ICitizens, IRobots
    {
        private string name;
        private int age;
        private string id;
        private string model;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Person(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public Person(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Control(string x)
        {
            if(Id.EndsWith(x))
            {
                return this.Id;
            }
            else
            {
                return null;
            }
        }
    }
}
