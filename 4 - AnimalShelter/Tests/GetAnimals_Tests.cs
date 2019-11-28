using AnimalShelter.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace AnimalShelter.Tests
{
    [TestClass]
    public class GetAnimals_Tests
    {
        [TestMethod]
        public void GetAnimal__ShouldReturnBird_WhenFilterFlying()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            var dog = new Animal(AnimalType.Dog);
            var bird = new Animal(AnimalType.Bird);
            animalShelter.AddAnimal(cat);
            animalShelter.AddAnimal(cat);
            animalShelter.AddAnimal(cat);
            animalShelter.AddAnimal(dog);
            animalShelter.AddAnimal(dog);
            animalShelter.AddAnimal(bird);
            //Act [Method / Function invoke with passed in data]
            List<Animal> FilteredAnimals = animalShelter.GetAnimals(FilterTypes.Fly);
            //Assert [Validate that something should have happened]
            Assert.AreEqual(1, FilteredAnimals.Count);

            //Assert.AreEqual(<expected>, <actual>);
        }
        [TestMethod]
        public void GetAnimal__ShouldReturnCat_WhenFilterCat()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            var anotherCat = new Animal(AnimalType.Cat);
            var yetAnotherCat = new Animal(AnimalType.Cat);
            var dog = new Animal(AnimalType.Dog);
            var anotherDog = new Animal(AnimalType.Dog);
            var bird = new Animal(AnimalType.Bird);
            animalShelter.AddAnimal(cat);
            animalShelter.AddAnimal(anotherCat);
            animalShelter.AddAnimal(yetAnotherCat);
            animalShelter.AddAnimal(dog);
            animalShelter.AddAnimal(anotherDog);
            animalShelter.AddAnimal(bird);
            //Act [Method / Function invoke with passed in data]
            List<Animal> FilteredAnimals = animalShelter.GetAnimals(FilterTypes.Cat);
            //Assert [Validate that something should have happened]
            Assert.AreEqual(3, FilteredAnimals.Count);

            //Assert.AreEqual(<expected>, <actual>);
        }
        [TestMethod]
        public void GetAnimal__ShouldReturnDog_WhenFilterDog()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            var anotherCat = new Animal(AnimalType.Cat);
            var yetAnotherCat = new Animal(AnimalType.Cat);
            var dog = new Animal(AnimalType.Dog);
            var anotherDog = new Animal(AnimalType.Dog);
            var bird = new Animal(AnimalType.Bird);
            animalShelter.AddAnimal(cat);
            animalShelter.AddAnimal(anotherCat);
            animalShelter.AddAnimal(yetAnotherCat);
            animalShelter.AddAnimal(dog);
            animalShelter.AddAnimal(anotherDog);
            animalShelter.AddAnimal(bird);
            //Act [Method / Function invoke with passed in data]
            List<Animal> FilteredAnimals = animalShelter.GetAnimals(FilterTypes.Dog);
            //Assert [Validate that something should have happened]
            Assert.AreEqual(2, FilteredAnimals.Count);

            //Assert.AreEqual(<expected>, <actual>);
        }
        [TestMethod]
        public void GetAnimal__ShouldReturnAll_WhenAnyOtherFilter()
        {
            var animalShelter = new Code.AnimalShelter();
            var cat = new Animal(AnimalType.Cat);
            var anotherCat = new Animal(AnimalType.Cat);
            var yetAnotherCat = new Animal(AnimalType.Cat);
            var dog = new Animal(AnimalType.Dog);
            var anotherDog = new Animal(AnimalType.Dog);
            var bird = new Animal(AnimalType.Bird);
            animalShelter.AddAnimal(cat);
            animalShelter.AddAnimal(anotherCat);
            animalShelter.AddAnimal(yetAnotherCat);
            animalShelter.AddAnimal(dog);
            animalShelter.AddAnimal(anotherDog);
            animalShelter.AddAnimal(bird);
            //Act [Method / Function invoke with passed in data]
            List<Animal> FilteredAnimals = animalShelter.GetAnimals(FilterTypes.All);
            //Assert [Validate that something should have happened]
            Assert.AreEqual(6, FilteredAnimals.Count);

            //Assert.AreEqual(<expected>, <actual>);
        }
    }
}
