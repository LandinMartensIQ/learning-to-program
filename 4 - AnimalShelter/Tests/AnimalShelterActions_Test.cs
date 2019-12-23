using AnimalShelter.Code;
using AnimalShelter.Code.Classes;
using AnimalShelter.Code.Enums;
using AnimalShelter.Code.EventSubscribers;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class AnimalShelterActions_Test
    {
        [TestMethod]
        public void AddAnimal_Triggers_AnimalAddedToShelterEvent()
        {
            // Arrange
            var animal = new Animal(AnimalType.Cat);
            var shelter = new AnimalsShelter();
            var actionShelter = new ShelterActions(shelter);

            // Act
            shelter.AddAnimal(animal);
            var animalInBathList = actionShelter.GetAnimalFromBathList();

            // Assert
            // By animal Id
            animalInBathList.UniqueAnimalId.Should().Be(animal.UniqueAnimalId);
            // By comparing animal objects
            Assert.AreEqual(animal, animalInBathList);
        }

        [TestMethod]
        public void RemoveAnimal_Triggers_AnimalRemovedFromShelterEvent()
        {
            // Arrange
            var animal = new Animal(AnimalType.Cat);
            var shelter = new AnimalsShelter();
            var actionShelter = new ShelterActions(shelter);

            shelter.AddAnimal(animal);
            var animalInBathList = actionShelter.GetAnimalFromBathList();
            animalInBathList.UniqueAnimalId.Should().Be(animal.UniqueAnimalId);

            // Act
            shelter.RemoveAnimal(animal);
            animalInBathList = actionShelter.GetAnimalFromBathList();

            // Assert
            animalInBathList.Should().BeNull();
        }

    }
}
