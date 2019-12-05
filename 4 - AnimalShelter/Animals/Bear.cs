using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelters.Code
{
    public class Bear : Animal
    {
        public Bear(string name) : base(name, AnimalType.Bear)
        {
        }
        public Bear() : base(AnimalType.Bear)
        {
        }
    }
}
