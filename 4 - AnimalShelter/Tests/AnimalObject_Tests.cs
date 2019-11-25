
using AnimalShelter.Code;
using AnimalShelter.Code.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class AnimalObject_Tests
    {
        [TestMethod]
        public void DefaultState()
        {
            var animal = new Animal();

            Assert.AreEqual("", animal.Type);
            Assert.AreEqual("", animal.Feature);
        }

        [TestMethod]
        public void Stringisloweredandtrimmed()
        {
            var animal = new Animal();

            animal.Type = "CAT    ";

            Assert.AreEqual("cat", animal.Type);
            Assert.AreEqual("", animal.Feature);
        }

        [TestMethod]
        public void Setfeature()
        {
            var animal = new Animal();

            animal.Type = "bird";

            Assert.AreEqual(nameof(KnownAnimals.bird), animal.Type);
            Assert.AreEqual(nameof(AnimalFeatures.flight), animal.Feature);
        }
    }
}
    