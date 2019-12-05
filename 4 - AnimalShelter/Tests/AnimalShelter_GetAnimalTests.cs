using System;
using AnimalShelters.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelters.Tests
{
    [TestClass]
    public class AnimalShelter_GetAnimalTests
    {
        [TestMethod]
        public void GetAnimals_ReturnsFullList_WhenNoParam()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Cat());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Deer());
            shelter.AddAnimal(new Bear());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Snake());
            shelter.AddAnimal(new Cat());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Deer());
            shelter.AddAnimal(new Bear());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Snake());
            var expected = 8;

            //Act
            var actual = shelter.GetAnimals();

            //Assert
            Assert.AreEqual(expected, actual.Count);
        }


        [TestMethod]
        public void GetAnimals_ReturnsBasedOnFilter_FlyingSetTypeSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Cat());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            var expected = 1;
            var filter = new AnimalFilter() { 
                CanFly = OptionContainer.Build(false), 
                Type = new OptionContainer<AnimalType>(AnimalType.Cat) };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsBasedOnFilter_FlyingSetTypeNotSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Cat());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            var expected = 3;
            var filter = new AnimalFilter() { CanFly = OptionContainer.Build(true) };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }
        [TestMethod]
        public void GetAnimals_ReturnsBasedOnFilter_FlyingNotSetTypeSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Cat());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            var expected = 2;
            var filter = new AnimalFilter() { Type = OptionContainer.Build(AnimalType.Dog) };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsBasedOnFilter_NotSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Cat());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            var expected = 6;
            var blankfilter = new AnimalFilter();

            //Act
            var actual = shelter.GetAnimals(blankfilter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }


        [TestMethod]
        public void GetAnimals_ReturnsNoResults_FlyingSetTypeSet()
        {
            //Arrange
            var shelter = new AnimalShelter();
            shelter.AddAnimal(new Cat());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Dog());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            shelter.AddAnimal(new Bird());
            var expected = 0;
            var filter = new AnimalFilter() { 
                CanFly = OptionContainer.Build(true), 
                Type = OptionContainer.Build(AnimalType.Cat) };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsResults_BasedOnSex()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Cat();
            var animal2 = new Dog();
            var animal3 = new Snake();
            animal1.Sex = AnimalSex.Male;
            animal2.Sex = AnimalSex.Male;
            animal3.Sex = AnimalSex.Female;
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);
            shelter.AddAnimal(animal3);
            var expected = 1;
            var filter = new AnimalFilter() { Sex = OptionContainer.Build(AnimalSex.Female) };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsResultsBasedOnName_WhenNameExists()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Cat("Murphy");
            var animal2 = new Dog("Rex");
            var animal3 = new Snake("Cleo");
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);
            shelter.AddAnimal(animal3);
            var expected = 1;
            var filter = new AnimalFilter() { Name = OptionContainer.Build("Rex") };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsNoResultsBasedOnName_WhenNameDoesNotExist()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Cat("Murphy");
            var animal2 = new Dog("Rex");
            var animal3 = new Snake("Cleo");
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);
            shelter.AddAnimal(animal3);
            var expected = 0;
            var filter = new AnimalFilter() { Name = OptionContainer.Build("Brian") };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimals_ReturnsResultsBasedOnMultipleParams()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal1 = new Cat("Murphy") { Sex = AnimalSex.Male, Neutered = true, Domesticated = true };
            var animal2 = new Dog("Rex") { Sex = AnimalSex.Male, Domesticated = true };
            var animal3 = new Snake("Cleo") { Sex = AnimalSex.Female, Domesticated = true };
            var animal4 = new Bird("Polly") { Sex = AnimalSex.Male, Neutered = true, Domesticated = true };
            var animal5 = new Dog("Greg") { Sex = AnimalSex.Male, Neutered = true, Domesticated = false };
            var animal6 = new Cat("Phylis") { Domesticated = true };
            shelter.AddAnimal(animal1);
            shelter.AddAnimal(animal2);
            shelter.AddAnimal(animal3);
            shelter.AddAnimal(animal4);
            shelter.AddAnimal(animal5);
            shelter.AddAnimal(animal6);
            var expected = 1;
            var filter = new AnimalFilter() { 
                Sex = OptionContainer.Build(AnimalSex.Male), 
                Neutered = OptionContainer.Build(true), 
                CanFly = OptionContainer.Build(false), 
                Domesticated = OptionContainer.Build(true) };

            //Act
            var actual = shelter.GetAnimals(filter);

            //Assert
            Assert.AreEqual(expected, actual.Count);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsAnimal_WhenAnimalExistsInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            shelter.AddAnimal(animal);

            //Act
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert
            Assert.AreEqual(animal, actual.Animal);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsNoAnimal_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            Guid ID = animal.UniqueAnimalId;

            //Act
            var actual = shelter.GetAnimalFromID(ID);

            //Assert
            Assert.IsNull(actual.Animal);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsNoError_WhenAnimalExistsInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            shelter.AddAnimal(animal);

            //Act
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert
            Assert.IsNull(actual.Error);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnsError_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            Guid ID = animal.UniqueAnimalId;

            //Act
            var actual = shelter.GetAnimalFromID(ID);

            //Assert
            Assert.IsNotNull(actual.Error);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnOperationSuccessTrue_WhenAnimalExistInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            shelter.AddAnimal(animal);
            var expected = true;

            //Act
            var actual = shelter.GetAnimalFromID(animal.UniqueAnimalId);

            //Assert
            Assert.AreEqual(expected, actual.OperationSuccess);

        }

        [TestMethod]
        public void GetAnimalFromID_ReturnOperationSuccessFalse_WhenAnimalDoesNotExistInShelter()
        {
            //Arrange
            var shelter = new AnimalShelter();
            var animal = new Cat();
            Guid ID = animal.UniqueAnimalId;
            var expected = false;

            //Act
            var actual = shelter.GetAnimalFromID(ID);

            //Assert
            Assert.AreEqual(expected, actual.OperationSuccess);

        }
    }
}