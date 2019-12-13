using System;
using System.Collections.Generic;

namespace AnimalShelterCode
{
    public class Animal
    {

        public Animal(AnimalType type)
        {
            
            Type = type;

        }

        public AnimalType Type { get; private set; }
        public int UniqueAnimalId { get; internal set;  }
    }
}
