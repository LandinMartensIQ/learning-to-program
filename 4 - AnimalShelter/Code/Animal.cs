using System;


namespace AnimalShelter.Code
{
    public class Animal
    {
        public Guid UniqueAnimalId { get; private set; }
        public AnimalType AnimalType { get; set; }
        public Animal(AnimalType animalType)
        {
            AnimalType = animalType;
            UniqueAnimalId = Guid.NewGuid();
        }
    }
}
