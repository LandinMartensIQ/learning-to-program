using AnimalShelter.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class GetAnimalsById_Tests
    {
        [TestMethod]
        public void GetAnimal__ShouldReturnAnimal_WithAnimalId()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            animalShelter.AddAnimal(cat);
            var guid = cat.UniqueAnimalId;
            animalShelter.AddAnimal(new Animal(AnimalType.Bird));

            var result = animalShelter.GetAnimalFromId(guid);

            Assert.AreEqual(true, result.WasAdded);
            Assert.AreEqual(cat, result.Animal);
            Assert.AreEqual(null, result.ErrorMessage);
        }

        [TestMethod]
        public void GetAnimal__ShouldNotReturnAnimal_IncorrectAnimalId()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            animalShelter.AddAnimal(cat);
            var guid = Guid.NewGuid();
            animalShelter.AddAnimal(new Animal(AnimalType.Bird));

            var result = animalShelter.GetAnimalFromId(guid);

            Assert.AreEqual(false, result.WasAdded);
            Assert.AreEqual(null, result.Animal);
            Assert.AreEqual("This animal is not in the shelter", result.ErrorMessage);
        }

    }
}
