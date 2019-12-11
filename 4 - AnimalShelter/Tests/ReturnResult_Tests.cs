using AnimalShelter.Code.Enums;
using AnimalShelter.Code.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.test.Tests
{
    [TestClass]
    public class ReturnResult_Tests
    {
        [TestMethod]
        public void ReturnResult_ReturnDefaults()
        {
            var result = new ReturnResult();

            Assert.AreEqual(null, result.Animal);
            Assert.AreEqual(false, result.isAdded);
            Assert.AreEqual(null, result.ErrorMsg);
            Assert.AreEqual(null, result.animalShelter);
        }

        [TestMethod]
        public void ReturnResult_ReturnsTrue_WhenAnimalIsSupported()
        {
            var result = new AnimalShelterMain();
            //var animal = new Animal(SupportedAnimals.Cat); 

            var supported = result.CheckSupported(SupportedAnimals.Cat);

            Assert.IsTrue(supported);
        }

        [TestMethod]
        public void ReturnResult_ListIsNotNull_WhenAnimalIsAdded()
        {
            //var result = new ReturnResult();
            var result = new AnimalShelterMain();
            var animal = new Animal(SupportedAnimals.Dog);      
         

            result.AddAnimal(animal);
            //var listAdded = list.AddAnimal(animal);

            Assert.AreEqual(1,result.Animals.Count);
        }

        //[TestMethod]
        //public void ReturnResult_ReturnsFalse_WhenAnimalIsNotSupported()
        //{
        //    var result = new ReturnResult();
        //    var animal = new Animal(Deer);

        //    var supported = result.CheckIfSupported(animal);

        //    Assert.IsFalse(supported);
        //}

        //[TestMethod]
        //public void ReturnResult_ReturnsFalse_WhenAnimalIsKnownButNotSupported()
        //{
        //    var result = new ReturnResult();
        //    var animal = new Animal() { Type = nameof(KnownAnimals.Deer) };

        //    var supported = result.CheckIfKnown(animal);

        //    Assert.IsFalse(supported);
        //}

        //[TestMethod]
        //public void ReturnResult_ReturnsFalse_WhenAnimalIsNotKnownOrSupported()
        //{
        //    var result = new ReturnResult();
        //    var animal = new Animal() { Type = nameof(UnknownAnimals.Rat) };

        //    var supported = result.CheckIfKnown(animal);

        //    Assert.IsFalse(supported);
        //    Assert.IsNotNull(result.ErrorMsg);
        //}


        //[TestMethod]
        //public void ReturnResult_ErrorNotNull_WhenAnimalIsNotKnownOrSupported()
        //{
        //    var result = new ReturnResult();
        //    var animal = new Animal() { Type = nameof(UnknownAnimals.Rat) };

        //    var supported = result.CheckIfKnown(animal);

        //    Assert.IsNotNull(result.ErrorMsg);
        //}

        //[TestMethod]
        //public void ReturnResult_ReturnsList()
        //{
        //    var result = new ReturnResult();
            
        //    var filter = "Bird";

        //    List<string> supported = result.ReturnList(filter);

        //    Assert.IsNotNull(supported);
        //}
    }
}
