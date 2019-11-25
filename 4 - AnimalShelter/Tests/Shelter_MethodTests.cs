
using AnimalShelter.Code;
using AnimalShelter.Code.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelter.Tests
{
    [TestClass]
    public class Shelter_MethodTests
    {
        [TestMethod]
        public void AddAnimal_AnimalisStored()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.dog) };
            var shelter = new Shelter();

            GetResult result = shelter.AddAnimal(animal);

            Assert.IsTrue(result.Status);
            Assert.IsNull(result.Error);
            Assert.AreEqual(animal, result.Animal);
            Assert.IsTrue(shelter.ContainsAnimal(animal));
        }

        [TestMethod]
        public void AddAnimal_Animalisnotsupported()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.bear) };
            var shelter = new Shelter();

            GetResult result = shelter.AddAnimal(animal);

            Assert.IsFalse(result.Status);
            Assert.AreEqual("The Shelter does not support this animal.", result.Error);
            Assert.IsNull(result.Animal);
            Assert.IsFalse(shelter.ContainsAnimal(animal));
        }

        [TestMethod]
        public void AddAnimal_Incorrectinput()
        {
            var animal = new Animal() { Type = "Spider!" };
            var shelter = new Shelter();

            GetResult result = shelter.AddAnimal(animal);

            Assert.IsFalse(result.Status);
            Assert.AreEqual("The Shelter does not support this animal.", result.Error);
            Assert.IsNull(result.Animal);
            Assert.IsFalse(shelter.ContainsAnimal(animal));
        }
                
        [TestMethod]
        [ExpectedException (typeof(NullReferenceException))]
        public void AddAnimal_nullinput()
        {
            var shelter = new Shelter();

            GetResult result = shelter.AddAnimal(null);

        }

        [TestMethod]
        public void RemoveAnimal_AnimalisRemoved()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.dog) };
            var shelter = new Shelter();

            shelter.StoredAnimals.Add(Guid.NewGuid(), animal);

            GetResult result = shelter.RemoveAnimal(animal);

            Assert.IsTrue(result.Status);
            Assert.IsNull(result.Error);
            Assert.AreEqual(animal, result.Animal);
            Assert.IsFalse(shelter.ContainsAnimal(animal));
        }
        [TestMethod]
        public void RemoveAnimal_OnlyOneAnimalisRemoved()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.dog) };
            var shelter = new Shelter();

            shelter.StoredAnimals.Add(Guid.NewGuid(), animal);
            shelter.StoredAnimals.Add(Guid.NewGuid(), animal);

            GetResult result = shelter.RemoveAnimal(animal);

            Assert.IsTrue(result.Status);
            Assert.IsNull(result.Error);
            Assert.AreEqual(animal, result.Animal);
            Assert.IsTrue(shelter.ContainsAnimal(animal));
        }
        [TestMethod]
        public void RemoveAnimal_Animalisnotfound()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.dog) };
            var animal2 = new Animal() { Type = nameof(KnownAnimals.cat) };
            var shelter = new Shelter();

            shelter.StoredAnimals.Add(Guid.NewGuid(), animal);

            GetResult result = shelter.RemoveAnimal(animal2);

            Assert.IsFalse(result.Status);
            Assert.AreEqual("Cannot find the animal in the system.", result.Error);
            Assert.IsNull(result.Animal);
            Assert.IsTrue(shelter.ContainsAnimal(animal));
            Assert.IsFalse(shelter.ContainsAnimal(animal2));
        }
        [TestMethod]
        public void RemoveAnimal_IncorrectInput()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.dog) };
            var animal2 = new Animal() { Type = "Spider Man" };
            var shelter = new Shelter();

            shelter.StoredAnimals.Add(Guid.NewGuid(), animal);

            GetResult result = shelter.RemoveAnimal(animal2);

            Assert.IsFalse(result.Status);
            Assert.AreEqual("The Shelter does not support this animal.", result.Error);
            Assert.IsNull(result.Animal);
            Assert.IsTrue(shelter.ContainsAnimal(animal));
            Assert.IsFalse(shelter.ContainsAnimal(animal2));
        }
        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveAnimal_nullinput()
        {
            var shelter = new Shelter();

            GetResult result = shelter.RemoveAnimal(null);

        }

        [TestMethod]
        public void GetAnimalFromId__CorrectId_returnpostiveresult()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.dog) };
            var id = Guid.NewGuid();
            var shelter = new Shelter();

            shelter.StoredAnimals.Add(id, animal);
            GetResult result = shelter.GetAnimalFromId(id);

            Assert.IsTrue(result.Status);
            Assert.AreEqual(animal, result.Animal);
            Assert.IsNull(result.Error);
        }
        [TestMethod]
        public void GetAnimalFromId_WrongID_returnError()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.dog) };
            var shelter = new Shelter();

            shelter.StoredAnimals.Add(Guid.NewGuid(), animal);
            GetResult result = shelter.GetAnimalFromId(Guid.NewGuid());

            Assert.IsFalse(result.Status);
            Assert.IsNull(result.Animal);
            Assert.AreEqual("Could not find any animals with that id.", result.Error);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetAnimalFromId_null()
        {
            var animal = new Animal() { Type = nameof(KnownAnimals.dog) };
            var id = Guid.NewGuid();
            var shelter = new Shelter();

            shelter.StoredAnimals.Add(id, animal);
            GetResult result = shelter.GetAnimalFromId(null);
        }

        [TestMethod]
        public void Getanimal_filtered()
        {
            var shelter = new Shelter();
            var search = new Animal() { Type = nameof(SupportedAnimals.cat) };
            var stringlist = Enum.GetNames(typeof(SupportedAnimals));
            List<Animal> animallist = stringlist.Select(item => new Animal() { Type = item }).ToList();

            foreach(Animal animal in animallist)
                shelter.AddAnimal(animal);
            shelter.AddAnimal(search);

            var filteredlist = shelter.GetAnimals(search);

            foreach(Animal a in filteredlist.Values)
                Assert.AreEqual(search.Type,a.Type);
        }

        [TestMethod]
        public void Getanimalfeature_filtered()
        {
            var shelter = new Shelter();
            var search = "Flight";
            var stringlist = Enum.GetNames(typeof(SupportedAnimals));
            List<Animal> animallist = stringlist.Select(item => new Animal() { Type = item }).ToList();

            foreach (Animal animal in animallist)
                shelter.AddAnimal(animal);

            var filteredlist = shelter.GetAnimals(search);

            foreach (Animal a in filteredlist.Values)
                Assert.AreEqual(nameof(SupportedAnimals.bird), a.Type);
        }

        [TestMethod]
        public void Getanimal_wrongfilter()
        {
            var shelter = new Shelter();
            var search = new Animal() { Type = nameof(KnownAnimals.bear) };
            var stringlist = Enum.GetNames(typeof(SupportedAnimals));
            List<Animal> animallist = stringlist.Select(item => new Animal() { Type = item }).ToList();

            foreach (Animal animal in animallist)
            {
                shelter.AddAnimal(animal);
            }

            var fliteredlist = shelter.GetAnimals(search);

            Assert.AreEqual(shelter.StoredAnimals,fliteredlist);
        }

        [TestMethod]
        public void Getanimalfeature_wrongfilter()
        {
            var shelter = new Shelter();
            var search = "";
            var stringlist = Enum.GetNames(typeof(SupportedAnimals));
            List<Animal> animallist = stringlist.Select(item => new Animal() { Type = item }).ToList();

            foreach (Animal animal in animallist)
            {
                shelter.AddAnimal(animal);
            }

            var fliteredlist = shelter.GetAnimals(search);

            Assert.AreEqual(shelter.StoredAnimals, fliteredlist);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Getanimal_nullinput()
        {
            var shelter = new Shelter();
            var search = new Animal() { Type = null };
            var stringlist = Enum.GetNames(typeof(SupportedAnimals));
            List<Animal> animallist = stringlist.Select(item => new Animal() { Type = item }).ToList();

            foreach (Animal animal in animallist)
            {
                shelter.AddAnimal(animal);
            }

            var fliteredlist = shelter.GetAnimals(search);

        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Getanimalfeautre_nullinput()
        {
            var shelter = new Shelter();
            string search = null;
            var stringlist = Enum.GetNames(typeof(SupportedAnimals));
            List<Animal> animallist = stringlist.Select(item => new Animal() { Type = item }).ToList();

            foreach (Animal animal in animallist)
            {
                shelter.AddAnimal(animal);
            }

            var fliteredlist = shelter.GetAnimals(search);

        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Getanimal_nullObject()
        {
            var shelter = new Shelter();
            Animal search = null;
            var stringlist = Enum.GetNames(typeof(SupportedAnimals));
            List<Animal> animallist = stringlist.Select(item => new Animal() { Type = item }).ToList();

            foreach (Animal animal in animallist)
            {
                shelter.AddAnimal(animal);
            }

            var fliteredlist = shelter.GetAnimals(search);

        }
    }

}