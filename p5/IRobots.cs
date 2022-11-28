using System;
using System.Collections.Generic;
using System.Text;

namespace p5
{
    internal interface IRobots
    {
        string Model { get; set; }
        string Id { get; set; }

        string Control(string x);
    }
}
