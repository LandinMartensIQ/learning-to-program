using AnimalShelter2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter2.Code
{
    public class Shelter
    {
        private List<Animal> _animals = new List<Animal>();
        public List<Animal> Animals 
        {   get { return _animals; }
            set { _animals = value; } 
        }

        public Shelter()
        {
           
        }

        public Answer AddAnimal(Animal animal)
        {
            //Check if animal is not supported - if so add animal to list
            if (animal.AnimalType == Enum.KnownAnimals.Deer || animal.AnimalType == Enum.KnownAnimals.Bear)
            {
                return new Answer("This animal is not supported");
            }
            else
            {
                animal.UniqueAnimalId = Guid.NewGuid();
                _animals.Add(animal);
                return new Answer(true,animal,null);
            }
        }

        public List<Animal> GetAnimal(string filter)
        {
            //Returns list of animal according to the filter type (I left commented some of my old -notgood- code)
            List<Animal> animalLists = new List<Animal>();
            
            if (filter == "Fly")
            {
                //if (item.AnimalType == KnownAnimals.Bird)
                //{
                animalLists.AddRange(from Animal animal in _animals where animal.AnimalType == KnownAnimals.Bird select animal);

                        //    List<Animal> animalLists = new List<Animal>
                        //    {
                        //        new Animal
                        //        { AnimalType = KnownAnimals.Bird, UniqueAnimalId = _animals[count].UniqueAnimalId }
                        //    };
                        //    return animalLists;
                   // }
                    //count++;
                    //animalLists.AddRange(from Animal animal in _animals where animal.AnimalType == KnownAnimals.Bird select animal);
             }
             else if (filter == "Cats")
             {
                 animalLists.AddRange(from Animal animal in _animals where animal.AnimalType == KnownAnimals.Cat select animal);
             }
             else if (filter == "Dogs")
             {
                 animalLists.AddRange(from Animal animal in _animals where animal.AnimalType == KnownAnimals.Dog select animal);
             }
             else if (filter == "All")
             {
                 animalLists.AddRange(from Animal animal in _animals select animal);
             }
            
            //return new List<Animal>();
            return animalLists;
        }


        public Answer GetAnimalById(string uniqueID)
        {
            try
            {
                var newUniqueId = Guid.Parse(uniqueID);
                var result = _animals.FirstOrDefault(animal => animal.UniqueAnimalId == newUniqueId);

                if (result == null)
                {
                    //return new Answer(false, result, null);
                    return new Answer("This animal is not found because it is not supported");
                }
                else
                {
                    return new Answer(true, result, null);
                }
            }
            catch (FormatException)
            {
                return new Answer("ID is not in the correct format");
            }  
            
            //*******My code before refactoring the Linq above******************************************
            //var result = from Animal animals in _animals where animals.UniqueAnimalId == uniqueID select animals;
            //var result2 = result.FirstOrDefault();

            //********Wrong code below - when I was attempting to place the results into a list***********
            //animalLists.AddRange(from Animal animals in _animals where animals.UniqueAnimalId == uniqueID select animals);
            //var result2 = result.ToList();

        }

        public Answer RemoveAnimal(Animal animal)
        {
            if (animal.AnimalType == Enum.KnownAnimals.Deer || animal.AnimalType == Enum.KnownAnimals.Bear)
            {
                return new Answer("This animal is not supported so it cannot be removed");
            }
            else if (animal.UniqueAnimalId == Guid.Empty)
            {
                return new Answer("There is no animal to remove");
            }
            else
            {
                _animals.Remove(animal);
                return new Answer(true, animal, null);
            }
        }
    }
}
