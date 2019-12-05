using AnimalShelters.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelters.Tests
{
    [TestClass]
    public class AnimalShelters_AnimalsTests
    {
        [TestMethod]
        public void Animal_ConstructorWithName_SetsName()
        {
            //Arrange
            var expected = "Buster";

            //Act
            var animal = new Dog("Buster");

            //Assert
            Assert.AreEqual(expected, animal.Name );
        }

        [TestMethod]
        public void Animal_ConstructorWithoutName_SetsDefaultName()
        {
            //Arrange
            var expected = "Not Set";

            //Act
            var animal = new Dog();

            //Assert
            Assert.AreEqual(expected, animal.Name);
        }

        [TestMethod]
        public void Animal_DefaultConstructor_SexNotSet()
        {
            //Arrange
            var expectedSex = AnimalSex.NotSet;

            //Act
            var animal = new Dog();

            //Assert
            Assert.AreEqual(expectedSex, animal.Sex);
        }

        [TestMethod]
        public void Animal_ModifyAnimal_ReturnsResult()
        {
            //Arrange
            var animal = new Bear();
            var mod = new AnimalModification { 
                Sex = OptionContainer.Build(AnimalSex.Male),
                Domesticated = OptionContainer.Build(false), 
                Neutered = OptionContainer.Build(true), 
                Name = OptionContainer.Build("Wally") };

            //Act
            var result = animal.ModifyAnimal(mod);

            //Assert
            Assert.AreEqual(AnimalSex.Male, result.Animal.Sex);
            Assert.AreEqual(false, result.Animal.Domesticated);
            Assert.AreEqual(true, result.Animal.Neutered);
            Assert.AreEqual("Wally", result.Animal.Name);
            Assert.IsNull(result.Error);
            Assert.AreEqual(true, result.OperationSuccess);
        }

        [TestMethod]
        public void Animal_ModifyAnimal_ModifiesAnimal()
        {
            //Arrange
            var animal = new Bear();
            var mod = new AnimalModification { 
                Sex = OptionContainer.Build(AnimalSex.Male), 
                Domesticated = OptionContainer.Build(false), 
                Neutered = OptionContainer.Build(true), 
                Name = OptionContainer.Build("Wally") };

            //Act
            var result = animal.ModifyAnimal(mod);

            //Assert
            Assert.AreEqual(AnimalSex.Male, animal.Sex);
            Assert.AreEqual(false, animal.Domesticated);
            Assert.AreEqual(true, animal.Neutered);
            Assert.AreEqual("Wally", animal.Name);
        }

        [TestMethod]
        public void Animal_ModifyAnimal_ReturnsErrorIfNoDataIsChanged()
        {
            //Arrange
            var animal = new Bear() { Sex = AnimalSex.Male, Domesticated = false, Neutered = true, Name = "Wally" };
            var mod = new AnimalModification { 
                Sex = OptionContainer.Build(AnimalSex.Male), 
                Domesticated = OptionContainer.Build(false), 
                Neutered = OptionContainer.Build(true), 
                Name = OptionContainer.Build("Wally") };

            //Act
            var result = animal.ModifyAnimal(mod);

            //Assert
            Assert.IsNotNull(result.Error);
            Assert.AreEqual(false, result.OperationSuccess);
        }

        [TestMethod]
        public void Animal_DogWeight_ReturnsDogSize()
        {
            //Arrange
            var smalldog = new Dog() { WeightKg = 5 };
            var mediumdog = new Dog() { WeightKg = 15 };
            var largedog = new Dog() { WeightKg = 30 };
            var giantdog = new Dog() { WeightKg = 60 };
            var smallexpected = DogSize.Small;
            var mediumexpected = DogSize.Medium;
            var largeexpected = DogSize.Large;
            var giantexpected = DogSize.Giant;

            //Act
            var smallactual = smalldog.Size;
            var mediumactual = mediumdog.Size;
            var largeactual = largedog.Size;
            var giantactual = giantdog.Size;

            //Assert
            Assert.AreEqual(smallexpected, smallactual);
            Assert.AreEqual(mediumexpected, mediumactual);
            Assert.AreEqual(largeexpected, largeactual);
            Assert.AreEqual(giantexpected, giantactual);
        }

        [TestMethod]
        public void Animal_DogsCannotFly()
        {
            //Arrange
            var dog = new Dog();
            var expected = false;

            //Act
            var actual = dog.CanFly; 

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}