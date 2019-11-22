using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelters.Code
{
    public class AnimalShelter
    {
        public List<Animal> Animals { get { return _Animals; } }
        public AnimalShelter()
        {
            _Animals = new List<Animal>();
        }

        public OperationResult AddAnimal(Animal animal)
        {
            if (IsSupported(animal.Type)) 
            {
                animal.AssignId();
                _Animals.Add(animal);
                return new OperationResult(animal);
            }
            else
            {
                return new OperationResult($"Animal Type {animal.Type} is not Supported");
            }
        }

        public List<Animal> GetAnimals(FilterObject filter)
        {
            var filteredList = _Animals;

            if( filter.Type.HasValue && filter.CanFly.HasValue)
            {
                filteredList = _Animals.Where(a => a.CanFly == filter.CanFly
                                             && a.Type == filter.Type).ToList();
            }
            else if (filter.Type.HasValue)
            {
                filteredList = _Animals.Where(a => a.Type == filter.Type).ToList();
            }
            else if (filter.CanFly.HasValue)
            {
                filteredList = _Animals.Where(a => a.CanFly == filter.CanFly).ToList();
            }

            return filteredList;
        }
        public List<Animal> GetAnimals()
        {
            return _Animals;
        }

        public OperationResult RemoveAnimal(Animal animal)
        {
            if (_Animals.Contains(animal))
            {
                _Animals.Remove(animal);
                return new OperationResult(animal);
            }
            else
            {
                return new OperationResult("Animal is not present in shelter");
            }
        }

        public OperationResult GetAnimalFromID(Guid uniqueAnimalId)
        {
            var result = _Animals.Where(a => a.UniqueAnimalId == uniqueAnimalId);

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
        protected virtual bool IsSupported(AnimalType type)
        {
            var result =
                (  type == AnimalType.Bird
                || type == AnimalType.Cat
                || type == AnimalType.Dog
                || type == AnimalType.Snake);

            return result;
        }
        private List<Animal> _Animals;
    }
}
