using System;
using AnimalShelters.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelters.Tests
{
    [TestClass]
    public class AnimalShelter_GetAnimalTests
    {
        [TestMethod]
        public void GetAnimals_ReturnsFullList_WhenNoParam()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Deer));
            shelter.AddAnimal(new Animal(AnimalType.Bear));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Snake));
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Deer));
            shelter.AddAnimal(new Animal(AnimalType.Bear));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Snake));

            //Act
            var actual = shelter.GetAnimals();

            //Assert
            Assert.AreEqual(shelter.Animals, actual);
        }


        [TestMethod]
        public void GetAnimals_ReturnsBasedOnFilterObject_FlyingSetTypeSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            var expected = 1;
            var filter = new FilterObject() { CanFly = false, Type = AnimalType.Cat };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsBasedOnFilterObject_FlyingSetTypeNotSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            var expected = 3;
            var filter = new FilterObject() { CanFly = true, };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }
        [TestMethod]
        public void GetAnimals_ReturnsBasedOnFilterObject_FlyingNotSetTypeSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            var expected = 2;
            var filter = new FilterObject() { Type = AnimalType.Dog, };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsBasedOnFilterObject_NotSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            var expected = 6;
            var blankfilter = new FilterObject();

            //Act
            var actual = shelter.GetAnimals(blankfilter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsNoResults_FlyingSetTypeSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            var expected = 0;
            var filter = new FilterObject() { CanFly = true, Type = AnimalType.Cat };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsAnimal_WhenAnimalExistsInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);

            //Act
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert
            Assert.AreEqual(animal, actual.Animal);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsNoAnimal_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var notFound = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e");

            //Act
            var actual = shelter.GetAnimalFromID(notFound);

            //Assert
            Assert.IsNull(actual.Animal);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsNoError_WhenAnimalExistsInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);

            //Act
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert
            Assert.IsNull(actual.Error);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsError_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var notFound = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e");

            //Act
            var actual = shelter.GetAnimalFromID(notFound);

            //Assert
            Assert.IsNotNull(actual.Error);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnOperationSuccessTrue_WhenAnimalExistInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);
            var expected = true;

            //Act
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnOperationSuccessFalse_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            Guid notFound = new Guid("0f8fad5b-d9cb-469f-a165-70867728950e");
            var expected = false;

            //Act
            var actual = shelter.GetAnimalFromID(notFound);

            //Assert
            Assert.AreEqual(expected, actual.OperationSuccess);

        }
    }
}