using AnimalShelter.Code.Classes;
using AnimalShelter.Code.Enums;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class Animal_Tests
    {
        [TestMethod]
        [Owner("KobiL")]
        public void AnimalCanFly_GetsSetToTRUE_WhenCreatingABird()
        {
            // Arrange
            var animalBird = new Animal(AnimalType.Bird);

            // Assert
            animalBird.AnimalCanFly.Should().BeTrue();
        }

        [TestMethod]
        [Owner("KobiL")]

        public void AnimalCanFly_GetsSetToFalse_WhenCreatingAnAnimalThatIsNotABird()
        {
            // Arrange
            var animalBird = new Animal(AnimalType.Deer);

            // Assert
            animalBird.AnimalCanFly.Should().BeFalse();
        }
    }
}
