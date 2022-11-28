using System;
using System.Collections.Generic;
using System.Text;

namespace p6
{
    internal class Pet : INameBirthdate
    {
        private string name;
        private string birthdate;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
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
