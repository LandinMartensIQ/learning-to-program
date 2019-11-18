using System.Collections.Generic;
using AnimalShelterCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelterTests
{
    [TestClass]
    public class AnimalShelter_GetRemoveTests
    {
        [TestMethod]
        public void GetAnimals_ReturnsFullList_WhenNoParam()
        {
            //Arrange [Variables, object creation and other set up]
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

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.GetAnimals();

            //Assert [Validate that something should have happened]
            Assert.AreEqual(shelter.Animals, actual);
        }

        [TestMethod]
        public void GetAnimals_ReturnsCats_WhenParamCat()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            shelter.AddAnimal(new Animal(AnimalType.Dog));
            shelter.AddAnimal(new Animal(AnimalType.Deer));
            shelter.AddAnimal(new Animal(AnimalType.Bear));
            shelter.AddAnimal(new Animal(AnimalType.Bird));
            shelter.AddAnimal(new Animal(AnimalType.Snake));
            shelter.AddAnimal(new Animal(AnimalType.Cat));
            var expected = 2;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.GetAnimals(AnimalType.Cat);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, actual.Count);

        }
        
        [TestMethod]
        public void RemoveAnimal_RemovesAnimal_WhenAnimalFound()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);
            var expected = 0;

            //Act [Method / Function invoke with passed in data]
            shelter.RemoveAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, shelter.Animals.Count);

        }

        [TestMethod]
        public void RemoveAnimal_DoesNothing_WhenAnimalNotFound()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal1 = new Animal(AnimalType.Cat);
            var animal2 = new Animal(AnimalType.Dog);
            shelter.AddAnimal(animal1);
            var expected = 1;

            //Act [Method / Function invoke with passed in data]
            shelter.RemoveAnimal(animal2);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, shelter.Animals.Count);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnAnimal_WhenAnimalRemoved()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.RemoveAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(animal, actual.Animal);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnsNoAnimal_WhenAnimalNotRemoved()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal1 = new Animal(AnimalType.Cat);
            var animal2 = new Animal(AnimalType.Dog);
            shelter.AddAnimal(animal1);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.RemoveAnimal(animal2);

            //Assert [Validate that something should have happened]
            Assert.IsNull(actual.Animal);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnOperationSuccessTrue_WhenAnimalRemoved()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);
            var expected = true;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.RemoveAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnsOperationSuccessFalse_WhenAnimalNotRemoved()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal1 = new Animal(AnimalType.Cat);
            var animal2 = new Animal(AnimalType.Dog);
            shelter.AddAnimal(animal1);
            var expected = false;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.RemoveAnimal(animal2);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnsError_WhenAnimalNotRemoved()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal1 = new Animal(AnimalType.Cat);
            var animal2 = new Animal(AnimalType.Dog);
            shelter.AddAnimal(animal1);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.RemoveAnimal(animal2);

            //Assert [Validate that something should have happened]
            Assert.IsNotNull(actual.Error);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnsNullError_WhenAnimalRemoved()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.RemoveAnimal(animal);

            //Assert [Validate that something should have happened]
            Assert.IsNull(actual.Error);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsAnimal_WhenAnimalExistsInShelter()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(animal, actual.Animal);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsNoAnimal_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            animal.UniqueAnimalId = 21;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert [Validate that something should have happened]
            Assert.IsNull(actual.Animal);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsNoError_WhenAnimalExistInShelter()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert [Validate that something should have happened]
            Assert.IsNull(actual.Error);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsError_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            animal.UniqueAnimalId = 21;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert [Validate that something should have happened]
            Assert.IsNotNull(actual.Error);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnOperationSuccessTrue_WhenAnimalExistInShelter()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            shelter.AddAnimal(animal);
            var expected = true;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnOperationSuccessFalse_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange [Variables, object creation and other set up]
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Cat);
            animal.UniqueAnimalId = 21;
            var expected = false;

            //Act [Method / Function invoke with passed in data]
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert [Validate that something should have happened]
            Assert.AreEqual(expected, actual.OperationSuccess);

        }
    }
}