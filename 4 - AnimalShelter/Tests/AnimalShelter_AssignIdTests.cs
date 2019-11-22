using System;
using AnimalShelters.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelters.Tests
{
    [TestClass]
    public class AnimalShelter_AssignIdTests
    {
        [TestMethod]
        public void AssignId_AssignsId_WhenIdIsNotSet()
        {
            //Arrange
            var animal = new Animal(AnimalType.Dog);

            //Act
            animal.AssignId();

            //Assert
            Assert.AreNotEqual(Guid.Empty, animal.UniqueAnimalId);
        }
        
        [TestMethod]
        public void AssignId_AssignsNoId_WhenIdIsAlreadySet()
        {
            //Arrange
            var animal = new Animal(AnimalType.Dog);
            animal.AssignId();
            Guid OGGuid = animal.UniqueAnimalId;

            //Act
            animal.AssignId();

            //Assert
            Assert.AreEqual(OGGuid, animal.UniqueAnimalId);

        }

    }
}