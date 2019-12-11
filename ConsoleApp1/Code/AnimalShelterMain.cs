using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Code.Objects
{
    public class AnimalShelterMain
    {

        //public Dictionary<int, string> dict = new Dictionary<int, string>();
        //Guid animalId = Guid.NewGuid();
        //public Dictionary<Guid, string> animalDict = new Dictionary<Guid, string>();
        public List<Animal> Animals { get { return _Animals; } }

        private List<Animal> _Animals;

        public AnimalShelterMain()
        {
            _Animals = new List<Animal>();
        }

        //public Dictionary<string, object> animalDict { get; set; }

        //public void Set(Guid key, string value)
        //{
        //    if (animalDict.ContainsKey(key))
        //    {
        //        animalDict[key] = value;
        //    }
        //    else
        //    {
        //        animalDict.Add(key, value);
        //    }
        //}

        //public string Get(Guid key)
        //{
        //    string result = null;

        //    if (animalDict.ContainsKey(key))
        //    {
        //        result = animalDict[key];
        //    }

        //    return result;
        //}
        private static void Main(string[] args)
        {
            
        }
        public ReturnResult AddAnimal(Animal animal)
        {
            var result = new ReturnResult();
           // var animalType = animal.Type;

            if (CheckSupported(animal.AnimalType))
            {
                _Animals.Add(animal);
                animal.MarkUniqueId();
            }

            return result;
        }

        public ReturnResult GetAnimal(string filter)
        {
            var result = new ReturnResult();
           
            return result;
        }

        public bool CheckSupported(SupportedAnimals supported)
        {
            var result = (supported == SupportedAnimals.Bird
                || supported == SupportedAnimals.Cat
                || supported == SupportedAnimals.Dog
                || supported == SupportedAnimals.Snake);
            return result;
        }

    }
}
