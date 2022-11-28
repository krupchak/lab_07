using System;
using System.Collections.Generic;
using System.Text;

namespace p6
{
    internal class Robots : IId
    {
        private string model;
        private string id;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Robots (string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}
