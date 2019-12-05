using System;

namespace AnimalShelters.Code
{
    public abstract class Animal
    {
        public virtual string Name { get;  set; }
        public virtual AnimalSex Sex { get;  set; }
        public virtual string Breed { get;  set; }
        public virtual bool Neutered { get;  set; }
        public virtual bool Domesticated { get;  set; }
        public virtual bool CanFly { get; private set; }
        public AnimalType Type { get; private set; }
        public Guid UniqueAnimalId { get; private set; } = Guid.NewGuid();

        public Animal(string name, AnimalType type)
        {
            Name = name;
            Type = type;
        }
        public Animal(AnimalType type)
        {
            Type = type;
            Name = "Not Set";
        }
        public virtual OperationResult ModifyAnimal(AnimalModification mod)
        {
            var animalModified = false;

            if (mod.Name.OptionIsApplied() && mod.Name.Value != Name)
            {
                Name = mod.Name.Value;
                animalModified = true;
            }

            if (mod.CanFly.OptionIsApplied() && mod.CanFly.Value != CanFly)
            {
                CanFly = mod.CanFly.Value;
                animalModified = true;
            }

            if (mod.Domesticated.OptionIsApplied() && mod.Domesticated.Value != Domesticated)
            {
                Domesticated = mod.Domesticated.Value;
                animalModified = true;
            }
            
            if (mod.Neutered.OptionIsApplied()  && mod.Neutered.Value != Neutered)
            {
                Neutered = mod.Neutered.Value;
                animalModified = true;
            }

            if (mod.Sex.OptionIsApplied() && mod.Sex.Value != Sex)
            {
                Sex = mod.Sex.Value;
                animalModified = true;
            }
            
            if(animalModified)
            {
                return new OperationResult(this);
            }
            else
            {
                return new OperationResult("No Data Modified in Request");
            }
        }
    }
}
