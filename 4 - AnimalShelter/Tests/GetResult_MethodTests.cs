
using AnimalShelter.Code;
using AnimalShelter.Code.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class GetResult_MethodTests
    {
        [TestMethod]
        public void CheckSupport_Returntrue_WhenAnimalsupported()
        {
            var result = new GetResult();
            var animal = new Animal() { Type = nameof(KnownAnimals.cat) };
            
            var support = result.Checksupport(animal);

            Assert.IsTrue(support);
        }
        
        [TestMethod]
        public void CheckSupport_ReturnfalseAndError_WhenAnimalnotsupported()
        {
            var result = new GetResult();
            var animal = new Animal() { Type = nameof(KnownAnimals.deer) };
            
            var support = result.Checksupport(animal);

            Assert.IsFalse(support);
            Assert.AreEqual("The Shelter does not support this animal.", result.Error);
        }
        
        [TestMethod]
        public void PositiveResult_SetTrueandAnimal()
        {
            var result = new GetResult();
            var animal = new Animal() { Type = nameof(KnownAnimals.cat) };
            
            result.Positiveresult(animal);

            Assert.IsTrue(result.Status);
            Assert.AreEqual(animal, result.Animal);
            Assert.IsNull(result.Error);
        }
    }
}


