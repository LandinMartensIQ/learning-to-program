using System.Collections.Generic;
using AnimalShelterCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelterTests
{
    [TestClass]
    public class AnimalShelter_AddAnimalTests
    {
        [TestMethod]
        public void AddAnimal_AnimalAdded_WhenSupported()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Dog);
            var expected = 1;

            //Act [Method / Function invoke with passed in data]
            shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, shelter.Animals.Count );
        }

        [TestMethod]
        public void AddAnimal_AnimalNotAdded_WhenNotSupported()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);
            var expected = 0;

            //Act [Method / Function invoke with passed in data]
            shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, shelter.Animals.Count);
        }

        [TestMethod]
        public void AddAnimal_AnimalIdsAreUnique()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal1 = new Animal(AnimalType.Dog);
            var animal2 = new Animal(AnimalType.Cat);

            //Act [Method / Function invoke with passed in data]
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);

            //Assert [Validate that something should have happened]
            Assert.AreNotEqual( animal2.UniqueAnimalId, animal1.UniqueAnimalId );
        }

        [TestMethod]
        public void AddAnimal_AnimalIDIncrements_WhenAnimalAdded()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal1 = new Animal(AnimalType.Dog);
            var animal2 = new Animal(AnimalType.Cat);
            var expected1 = 1;
            var expected2 = 2;

            //Act [Method / Function invoke with passed in data]
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(animal1.UniqueAnimalId, expected1);
            Assert.AreEqual(animal2.UniqueAnimalId, expected2);
        }

        [TestMethod]
        public void AddAnimal_AnimalIdDoesNotIncrement_WhenAnimalNotAdded()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);
            var expected1 = 1;
            var expected2 = 0;

            //Act [Method / Function invoke with passed in data]
            shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(shelter.AnimalCounter, expected1);
            Assert.AreEqual(animal.UniqueAnimalId, expected2);
        }

        [TestMethod]
        public void AddAnimal_ReturnsAnimalInResult_WhenAnimalAdded()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Dog);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(animal, actual.Animal);

        }

        [TestMethod]
        public void AddAnimal_ReturnsNoAnimalInResult_WhenAnimalNotAdded()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.IsNull(actual.Animal);

        }

        [TestMethod]
        public void AddAnimal_ReturnsAnimalAddedTrue_WhenAnimalAdded()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Dog);
            var expected = true;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void AddAnimal_ReturnsAnimalAddedFalse_WhenAnimalNotAdded()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);
            var expected = false;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void AddAnimal_ReturnsNoError_WhenAnimalAdded()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Dog);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.IsNull(actual.Error);

        }

        [TestMethod]
        public void AddAnimal_ReturnsError_WhenAnimalNotAdded()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.AddAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.IsNotNull(actual.Error);

        }
    }
}