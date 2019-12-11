using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter.Code.Objects
{

    public class ReturnResult
    {
        //assigning default values
        public Animal Animal = null;
        public bool isAdded = false;
        public string ErrorMsg = null;
        public AnimalShelterMain animalShelter = null;

        //public List<Animal> ReturnList(string filter)
        //{
        //    Dictionary<int, string> dict = animalShelter.animalDict;
        //    // List<string> animals = animalShelter.animalDict.Values;

        //    foreach (var animal in )
        //     {
        //        if (filter == "fly")
        //        {
        //            if (animal == "Bird")
        //            {
        //                result.Add("Bird");
        //            }
        //            else if (filter == "Cats")
        //            {
        //                if (animal == "Cat")
        //                {
        //                    result.Add("Cat");
        //                }
        //            }
        //            else if (filter == "Dog")
        //            {
        //                result.Add("Dog");
        //            }
        //        }
        //    }
        //    return result;
        //}


        //Checks if the animal is supported
        //public bool CheckIfSupported(Animal animal)
        //{
        //    bool supported = false;
        //    //Guid UniqueAnimalId = Guid.NewGuid();
        //    List<string> supportedList = Enum.GetNames(typeof(SupportedAnimals)).ToList();

        //    if (supportedList.Contains(SupportedAnimals))
        //    {
        //        supported = true;
        //    }
        //    else
        //    {
        //        PrintError(ErrorMessages.NotSupported);
        //        supported = false;
        //    }

        //    return supported;
        //}

        //Checks if the animal is known but not supported
        //public bool CheckIfKnown(Animal animal)
        //{
        //    bool known = false;
        //    List<string> supportedList = Enum.GetNames(typeof(SupportedAnimals)).ToList();
        //    List<string> knownList = Enum.GetNames(typeof(KnownAnimals)).ToList();

        //    if ()
        //    {
        //        known = true;
        //    }
        //    else if (knownList.Contains(animal.Type))
        //    {
        //        PrintError(ErrorMessages.KnownButNotSupported);
        //        known = false;
        //    }
        //    else
        //    {
        //        PrintError(ErrorMessages.NotKnownandNotSupported);
        //        known = false;
        //    }

        //    return known;
        //}

        //Assigns error messages
        private void PrintError(ErrorMessages error)
        {
            if (error == ErrorMessages.NotSupported)
            {
                ErrorMsg = "This Shelter does not support this animal.";
            }
            else if (error == ErrorMessages.KnownButNotSupported)
            {
                ErrorMsg = "This Shelter knows about this animal but does not support it.";
            }
            else if (error == ErrorMessages.NotKnownandNotSupported)
            {
                ErrorMsg = "This Shelter does not know about or support this animal.";
            }

        }
    }
}
