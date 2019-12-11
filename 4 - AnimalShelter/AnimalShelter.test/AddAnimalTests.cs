using System;
using AnimalShelter2;
using AnimalShelter2.Code;
using AnimalShelter2.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelter.test
{
    [TestClass]
    public class AddAnimalTests
    {

        //[TestMethod]
        //public void ReturnResult_ReturnDefaults()
        //{
        //    var result = new ReturnResults();

        //    Assert.AreEqual(null, result.Animal);
        //    Assert.AreEqual(false, result.isAdded);
        //    Assert.AreEqual(null, result.ErrorMsg);
        //    //Assert.AreEqual(null, result.animalShelter);
        //}

        [TestMethod]
        public void ReturnNegatives_IfAnimalWasNotAdded()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            Animal animal = new Animal(KnownAnimals.Deer);
            var expected = 0;

            // -- Act
            var added = shelter.AddAnimal(animal);
            var actual = shelter.Animals.Count;
            var wasAdded = added.IsFoundAddedOrRemoved;
            var error = "This animal is not supported";

            // -- Assert
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(wasAdded);
            Assert.AreEqual(error,added.ErrorMsg);
            Assert.AreEqual(Guid.Empty, animal.UniqueAnimalId);
        }

        [TestMethod]
        public void ReturnPositives_IfAnimalWasAdded()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            Animal animal = new Animal(KnownAnimals.Cat);
            string error = null;
            Answer answer = new Answer(true, animal, error);
            var expected = 1;

            // -- Act
            var wasAdded = shelter.AddAnimal(animal); 
            var actual = shelter.Animals.Count;

            // -- Assert
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(wasAdded.IsFoundAddedOrRemoved);
            Assert.IsNull(answer.ErrorMsg);
            Assert.AreNotEqual(Guid.Empty,animal.UniqueAnimalId);

        }

        //[TestMethod]
        //public void ReturnError_IfThereIsNoAnimal()
        //{
        //    //  -- Arrange
        //    Shelter shelter = new Shelter();
        //    Animal animal = new Animal();
        //    var expected = 0;

        //    // -- Act
        //    var added = shelter.AddAnimal(animal);
        //    var actual = shelter.Animals.Count;
        //    var wasAdded = added.IsFoundAddedOrRemoved;
        //    var error = "There is no animal to add";

        //    // -- Assert
        //    Assert.AreEqual(expected, actual);
        //    Assert.IsFalse(wasAdded);
        //    Assert.AreEqual(error, added.ErrorMsg);
        //    Assert.AreEqual(Guid.Empty, animal.UniqueAnimalId);
        //}
    }
}
