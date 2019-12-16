using AnimalShelter.Code;
using AnimalShelter.Code.Classes;
using AnimalShelter.Code.Enums;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class AnimalShelter_Tests
    {
        #region ANIMALS SHELTER       
        public AnimalsShelter Animals()
        {
            var shelter = new AnimalsShelter();

            var animal1 = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal1);
            var animal2 = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal2);
            var animal3 = new Animal(AnimalType.Dog);
            shelter.AddAnimal(animal3);
            var animal4 = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal4);
            var animal5 = new Animal(AnimalType.Bird);
            shelter.AddAnimal(animal5);
            var animal6 = new Animal(AnimalType.Bird);
            shelter.AddAnimal(animal6);
            var animal7 = new Animal(AnimalType.Snake);
            shelter.AddAnimal(animal7);
            var animal8 = new Animal(AnimalType.Dog);
            shelter.AddAnimal(animal8);
            var animal9 = new Animal(AnimalType.Dog);
            shelter.AddAnimal(animal9);
            var animal10 = new Animal(AnimalType.Dog);
            shelter.AddAnimal(animal10);

            return shelter;
        }
        #endregion

        [TestMethod]
        [Owner("KobiL")]
        public void IsAnimalSupported_ReturnsFALSE_WhenPassingInNotSupportedAnimal()
        {
            // Arrange
            var animal = new Animal(AnimalType.Deer);

            // Act
            var isSupported = Animals().IsAnimalSupported(animal);

            // Asser
            isSupported.Should().BeFalse(because: "Deer are not supported animals.");
        }

        [TestMethod]
        [Owner("KobiL")]
        public void IsAnimalSupported_ReturnsTRUE_WhenPassingInSupportedAnimal()
        {
            // Arrange
            var animal = new Animal(AnimalType.Dog);

            // Act
            var isSupported = Animals().IsAnimalSupported(animal);

            // Asser
            isSupported.Should().BeTrue(because: "Dogs are supported animals.");
        }

        [TestMethod]
        [Owner("KobiL")]
        public void AddAnimal_AddingNotSupportedAnimal_DoesNotGetAddedToShelter()
        {
            // Arrange
            var animal = new Animal(AnimalType.Bear);

            // Act
            var addAnimal = Animals().AddAnimal(animal);

            // Assert
            addAnimal.IsResultSuccessful.Should().BeFalse();
            addAnimal.Message.Should().Be("Animal is not a supported animal.");
        }

        [TestMethod]
        [Owner("KobiL")]
        public void AddAnimal_AddingSupportedAnimal_GetsAddedToShelter()
        {
            // Arrange
            var animal = new Animal(AnimalType.Cat);

            // Act
            var addAnimal = Animals().AddAnimal(animal);

            // Assert
            addAnimal.IsResultSuccessful.Should().Be(true);
            addAnimal.Message.Should().Be(string.Empty);
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimals_AllCatsReturned_WhenAskingForCats_ExpectedCats_3()
        {
            // Act
            var getAnimals = Animals().GetAnimalsByCriteria(AnimalCriteria.AnimalsThatAreCats);

            // Assert
            getAnimals.Count.Should().Be(3);
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimals_AllDogsReturned_WhenAskingForDogs_ExpectedDog_4()
        {
            // Act
            var getAnimals = Animals().GetAnimalsByCriteria(AnimalCriteria.AnimalsThatAreDogs);

            // Assert
            getAnimals.Count.Should().Be(4);
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimals_AllAnimalsThatCanFly_ExpectedAnimals_2()
        {
            // Act
            var getAnimals = Animals().GetAnimalsByCriteria(AnimalCriteria.AnimalsThatCanFly);

            // Assert
            getAnimals.Count.Should().Be(2);
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimals_GettingAllAnimals_ExpectedAnimals_10()
        {
            // Act
            var getAnimals = Animals().GetAnimalsByCriteria(AnimalCriteria.AllAnimals);

            // Assert
            getAnimals.Count.Should().Be(10);
        }

        [TestMethod]
        [Owner("KobiL")]
        public void RevomeAnimal_RemovingAnAnimalThatDoesntExist_ExpectedResultFALSE()
        {
            // Arrange
            var notsupportedAnimal = new Animal(AnimalType.Bear);

            // Act
            var removeAnimal = Animals().RemoveAnimal(notsupportedAnimal);

            // Assert
            removeAnimal.IsResultSuccessful.Should().BeFalse();
            removeAnimal.Message.Should().Be("Animal does not exist in the system.");
        }

        [TestMethod]
        [Owner("KobiL")]
        public void RemoveAnimal_RemovingExistingAnimalFromShelter_ExpectedResult_TRUE()
        {
            // Arrange
            var shelter = Animals();
            var existingAnimal = shelter.GetAnimalsByCriteria(AnimalCriteria.AnimalsThatCanFly).First();

            // Act
            var removeAnimal = shelter.RemoveAnimal(existingAnimal);

            // Assert
            removeAnimal.IsResultSuccessful.Should().BeTrue();
            removeAnimal.Message.Should().Be(string.Empty);
        }

        [TestMethod]
        [Owner("KobiL")]
        public void RemoveAnimal_RemovingAnimalFromShelter_NullCheck()
        {
            // Arrange
            var shelter = Animals();

            // Act
            var removeAnimal = shelter.RemoveAnimal(null);

            // Assert
            removeAnimal.IsResultSuccessful.Should().BeFalse();
            removeAnimal.Message.Should().Be("Animal does not exist in the system.");
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimalById_GettingByEmptyGuid_ExpectedResult_FALSE()
        {
            // Arrange
            var shelter = Animals();

            // Act
            var result = shelter.GetAnimalById(Guid.Empty);

            // Assert
            result.IsResultSuccessful.Should().BeFalse();
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimalById_GettingByIdThatDoesntExist_ExpectedResult_FALSE()
        {
            // Arrange
            var shelter = Animals();

            // Act
            var result = shelter.GetAnimalById(Guid.NewGuid());

            // Assert
            result.IsResultSuccessful.Should().BeFalse();
            result.Message.Should().Be("Animal does not exist in the system.");
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimalById_GettingByExistingValidId_ExpectedResult_TRUE()
        {
            // Arrange
            var shelter = Animals();
            var animal = shelter.GetAnimalsByCriteria(AnimalCriteria.AllAnimals).FirstOrDefault();

            // Act
            var result = shelter.GetAnimalById(animal?.UniqueAnimalId ?? Guid.Empty);

            // Assert
            result.Animal.UniqueAnimalId.Should().Be(animal.UniqueAnimalId);
            result.IsResultSuccessful.Should().BeTrue();
            result.Message.Should().Be(string.Empty);
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimalById_GettingAnAnimalFromAnEmptyShelter_ExpectedResult_FALSE()
        {
            // Arrange
            var newShelter = new AnimalsShelter();

            // Act
            var result = newShelter.GetAnimalById(Guid.NewGuid());

            // Assert
            result.IsResultSuccessful.Should().BeFalse();
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimalsByCriteria_GetAllAnimals_FromEmptyShelter_Expected_Zero()
        {
            // Arrange
            var newShelter = new AnimalsShelter();
            var animals = newShelter.GetAnimalsByCriteria(AnimalCriteria.AllAnimals);

            // Assert
            animals.Count.Should().Be(0);
        }

        [TestMethod]
        [Owner("KobiL")]
        public void GetAnimalsByCriteria_GetAllCats_FromEmptyShelter_Expected_Zero()
        {
            // Arrange
            var newShelter = new AnimalsShelter();
            var animals = newShelter.GetAnimalsByCriteria(AnimalCriteria.AnimalsThatAreCats);

            // Assert
            animals.Count.Should().Be(0);
        }
    }
}
