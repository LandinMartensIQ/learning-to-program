

using AnimalShelter.Code.Enums;
using AnimalShelter.Code.Objects;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelter.Tests
{
	[TestClass]
	public class ClassNameUnderTest_Tests


	{
            /*
		[TestMethod]
		public void MethodName_ShouldDoSomething_WhenCondition()
		{
			//Arrange [Variables, object creation and other set up]

			//Act [Method / Function invoke with passed in data]

			//Assert [Validate that something should have happened]
			
			//Assert.AreEqual(<expected>, <actual>);
		}

    */
        [TestMethod]   
        public void addAnimal_createsID()
        {
            var shelter = new Shelter();

            var response=shelter.AddAnimal(AnimalTypes.Cat);

            Assert.IsNotNull(response.animal.Id);

        }


        [TestMethod]
        public void addAnimal_creates_uniqueIDs()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Cat);
            var response2 = shelter.AddAnimal(AnimalTypes.Cat);

            Assert.AreNotEqual(response.animal.Id, response2.animal.Id);

        }

        [TestMethod]
        public void addAnimal_unsupported_returns_correct_object_values()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Deer);

            Assert.IsNull(response.animal);
            Assert.IsFalse(response.success);
            Assert.IsTrue(response.error.Equals("Animal was not a supported animal"));

        }

        [TestMethod]
        public void addAnimal_supported_returns_correct_object_values_for_cat()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Cat);

            Assert.IsNotNull(response.animal.Id);
            Assert.AreEqual(response.animal.type, AnimalTypes.Cat);
            Assert.IsTrue(response.success);
            Assert.IsNull(response.error);

        }

        [TestMethod]
        public void addAnimal_supported_returns_correct_object_values_for_dog()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Dog);

            Assert.IsNotNull(response.animal.Id);
            Assert.AreEqual(AnimalTypes.Dog,response.animal.type);
            Assert.IsTrue(response.success);
            Assert.IsNull(response.error);

        }

        [TestMethod]
        public void GetAnimals_fly_returns_for_fly()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Bird);
            var animals = shelter.GetAnimals(Filters.Fly);

            Assert.IsTrue(animals.Count == 1);

           
        }

        [TestMethod]
        public void GetAnimals_fly_returns_multiples()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Bird);
            var response2 = shelter.AddAnimal(AnimalTypes.Bird);
            var animals = shelter.GetAnimals(Filters.Fly);

            Assert.IsTrue(animals.Count == 2);
        }

        [TestMethod]
        public void GetAnimals_fly_returns_null()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Cat);
            var animals = shelter.GetAnimals(Filters.Fly);

            Assert.IsTrue(animals.Count == 0);
        }

        [TestMethod]
        public void GetAnimals_dogs_returns_multiples()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Cat);
            var response2 = shelter.AddAnimal(AnimalTypes.Dog);
            var response3 = shelter.AddAnimal(AnimalTypes.Dog);
            var animals = shelter.GetAnimals(Filters.Dogs);

            Assert.IsTrue(animals.Count == 2);
        }

        [TestMethod]
        public void GetAnimals_noFilter_returns_multiples()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Cat);
            var response2 = shelter.AddAnimal(AnimalTypes.Dog);
            var response3 = shelter.AddAnimal(AnimalTypes.Dog);
            var animals = shelter.GetAnimals();

            Assert.IsTrue(animals.Count == 3);
        }

        [TestMethod]
        public void GetAnimals_noFilter_returns_only_supported()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Cat);
            var response1 = shelter.AddAnimal(AnimalTypes.Dog);
            var response2 = shelter.AddAnimal(AnimalTypes.Deer);
            var response3 = shelter.AddAnimal(AnimalTypes.Bear);
            var response4 = shelter.AddAnimal(AnimalTypes.Bird);
            var response5 = shelter.AddAnimal(AnimalTypes.Snake);
            var animals = shelter.GetAnimals();

            Assert.IsTrue(animals.Count == 4);
        }

        [TestMethod]
        public void GetAnimals_cats_returns_multiples()
        {
            var shelter = new Shelter();

            var response = shelter.AddAnimal(AnimalTypes.Cat);
            var response1 = shelter.AddAnimal(AnimalTypes.Dog);
            var response2 = shelter.AddAnimal(AnimalTypes.Dog);
            var response3 = shelter.AddAnimal(AnimalTypes.Cat);
            var response4 = shelter.AddAnimal(AnimalTypes.Bear);
            var animals = shelter.GetAnimals(Filters.Cats);

            Assert.IsTrue(animals.Count == 2);
        }

        [TestMethod]
        public void Remove_Animal_returns_correct_values_for_animal_not_found()
        {
            {
                var shelter = new Shelter();
                Animal myAnimal = new Animal(AnimalTypes.Cat);

                var response = shelter.RemoveAnimal(myAnimal);

                Assert.IsNull(response.animal);
                Assert.IsFalse(response.success);
                Assert.AreEqual(response.error, "Animal was not in the system");
            }
        }

        [TestMethod]
        public void RemoveAnimal_returns_correct_values_for_unsupported()
        {
            var shelter = new Shelter();
            var myAnimal = new Animal(AnimalTypes.Bear);
        

            var response = shelter.RemoveAnimal(myAnimal);

            Assert.IsNull(response.animal);
            Assert.IsFalse(response.success);
            Assert.AreEqual(response.error, "Animal was not a supported type");
        }

        [TestMethod]
        public void RemoveAnimal_returns_correct_animal_onSuccess()
        {
            var shelter = new Shelter();
            var addResponse = shelter.AddAnimal(AnimalTypes.Dog);
            
            var response = shelter.RemoveAnimal(addResponse.animal);

            Assert.IsNull(response.error);
            Assert.IsTrue(response.success);
            Assert.AreEqual(addResponse.animal, response.animal);

        }

        [TestMethod]
        public void GetAnimalFromId_returns_correct_if_found()
        {
            var shelter = new Shelter();
            var addResponse = shelter.AddAnimal(AnimalTypes.Dog);

            var response=shelter.GetAnimalFromId(addResponse.animal.Id);

            Assert.IsTrue(response.success);
            Assert.AreEqual(response.animal.Id, addResponse.animal.Id);
            Assert.AreEqual(response.animal.type, addResponse.animal.type);
            Assert.IsNull(response.error);
        }

        [TestMethod]
        public void GetAnimalFromId_returns_error_if_not_found()
        {
            var shelter = new Shelter();
            var addResponse = shelter.AddAnimal(AnimalTypes.Dog);

            var response = shelter.GetAnimalFromId(new System.Guid());

            Assert.IsFalse(response.success);
            Assert.IsNull(response.animal);
            Assert.AreEqual(response.error, "Animal does not exist in the system");

        }

        [TestMethod]
        public void GetAnimalFromId_finds_correct_animal_from_list()
        {
            var shelter = new Shelter();
            var addResponse = shelter.AddAnimal(AnimalTypes.Snake);
            var addResponse2 = shelter.AddAnimal(AnimalTypes.Snake);
            var addResponse3 = shelter.AddAnimal(AnimalTypes.Snake);

            var response = shelter.GetAnimalFromId(addResponse2.animal.Id);

            Assert.AreEqual(addResponse2.animal, response.animal);




        }
    }
}


