using System;
using AnimalShelters.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnimalShelters.Tests
{
    [TestClass]
    public class AnimalShelter_FilterTests
    {
        [TestMethod]
        public void FilterOption_EmptyConstructor_AppliedValueFalse()
        {
            //Arrange
            var expected = false;

            //Act
            var filterOptionBool = new OptionContainer<bool>();
            var filterOptionString = new OptionContainer<string>();
            var filterOptionEnum = new OptionContainer<AnimalSex>();

            //Assert
            Assert.AreEqual(expected, filterOptionBool.OptionIsApplied());
            Assert.AreEqual(expected, filterOptionString.OptionIsApplied());
            Assert.AreEqual(expected, filterOptionEnum.OptionIsApplied());

        }

        [TestMethod]
        public void FilterOption_ValueInConstructor_AppliedValueTrue()
        {
            //Arrange
            var expected = true;

            //Act
            var filterOptionBool = new OptionContainer<bool>(true);
            var filterOptionString = new OptionContainer<string>("Cleo");
            var filterOptionEnum = new OptionContainer<AnimalSex>(AnimalSex.Female);

            //Assert
            Assert.AreEqual(expected, filterOptionBool.OptionIsApplied());
            Assert.AreEqual(expected, filterOptionString.OptionIsApplied());
            Assert.AreEqual(expected, filterOptionEnum.OptionIsApplied());

        }

        [TestMethod]
        public void FilterOption_EmptyConstructor_FilterOptionsSet_AppliedValueTrue()
        {
            //Arrange
            var expected = true;

            //Act
            var filterOptionBool = new OptionContainer<bool>();
            var filterOptionString = new OptionContainer<string>();
            var filterOptionEnum = new OptionContainer<AnimalSex>();
            filterOptionBool.Value = true;
            filterOptionString.Value = "Johnny";
            filterOptionEnum.Value = AnimalSex.Male;


            //Assert
            Assert.AreEqual(expected, filterOptionBool.OptionIsApplied());
            Assert.AreEqual(expected, filterOptionString.OptionIsApplied());
            Assert.AreEqual(expected, filterOptionEnum.OptionIsApplied());

        }

        [TestMethod]
        public void FilterOption_ValueInConstructor_FilterOptionsRemoved_AppliedValueTrue()
        {
            //Arrange
            var expected = false;

            //Act
            var filterOptionBool = new OptionContainer<bool>(true);
            var filterOptionString = new OptionContainer<string>("Cleo");
            var filterOptionEnum = new OptionContainer<AnimalSex>(AnimalSex.Female);
            filterOptionBool.RemoveOption();
            filterOptionString.RemoveOption();
            filterOptionEnum.RemoveOption();

            //Assert
            Assert.AreEqual(expected, filterOptionBool.OptionIsApplied());
            Assert.AreEqual(expected, filterOptionString.OptionIsApplied());
            Assert.AreEqual(expected, filterOptionEnum.OptionIsApplied());

        }
        [TestMethod]
        public void NewAnimalFilter_EmptyConstructor_AppliedValuesFalse()
        {
            //Arrange
            var expected = false;

            //Act
            var filter = new AnimalFilter();

            //Assert
            Assert.AreEqual(expected, filter.CanFly.OptionIsApplied());
            Assert.AreEqual(expected, filter.Domesticated.OptionIsApplied());
            Assert.AreEqual(expected, filter.Name.OptionIsApplied());
            Assert.AreEqual(expected, filter.Neutered.OptionIsApplied());
            Assert.AreEqual(expected, filter.Sex.OptionIsApplied());
            Assert.AreEqual(expected, filter.Type.OptionIsApplied());

        }
        [TestMethod]
        public void AnimalFilter_FilterOptionsSet_ModifiedFilterOptionsAppliedValueTrue()
        {
            //Arrange
            var filter = new AnimalFilter();

            //Act
            filter.CanFly.Value = true;
            filter.Name.Value = "Belle";
            filter.Sex.Value = AnimalSex.Female;

            //Assert
            Assert.AreEqual(true, filter.CanFly.OptionIsApplied());
            Assert.AreEqual(true, filter.Name.OptionIsApplied());
            Assert.AreEqual(true, filter.Sex.OptionIsApplied());

        }

        [TestMethod]
        public void AnimalFilter_FilterOptionsSet_UnmodifiedFilterOptionsAppliedValueFalse()
        {
            //Arrange
            var filter = new AnimalFilter();

            //Act
            filter.CanFly.Value = true;
            filter.Name.Value = "Belle";
            filter.Sex.Value = AnimalSex.Female;

            //Assert
            Assert.AreEqual(false, filter.Domesticated.OptionIsApplied());
            Assert.AreEqual(false, filter.Neutered.OptionIsApplied());
            Assert.AreEqual(false, filter.Type.OptionIsApplied());

        }

        [TestMethod]
        public void AnimalFilter_FilterOptionsRemoved_FilterOptionsAppliedFalse()
        {
            //Arrange
            var filter = new AnimalFilter();

            //Act
            filter.CanFly.Value = true;
            filter.CanFly.RemoveOption();

            //Assert
            Assert.AreEqual(false, filter.CanFly.OptionIsApplied());

        }
    }
}