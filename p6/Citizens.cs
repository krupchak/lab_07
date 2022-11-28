using System;
using System.Collections.Generic;
using System.Text;

namespace p6
{
    internal class Citizens : INameBirthdate, IId
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

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

        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public Citizens(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }

        public string Control(string y)
        {
            if (Birthdate.EndsWith(y))
            {
                return this.Birthdate;
            }
            else
            {
                return null;
            }
        }
    }
}
