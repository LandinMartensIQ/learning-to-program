using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelters.Code
{
    public class Snake : Animal
    {
        public Snake(string name) : base(name, AnimalType.Snake)
        {
        }
        public Snake() : base(AnimalType.Snake)
        {
        }
    }
}
