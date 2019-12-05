using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelters.Code
{
    public class AnimalShelter
    {
        public AnimalList Animals { get; private set; } = new AnimalList();

        public OperationResult AddAnimal(Animal animal)
        {
            if (IsSupported(animal.Type)  && AnimalIdIsNew(animal.UniqueAnimalId)) 
            {
                Animals.Add(animal);
                return new OperationResult(animal);
            }
            else if (!AnimalIdIsNew(animal.UniqueAnimalId))
            {
                return new OperationResult($"Animal ID {animal.UniqueAnimalId} already appears within Shelter");
            }
            else
            {
                return new OperationResult($"Animal Type {animal.Type} is not Supported");
            }
        }
        public bool CanFlyFilter(Animal animal, bool filter)
        {
            return animal.CanFly == filter;
        }
        public List<Animal> GetAnimals(AnimalFilter filter)
        {
            //IEnumerable<Animal> filteredList = Animals;

            return Animals  .Filter(filter.CanFly, (animal, filtervalue) => animal.CanFly == filtervalue)
                            .Filter(filter.Sex, (animal, filtervalue) => animal.Sex == filtervalue)
                            .Filter(filter.Neutered, (animal, filtervalue) => animal.Neutered == filtervalue)
                            .Filter(filter.Type, (animal, filtervalue) => animal.Type == filtervalue)
                            .Filter(filter.Domesticated, (animal, filtervalue) => animal.Domesticated == filtervalue)
                            .Filter(filter.Name, (animal, filtervalue) => animal.Name == filtervalue);


            //Version n - 1
            //filteredList = filter.CanFly.Apply((value) =>
            //{
            //    return filteredList.Where(a => a.CanFly == value);
            //});

            //filteredList = filter.Sex.Apply((value) =>
            //{
            //    return filteredList.Where(a => a.Sex == value);
            //});
            //filteredList = filter.Neutered.Apply((value) =>
            //{
            //    return filteredList.Where(a => a.Neutered == value);
            //});
            //filteredList = filter.Domesticated.Apply((value) =>
            //{
            //    return filteredList.Where(a => a.Domesticated == value);
            //});
            //filteredList = filter.Type.Apply((value) =>
            //{
            //    return filteredList.Where(a => a.Type == value);
            //});
            //filteredList = filter.Name.Apply((value) =>
            //{
            //    return filteredList.Where(a => a.Name == value);
            //});

            //FILTER NOW ACCOMPLISHES FILTERING BY ANY OF UP TO SIX PARAMETERS, IGNORING UNUSED FIELDS IN THE ANIMALFILTER OBJECT

            //if (filter.Type.HasValue)
            //    filteredList = filteredList.Where(a => a.Type == filter.Type);

            //if (filter.CanFly.HasValue())
            //    filteredList = filteredList.Where(a => a.CanFly == filter.CanFly.Value);


            //if (filter.Sex.HasValue)
            //    filteredList = filteredList.Where(a => a.Sex == filter.Sex);

            //if (filter.Neutered.HasValue)
            //    filteredList = filteredList.Where(a => a.Neutered == filter.Neutered);

            //if (filter.Domesticated.HasValue)
            //    filteredList = filteredList.Where(a => a.Domesticated == filter.Domesticated);

            //if (filter.Name != null)
            //    filteredList = filteredList.Where(a => a.Name == filter.Name);

            //INITIAL VERSION OF CODE
            //if( filter.Type.HasValue && filter.CanFly.HasValue)
            //{
            //    filteredList = Animals.Where(a => a.CanFly == filter.CanFly
            //                                 && a.Type == filter.Type).ToList();
            //}
            //else if (filter.Type.HasValue)
            //{
            //    filteredList = Animals.Where(a => a.Type == filter.Type).ToList();
            //}
            //else if (filter.CanFly.HasValue)
            //{
            //    filteredList = Animals.Where(a => a.CanFly == filter.CanFly).ToList();
            //}

            //return filteredList.ToList();
        }
        public List<Animal> GetAnimals()
        {
            return Animals.ToList();
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

        public OperationResult GetAnimalFromID(Guid uniqueAnimalId)
        {
            var result = Animals.Where(a => a.UniqueAnimalId == uniqueAnimalId);

            if (result.Count() == 1)
            {
                return new OperationResult(result.First());
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
        public bool AnimalIdIsNew(Guid ID)
        {
            return Animals.Where(a => a.UniqueAnimalId == ID).Count() == 0;
        }
        public virtual bool IsSupported(AnimalType type)
        {
            var result =
                (  type == AnimalType.Bird
                || type == AnimalType.Cat
                || type == AnimalType.Dog
                || type == AnimalType.Snake);

            return result;
        }

    }
}
