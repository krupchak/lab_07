using System;
using System.Collections.Generic;
using System.Text;

namespace p4
{
    internal class Smartphone : IPhones, IWorldWideWeb
    {
        private int phone_number;
        private string sites;

        public int PhoneNumber
        {
            get { return phone_number; }
            set { phone_number = value; }
        }

        public string Sites
        {
            get { return sites; }
            set 
            { 
                foreach(char c in value)
                {
                    if(!Char.IsLetter(c))
                    {
                        value = "Invalid URL!";
                    }
                }
                sites = value; 
            }
        }

        public Smartphone(int phone_number)
        {
            this.PhoneNumber = phone_number;
        }

        public Smartphone(string sites)
        {
            this.Sites = sites;
        }


    }
}
