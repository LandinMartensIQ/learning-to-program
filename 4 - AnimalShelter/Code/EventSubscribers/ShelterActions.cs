using AnimalShelter.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter.Code.EventSubscribers
{
    public class ShelterActions
    {
        private List<IAnimal> AnimalsToBath { get; set; }

        public ShelterActions(AnimalsShelter shelter)
        {
            AnimalsToBath = new List<IAnimal>();

            // subscribe to AnimalBeenAddedToShelterEvent event
            shelter.AnimalBeenAddedToShelterEvent += HandleAnimalAddedToShelterEvent;

            // subscribe to AnimalRemovedFromShelterEvent event
            shelter.AnimalRemovedFromShelterEvent += HandleAnimalRemovedFromShelterEvent;
        }

        private void HandleAnimalAddedToShelterEvent(IAnimal animal) => AddAnimalToBathList(animal);
        private void HandleAnimalRemovedFromShelterEvent(IAnimal animal) => RemoveAnimalFromBathList(animal);
        public void AddAnimalToBathList(IAnimal animal) => AnimalsToBath.Add(animal);
        public void RemoveAnimalFromBathList(IAnimal animal) => AnimalsToBath.Remove(animal);
        public IAnimal GetAnimalFromBathList() => AnimalsToBath.FirstOrDefault();
    }
}
