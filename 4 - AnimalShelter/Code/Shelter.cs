using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter.Code
{
    public class Shelter
    {
        public Dictionary<Guid?, Animal> StoredAnimals = new Dictionary<Guid?, Animal>();
        private Guid? id;

        public GetResult AddAnimal(Animal animal)
        {
            var result = new GetResult();
            if (result.Checksupport(animal))
            {
                id = Guid.NewGuid();
                StoredAnimals.Add (id, animal);
                result.Positiveresult(animal);
            }
            return result;     
        }
        public GetResult RemoveAnimal(Animal animal)
        {
            var result = new GetResult();
            if (result.Checksupport(animal))
            {
                if (ContainsAnimal(animal))
                {
                    var key = (from v in StoredAnimals
                               where v.Value.Equals(animal)
                               select v.Key).First();
                    StoredAnimals.Remove(key);
                    result.Positiveresult(animal);
                }
                else
                {
                    result.Errormessages(KnownErrors.NotinSystem);
                }
            }

            return result;
        }
        //filters by animal
        public Dictionary<Guid?, Animal> GetAnimals(Animal animal)
        {
            var filterlist = new Dictionary<Guid?, Animal>();

            if (ContainsAnimal(animal))
               filterlist = StoredAnimals.Where(i => i.Value.Type == animal.Type).ToDictionary(i => i.Key, i => i.Value);
            else
                filterlist = StoredAnimals;
            return filterlist;
        }
        //filters by an animal's feature
        public Dictionary<Guid?, Animal> GetAnimals(string feature)
        {
            var filterlist = new Dictionary<Guid?, Animal>();
            var featurelist = Enum.GetNames(typeof(AnimalFeatures)).ToList();

            feature = feature.Trim().ToLower();
            if (featurelist.Contains(feature))
                filterlist = StoredAnimals.Where(i => i.Value.Feature == feature).ToDictionary(i => i.Key, i => i.Value);
            else
                filterlist = StoredAnimals;
            return filterlist;
        }


        public GetResult GetAnimalFromId(Guid? animalid)
        {
            var result = new GetResult();

            if (StoredAnimals.ContainsKey(animalid))
            {
                result.Positiveresult(StoredAnimals[animalid]);
            } 
            else
            {
                result.Errormessages(KnownErrors.WrongID);
          
            }
            return result;
        }
        //checks if the animal is stored in the shelter
        public bool ContainsAnimal(Animal animal)
        {
            bool result = new bool();

            foreach(Animal a in StoredAnimals.Values)
            {
                if (animal.Type == a.Type)
                {
                    result = true;
                    break;
                }
                else
                    result = false;
            }
            return result;
        }

    }
}
