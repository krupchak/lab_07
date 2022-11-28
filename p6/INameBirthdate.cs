using System;
using System.Collections.Generic;
using System.Text;

namespace p6
{
    internal interface INameBirthdate
    {
        string Name { get; set; }
        string Birthdate { get; set; }

        string Control(string y);
    }
}
