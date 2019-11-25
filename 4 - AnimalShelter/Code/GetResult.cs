using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter.Code
{
    public class GetResult
    {
        public Animal Animal = null;
        public bool Status = false;
        public string Error = null;


        //Checks if the animal is supported
        public bool Checksupport(Animal animal)
        {
            bool supportstatus = false;
            List<string> supportedlist = Enum.GetNames(typeof(SupportedAnimals)).ToList();
            
             if (supportedlist.Contains(animal.Type))
                supportstatus = true;
             else
                Errormessages(KnownErrors.Notsupported);

            return supportstatus;
        }
        
        public void Errormessages(KnownErrors errors)
        {
            switch (errors)
            {
                case KnownErrors.Notsupported:
                    Error = "The Shelter does not support this animal.";
                    break;
                case KnownErrors.NotinSystem:
                    Error = "Cannot find the animal in the system.";
                    break;
                case KnownErrors.WrongID:
                    Error = "Could not find any animals with that id.";
                    break;
                default:
                    break;
            }

        }

        public void Positiveresult (Animal animal)
        {
            Animal = animal;
            Status = true;
        }
    }

}
