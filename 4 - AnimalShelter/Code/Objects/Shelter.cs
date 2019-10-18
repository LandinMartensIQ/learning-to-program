using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter.Code.Objects
{
    class Shelter
    {

        List<Animal> shelteredAnimals = new List<Animal>();

        public ResponseObject AddAnimal(AnimalTypes type)
        {
            ResponseObject returnValue = new ResponseObject();

            switch (type)
            {
                case AnimalTypes.Bear:
                case AnimalTypes.Deer:
                    returnValue.error = "Animal was not a supported animal";
                    returnValue.success = false;
                    break;
                default:
                    returnValue.animal= new Animal(type);
                    returnValue.success = true;
                    returnValue.error = null;
                    shelteredAnimals.Add(returnValue.animal);
                    break;
            }

            if (!returnValue.success && string.IsNullOrEmpty(returnValue.error))
            {
                returnValue.error = "unknown error occured";
            }

            return returnValue;
        }

        public List<Animal> GetAnimals(Filters filter = Filters.All)
        {

            List<Animal> returnValue = new List<Animal>();


            if (filter == Filters.All)
            {
                returnValue = shelteredAnimals;
            }
            else
            {
                foreach (Animal animal in shelteredAnimals)
                {

                    switch (animal.type) {
                        case AnimalTypes.Dog:
                            if (filter.Equals(Filters.Dogs))
                            {
                                returnValue.Add(animal);
                            }
                            break;
                        case AnimalTypes.Cat:
                            if (filter.Equals(Filters.Cats)){
                                returnValue.Add(animal);
                            }
                            break;
                        case AnimalTypes.Snake:
                            break;
                        case AnimalTypes.Bird:
                            if (filter.Equals(Filters.Fly))
                            {
                                returnValue.Add(animal);
                            }
                            break;

                    }

                   
                }
            }

            return returnValue;
        }

        public ResponseObject RemoveAnimal(Animal animal)
        {
            
            ResponseObject returnValue = new ResponseObject();

            if (animal.type==AnimalTypes.Bear || animal.type == AnimalTypes.Deer)
            {
                returnValue.animal = null;
                returnValue.error = "Animal was not a supported type";
                returnValue.success = false;
                return returnValue;
            }

            var found=shelteredAnimals.Find(a => a.Id==animal.Id);

            if (found != null)
            {
                var count = shelteredAnimals.Count();
                shelteredAnimals.Remove(animal);
                if (count == shelteredAnimals.Count())
                {
                    returnValue.error = "unable to remove animal for unknown reason";
                    returnValue.success = false;
                    returnValue.animal = null;
                }
                else
                {
                    returnValue.animal = found;
                    returnValue.success = true;
                    returnValue.error = null;
                }
            }
            else
            {
                returnValue.error = "Animal was not in the system";
                returnValue.success = false;
                returnValue.animal = null;
            }

            return returnValue;
        }

        public ResponseObject GetAnimalFromId(Guid id)
        {
            ResponseObject returnValue =new ResponseObject();

            var found = shelteredAnimals.Where(a => a.Id == id);

            if (found.Count()==0)
            {
                returnValue.animal = null;
                returnValue.error = "Animal does not exist in the system";
                returnValue.success = false;
            }
            else
            {
                //Could potentially check for more than one result but since we are using guids, there should be no chance of finding duplicates
                returnValue.animal = found.First();
                returnValue.error = null;
                returnValue.success = true;
            }

            return returnValue;

        }
    }
}
