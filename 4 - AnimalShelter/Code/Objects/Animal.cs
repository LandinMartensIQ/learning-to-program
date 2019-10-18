using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code.Objects
{
    class Animal
    {
        public Guid Id { get; set; }
        public AnimalTypes type { get; set; }

        public Animal(AnimalTypes wantedType)
        {
            Id = Guid.NewGuid();            
            type = wantedType;
        }
    }
}
