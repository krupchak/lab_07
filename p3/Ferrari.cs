using System;
using System.Collections.Generic;
using System.Text;

namespace p3
{
    internal class Ferrari : ICar
    {
        private string carModel;
        private string name;

        public string CarModel
        {
            get { return carModel; }
            set { carModel = value; }
        }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public Ferrari (string name)
        {
            this.CarModel = "488-Spider";
            this.Name = name;
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"{this.CarModel}/{this.Name}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
