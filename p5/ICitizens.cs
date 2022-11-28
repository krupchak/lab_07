using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    internal interface ICitizens
    {
        string Name { get; set; }
        int Age { get; set; }
        string Id { get; set; }

        string Control(string x);
    }
}
