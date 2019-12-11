using AnimalShelter2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter2
{
    public class Animal
    {

        public KnownAnimals AnimalType { get; set; }
        public Guid UniqueAnimalId { get; set; }
        public Animal(KnownAnimals animalType)
        {
            AnimalType = animalType;
        }

        public Animal(Guid uniqueAnimalId)
        {
            UniqueAnimalId = uniqueAnimalId;
        }

        public Animal()
        {
        }
    }
}
