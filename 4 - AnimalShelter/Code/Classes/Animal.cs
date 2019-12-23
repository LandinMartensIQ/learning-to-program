using AnimalShelter.Code.Enums;
using AnimalShelter.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code.Classes
{
    public class Animal : IAnimal
    {
        public Guid UniqueAnimalId { get; set; }
        public AnimalType AnimalType { get; }
        public bool AnimalCanFly { get; set; }

        public Animal(AnimalType animalType)
        {
            UniqueAnimalId = Guid.NewGuid();
            AnimalType = animalType;
            SetPropertiesByType(animalType);
        }

        private void SetPropertiesByType(AnimalType animalType)
        {
            AnimalCanFly = (animalType == AnimalType.Bird);
        }
    }
}
