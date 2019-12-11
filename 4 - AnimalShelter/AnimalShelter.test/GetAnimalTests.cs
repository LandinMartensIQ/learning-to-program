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
    public class GetAnimalTests
    {
        [TestMethod]
        public void ReturnBird_IfFilterIsFly()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            var animal1 = new Animal(KnownAnimals.Dog);
            var animal2 = new Animal(KnownAnimals.Snakes);
            var animal3 = new Animal(KnownAnimals.Bird);
            var animal4 = new Animal(KnownAnimals.Cat);

            //var actual = animal3.AnimalType;
            //var expected = KnownAnimals.Bird;

            // -- Act
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);
            shelter.AddAnimal(animal3);
            shelter.AddAnimal(animal4);

            var getList = shelter.GetAnimal("Fly");
            var actual = getList.Contains(animal3);

            // -- Assert
            Assert.AreEqual(1, getList.Count);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ReturnCats_IfFilterIsCats()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            var animal1 = new Animal(KnownAnimals.Dog);
            var animal2 = new Animal(KnownAnimals.Snakes);
            var animal3 = new Animal(KnownAnimals.Bird);
            var animal4 = new Animal(KnownAnimals.Cat);
           // var expected = KnownAnimals.Cat;

            // -- Act
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);
            shelter.AddAnimal(animal3);
            shelter.AddAnimal(animal4);

            var getList = shelter.GetAnimal("Cats");
            var actual = getList.Count;

            // -- Assert
            Assert.AreEqual(1, actual);
            //Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnTwoCats_IfFilterIsCats()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            var animal1 = new Animal(KnownAnimals.Cat);
            var animal2 = new Animal(KnownAnimals.Snakes);
            var animal3 = new Animal(KnownAnimals.Bird);
            var animal4 = new Animal(KnownAnimals.Cat);


            // -- Act
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);
            shelter.AddAnimal(animal3);
            shelter.AddAnimal(animal4);

            var getList = shelter.GetAnimal("Cats");

            // -- Assert
            Assert.AreEqual(2, getList.Count);
            //Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CompareListCount_IfFilterIsAll()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            var animal1 = new Animal(KnownAnimals.Cat);
            var animal2 = new Animal(KnownAnimals.Deer);
            var animal3 = new Animal(KnownAnimals.Bird);
            var animal4 = new Animal(KnownAnimals.Dog);
            var animal5 = new Animal(KnownAnimals.Snakes);


            // -- Act
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);
            shelter.AddAnimal(animal3);
            shelter.AddAnimal(animal4);
            shelter.AddAnimal(animal5);

            var getList = shelter.GetAnimal("All");

            // -- Assert
            Assert.AreEqual(4, getList.Count);
            //Assert.AreEqual(expected, actual);
        }

    }
}
