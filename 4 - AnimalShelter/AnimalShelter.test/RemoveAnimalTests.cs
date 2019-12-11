using AnimalShelter2;
using AnimalShelter2.Code;
using AnimalShelter2.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter.test
{
    [TestClass]
    public class RemoveAnimalTests
    {

        [TestMethod]
        public void ReturnTrueAndName_IfAnimalWasRemoved()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            var animal = new Animal(KnownAnimals.Bird);

            // -- Act
            shelter.AddAnimal(animal);
            var remove = shelter.RemoveAnimal(animal);
            var isRemoved = remove.IsFoundAddedOrRemoved;
            var whoRemoved = remove.Animal.AnimalType;
            var actual = whoRemoved.ToString();
            var expected = "Bird";

            // -- Assert
            Assert.IsTrue(isRemoved);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnFalseAndError_IfAnimalIsNotRemoved()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            var animal = new Animal(KnownAnimals.Bear);

            // -- Act
            var remove = shelter.RemoveAnimal(animal);
            var isRemoved = remove.IsFoundAddedOrRemoved;
            var actual = remove.ErrorMsg;
            var expected = "This animal is not supported so it cannot be removed";


            // -- Assert
            Assert.IsFalse(isRemoved);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnError_IfAnimalDoesNotExist()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            var animal = new Animal();

            // -- Act
            var remove = shelter.RemoveAnimal(animal);
            var isRemoved = remove.IsFoundAddedOrRemoved;
            var actual = remove.ErrorMsg;
            var expected = "There is no animal to remove";


            // -- Assert
            Assert.IsFalse(isRemoved);
            Assert.AreEqual(expected, actual);
        }

    }
}
