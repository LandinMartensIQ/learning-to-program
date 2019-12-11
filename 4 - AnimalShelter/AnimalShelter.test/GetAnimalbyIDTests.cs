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
    public class GetAnimalbyIDTests
    {
        [TestMethod]
        public void ReturnError_AnimalIdNotSupported()
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

            var stringId = animal2.UniqueAnimalId.ToString();

            var getList = shelter.GetAnimalById(stringId);

            var isError = getList.ErrorMsg;
            var isFound = getList.IsFoundAddedOrRemoved;
            var expected = "This animal is not found because it is not supported";

            // -- Assert
            Assert.IsFalse(isFound);
            Assert.AreEqual(isError, expected);

        }

        [TestMethod]
        public void ReturnTrue_IfAnimalIdIsFound()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            //string error = null;
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

            var stringId = animal5.UniqueAnimalId.ToString();

            var getList = shelter.GetAnimalById(stringId);

            var isFound = getList.IsFoundAddedOrRemoved;
            var name = getList.Animal.AnimalType;
            var actual = name.ToString();
            var error = getList.ErrorMsg;
            var expected = "Snakes";

            // -- Assert
            Assert.IsTrue(isFound);
            Assert.AreEqual(expected, actual);
            Assert.IsNull(error);
        }

        [TestMethod]
        public void ReturnError_IfIDIsNotCorrectFormat()
        {
            //  -- Arrange
            Shelter shelter = new Shelter();
            //string error = null;
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

            var getList = shelter.GetAnimalById("aaaef973 - d8ce - 4c92 - 3635bb2d42d5");

            var isFound = getList.IsFoundAddedOrRemoved;
            var error = getList.ErrorMsg;
            var expected = "ID is not in the correct format";

            // -- Assert
            Assert.IsFalse(isFound);
            Assert.AreEqual(expected, error);

        }
    }
}
