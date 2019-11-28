using AnimalShelter.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelter.Tests
{
	[TestClass]
	public class RemoveAnimal_Tests
    {
       
        [TestMethod]
        public void RemoveAnimal_AnimalIsRemovedFromList_WhenSupportedAndInList()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            animalShelter.AddAnimal(cat);
            
            var result = animalShelter.RemoveAnimal(cat);
            
            Assert.AreEqual(true, result.WasAdded);
            Assert.AreEqual(cat, result.Animal);
            Assert.AreEqual(null, result.ErrorMessage);
            
            
            Assert.AreEqual(false, animalShelter.animals.Contains(cat));
            
        }

        [TestMethod]
        public void RemoveAnimal_AnimalIsRemovedFromList_EnsureOnlyProperAnimalIsRemoved()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            animalShelter.AddAnimal(cat);
            var dog = new Animal(AnimalType.Dog);
            animalShelter.AddAnimal(dog);
            
            var result = animalShelter.RemoveAnimal(dog);
            
            Assert.AreEqual(true, result.WasAdded);
            Assert.AreEqual(dog, result.Animal);
            Assert.AreEqual(null, result.ErrorMessage);


            Assert.AreEqual(true, animalShelter.animals.Contains(cat));
            
        }

        [TestMethod]
        public void RemoveAnimal_AnimalIsNotRemovedFromList_WhenSupportedAndNotInList()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            var dog = new Animal(AnimalType.Dog);
            animalShelter.AddAnimal(cat);
            
            var result = animalShelter.RemoveAnimal(dog);
            
            Assert.AreEqual(false, result.WasAdded);
            Assert.AreEqual(null, result.Animal);
            Assert.AreEqual("This animal is not in the shelter", result.ErrorMessage);
            
            
            Assert.AreEqual(true, animalShelter.animals.Contains(cat));
            Assert.AreEqual(false, animalShelter.animals.Contains(dog));
            
        }
        [TestMethod]
        public void RemoveAnimal_AnimalIsNotRemovedFromList_WhenNotSupported()
        {
            var animalShelter = new Code.AnimalShelter();
            var deer = new Animal(AnimalType.Deer);
            
            var result = animalShelter.RemoveAnimal(deer);
            
            Assert.AreEqual(false, result.WasAdded);
            Assert.AreEqual(null, result.Animal);
            Assert.AreEqual("Animal was not a supported animal", result.ErrorMessage);


            Assert.AreEqual(false, animalShelter.animals.Contains(deer));
            
        }

    }
}

