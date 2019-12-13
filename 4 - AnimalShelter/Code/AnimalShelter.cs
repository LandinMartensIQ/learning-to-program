using AnimalShelterCode;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AnimalShelterCode
{
    public class AnimalShelter
    {
        public int AnimalCounter { get; private set; }

        public List<Animal> Animals { get; private set; }

        public AnimalShelter()
        {
            Animals = new List<Animal>();
            AnimalCounter = 1;
        }

        public OperationResult AddAnimal(Animal animal)
        {
            if (animal.Type == AnimalType.Bear || animal.Type == AnimalType.Deer) 
            { 
                return new OperationResult($"Animal Type {animal.Type} is not Supported");
            }
            else
            {
                animal.UniqueAnimalId = AnimalCounter++;
                Animals.Add(animal);
                return new OperationResult(animal);
            }
        }

        public List<Animal> GetAnimals(AnimalType filtertype)
        {
            var filteredlist = from animal in Animals
                               where animal.Type == filtertype
                               select animal;

            return filteredlist.ToList();
        }
        public List<Animal> GetAnimals()
        {
            return Animals;
        }

        public OperationResult RemoveAnimal(Animal animal)
        {
            if (Animals.Contains(animal))
            {
                Animals.Remove(animal);
                return new OperationResult(animal);
            }
            else
            {
                return new OperationResult("Animal is not present in shelter");
            }
        }

        public OperationResult GetAnimalFromID(int uniqueAnimalId)
        {
            var result = from animal in Animals
                         where animal.UniqueAnimalId == uniqueAnimalId
                         select animal;

            if (result.Count() == 1)
            {
                return new OperationResult(result.FirstOrDefault());
            }
            else if (result.Count() < 1)
            {
                return new OperationResult($"Animal with ID {uniqueAnimalId} not found");
            }
            else
            {
                return new OperationResult("Multiple ID matches found - Shelter is in error state");
            }
        }
    }
}
