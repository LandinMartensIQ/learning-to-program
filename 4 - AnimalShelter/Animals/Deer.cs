using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelters.Code
{
    public class Deer : Animal
    {
        public Deer(string name) : base(name, AnimalType.Deer)
        {
        }
        public Deer() : base(AnimalType.Deer)
        {
        }
    }
}
