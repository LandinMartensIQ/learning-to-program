using AnimalShelters.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelters.Tests
{
    [TestClass]
    public class AnimalShelter_RemoveAnimalTests
    {

        [TestMethod]
        public void RemoveAnimal_RemovesAnimal_WhenAnimalFound()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            shelter.AddAnimal(animal);
            var expected = 0;

            //Act
            shelter.RemoveAnimal(animal);

            //Assert
            Assert.AreEqual(expected, shelter.Animals.Count);

        }

        [TestMethod]
        public void RemoveAnimal_DoesNothing_WhenAnimalNotFound()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Cat();
            var animal2 = new Dog();
            shelter.AddAnimal(animal1);
            var expected = 1;

            //Act
            shelter.RemoveAnimal(animal2);

            //Assert
            Assert.AreEqual(expected, shelter.Animals.Count);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnAnimal_WhenAnimalRemoved()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            shelter.AddAnimal(animal);

            //Act
            var actual = shelter.RemoveAnimal(animal);

            //Assert
            Assert.AreEqual(animal, actual.Animal);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnsNoAnimal_WhenAnimalNotRemoved()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Cat();
            var animal2 = new Dog();
            shelter.AddAnimal(animal1);

            //Act
            var actual = shelter.RemoveAnimal(animal2);

            //Assert
            Assert.IsNull(actual.Animal);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnOperationSuccessTrue_WhenAnimalRemoved()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            shelter.AddAnimal(animal);
            var expected = true;

            //Act
            var actual = shelter.RemoveAnimal(animal);

            //Assert
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnsOperationSuccessFalse_WhenAnimalNotRemoved()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Cat();
            var animal2 = new Dog();
            shelter.AddAnimal(animal1);
            var expected = false;

            //Act
            var actual = shelter.RemoveAnimal(animal2);

            //Assert
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnsError_WhenAnimalNotRemoved()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Cat();
            var animal2 = new Dog();
            shelter.AddAnimal(animal1);

            //Act
            var actual = shelter.RemoveAnimal(animal2);

            //Assert
            Assert.IsNotNull(actual.Error);

        }

        [TestMethod]
        public void RemoveAnimal_ReturnsNullError_WhenAnimalRemoved()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            shelter.AddAnimal(animal);

            //Act
            var actual = shelter.RemoveAnimal(animal);

            //Assert
            Assert.IsNull(actual.Error);

        }
    }
}