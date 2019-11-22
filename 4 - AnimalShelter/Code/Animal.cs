using System;

namespace AnimalShelters.Code
{
    public class Animal
    {
        public AnimalType Type { get; set; }
        public Guid UniqueAnimalId { get { return _uniqueAnimalID; } }
        public bool CanFly { get; set; }

        public Animal(AnimalType type)
        {
            Type = type;
            CanFly = Type == AnimalType.Bird;
        }

        public void AssignId()
        {
            if (UniqueAnimalId == Guid.Empty)
                _uniqueAnimalID = Guid.NewGuid();
        }

        private Guid _uniqueAnimalID;
    }
}
