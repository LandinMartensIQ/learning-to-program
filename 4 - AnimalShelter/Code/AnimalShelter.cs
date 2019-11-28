using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//rework enums
//restore proper list

namespace AnimalShelter.Code
{
    public class AnimalShelter
    {
        //private List<Animal> _animals = new List<Animal>();
        private List<Animal> _animals = new List<Animal>();
        public List<Animal> animals
        {
            get { return _animals; }
            set { _animals = value; }
        }
        public AnimalShelter()
        {
               
        }
        public Result AddAnimal(Animal animal)
        {
            if (animal.AnimalType == AnimalType.Deer || animal.AnimalType == AnimalType.Bear)
            {
                return new Result( "Animal was not a supported animal");
            }
            else
            {
                _animals.Add(animal);//using mine
                return new Result(animal);
            }
        }

        public Result RemoveAnimal(Animal animal)
        {
            if (animal.AnimalType == AnimalType.Deer || animal.AnimalType == AnimalType.Bear)
            {
                return new Result("Animal was not a supported animal");
            }
            //else if(animals.Contains(animal))
            //{
            var wasRemoved =_animals.Remove(animal);
            if(wasRemoved)
            { 
                return new Result(animal);
             }
            else
            {
                return new Result("This animal is not in the shelter");
            }       
        }

        public Result GetAnimalFromId(Guid uniqueAnimalId)
        {
            var animal = animals.FirstOrDefault(a => a.UniqueAnimalId == uniqueAnimalId);

            if (animal == null)
            {
                return new Result("This animal is not in the shelter");
            }
            else
            {
                return new Result(animal);
            }

        }

        public List<Animal> GetAnimals(FilterTypes filter)
        {
            List<Animal> FilteredAnimals= new List<Animal>();
            switch (filter)
            {
                case FilterTypes.Fly:
                    FilteredAnimals.AddRange(from Animal animal in _animals
                                             where animal.AnimalType == AnimalType.Bird
                                             select animal);
                    return FilteredAnimals;
                case FilterTypes.Cat:
                    FilteredAnimals.AddRange(from Animal animal in _animals
                                             where animal.AnimalType == AnimalType.Cat
                                             select animal);
                    return FilteredAnimals;
                case FilterTypes.Dog:
                    FilteredAnimals.AddRange(from Animal animal in _animals
                                             where animal.AnimalType == AnimalType.Dog
                                             select animal);
                    return FilteredAnimals;
                default:
                    return _animals;
            }

            
        }

    }
}
