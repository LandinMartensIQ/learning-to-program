using AnimalShelters.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelters.Tests
{
    [TestClass]
    public class AnimalShelter_AddAnimalTests
    {
        [TestMethod]
        public void AddAnimal_AnimalAdded_WhenSupported()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Dog);
            var expected = 1;

            //Act
            shelter.AddAnimal(animal);

            //Assert
            Assert.AreEqual(expected, shelter.Animals.Count );
        }

        [TestMethod]
        public void AddAnimal_AnimalNotAdded_WhenNotSupported()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);
            var expected = 0;

            //Act
            shelter.AddAnimal(animal);

            //Assert
            Assert.AreEqual(expected, shelter.Animals.Count);
        }

        [TestMethod]
        public void AddAnimal_AnimalIdsAreUnique()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Animal(AnimalType.Cat);
            var animal2 = new Animal(AnimalType.Cat);

            //Act
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);

            //Assert
            Assert.AreNotEqual( animal2.UniqueAnimalId, animal1.UniqueAnimalId );
        }

        [TestMethod]
        public void AddAnimal_ReturnsAnimalInResult_WhenAnimalAdded()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Dog);

            //Act
            var actual = shelter.AddAnimal(animal);

            //Assert
            Assert.AreEqual(animal, actual.Animal);

        }

        [TestMethod]
        public void AddAnimal_ReturnsNoAnimalInResult_WhenAnimalNotAdded()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);

            //Act
            var actual = shelter.AddAnimal(animal);

            //Assert
            Assert.IsNull(actual.Animal);

        }

        [TestMethod]
        public void AddAnimal_ReturnsAnimalAddedTrue_WhenAnimalAdded()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Dog);
            var expected = true;

            //Act
            var actual = shelter.AddAnimal(animal);

            //Assert
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void AddAnimal_ReturnsAnimalAddedFalse_WhenAnimalNotAdded()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);
            var expected = false;

            //Act
            var actual = shelter.AddAnimal(animal);

            //Assert
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void AddAnimal_ReturnsNoError_WhenAnimalAdded()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Dog);

            //Act
            var actual = shelter.AddAnimal(animal);

            //Assert
            Assert.IsNull(actual.Error);

        }

        [TestMethod]
        public void AddAnimal_ReturnsError_WhenAnimalNotAdded()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Animal(AnimalType.Bear);

            //Act
            var actual = shelter.AddAnimal(animal);

            //Assert
            Assert.IsNotNull(actual.Error);

        }
    }
}