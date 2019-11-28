using AnimalShelter.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class AddAnimal_Tests
    {
        [TestMethod]
        public void AddAnimal_ShouldAddAnimal_WhenSupported()
        {
            //Arrange [Variables, object creation and other set up]
            var animalShelter = new Code.AnimalShelter();
            var dog = new Animal(AnimalType.Dog);
            //Act [Method / Function invoke with passed in data]
            var result = animalShelter.AddAnimal(dog);
            //var compare = animalShelter.animals.Distinct();
            //Assert [Validate that something should have happened]
            Assert.AreEqual(true, result.WasAdded);
            Assert.AreEqual(dog, result.Animal);
            Assert.AreNotEqual(null, result.Animal.UniqueAnimalId);
            Assert.AreEqual(null, result.ErrorMessage);
            //Assert.AreEqual(animalShelter.animals, compare);
            //Assert.AreEqual(true, animalShelter.animals.Contains(dog));
        }

        [TestMethod]
        public void AddAnimal_ShouldNotAddAnimal_WhenNotSupported()
        {
            //Arrange [Variables, object creation and other set up]
            var animalShelter = new Code.AnimalShelter();
            var deer = new Animal(AnimalType.Deer);

            //Act [Method / Function invoke with passed in data]
            var result = animalShelter.AddAnimal(deer);
            //Assert [Validate that something should have happened]
            Assert.AreEqual(false, result.WasAdded);
            Assert.AreEqual(null, result.Animal);
            Assert.AreEqual("Animal was not a supported animal", result.ErrorMessage);
            
            
            Assert.AreEqual(false, animalShelter.animals.Contains(deer));
            //Assert.AreEqual(<expected>, <actual>);
        }
    }
}
