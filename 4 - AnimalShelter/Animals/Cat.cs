using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelters.Code
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name, AnimalType.Cat)
        {
        }
        public Cat() : base(AnimalType.Cat)
        {
        }
    }
}
