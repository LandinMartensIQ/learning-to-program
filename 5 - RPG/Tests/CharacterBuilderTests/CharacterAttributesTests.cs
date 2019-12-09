using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.CharacterBuilder;
using RPG.CharacterBuilder.CharacterAttributeClasses;

namespace CharacterBuilderTests
{
    [TestClass]
    public class CharacterAttributesTests
    {
        [TestMethod]
        public void CharacterAttributes_BlankConstructory_ReturnsDefaultValues()
        {
            //Arrange
            var result = new CharacterAttributes();
            var expectedHeight = result.Height.DefaultValue;
            var expectedRoundness = result.Roundness.DefaultValue;
            var expectedFitness = result.Fitness.DefaultValue;

            //Act

            //Assert
            Assert.AreEqual(expectedHeight, result.Height.Value);
            Assert.AreEqual(expectedRoundness, result.Roundness.Value);
            Assert.AreEqual(expectedFitness, result.Fitness.Value);
        }

        [TestMethod]
        public void CharacterAttributes_ConstructorWithInvalidInput_ReturnsDefaultValues()
        {
            //Arrange
            var result = new CharacterAttributes(110, FitnessLevelEnum.SomewhatFit, -200);
            var expectedHeight = result.Height.DefaultValue;
            var expectedRoundness = result.Roundness.DefaultValue;
            var expectedFitness = result.Fitness.DefaultValue;

            //Act

            //Assert
            Assert.AreEqual(expectedHeight, result.Height.Value);
            Assert.AreEqual(expectedRoundness, result.Roundness.Value);
            Assert.AreEqual(expectedFitness, result.Fitness.Value);

        }

        [TestMethod]
        public void CharacterAttributes_ConstructorWithValidInput_ReturnsWithValuesAsSet()
        {
            //Arrange
            var setHeight = 75;
            var setRoundness = 85;
            var setFitness = FitnessLevelEnum.NotFit;

            //Act
            var result = new CharacterAttributes(setRoundness, setFitness, setHeight);

            //Assert
            Assert.AreEqual(setHeight, result.Height.Value);
            Assert.AreEqual(setRoundness, result.Roundness.Value);
            Assert.AreEqual(setFitness, result.Fitness.Value);
        }

        //[TestMethod]
        //public void CharacterAttributes_SetHeightValidValue_ObjectUpdates()
        //{
        //    //Arrange
        //    var height = new Height(10);
        //    var expected = 73;

        //    //Act
        //    var result = height.SetValue(73);

        //    //Assert
        //    Assert.AreEqual(expected, height.Value);
        //    Assert.AreEqual(string.Empty, result.ErrorMessage);
        //    Assert.IsTrue(result.ResultSuccessful);
        //    Assert.AreEqual(height, result.Result);
        //}

        //[TestMethod]
        //public void CharacterAttributes_SetHeightInvalidValue_ObjectDoesNotUpdate()
        //{
        //    //Arrange
        //    var height = new Height(70);
        //    var expected = 70;
        //    var invalidInput = -10;

        //    //Act
        //    var result = height.SetValue(invalidInput);

        //    //Assert
        //    Assert.AreEqual(expected, height.Value);
        //    Assert.AreEqual(height.invalidValueError,result.ErrorMessage);
        //    Assert.IsFalse(result.ResultSuccessful);
        //}

        [TestMethod]
        public void CharacterAttributes_ReadableHeightReturnsCorrectString()
        {
            //Arrange
            var inputHeight1 = 71;
            var inputHeight2 = 84;
            var inputHeight3 = 73;
            var readableHeight1 = "5'11" + (char)34;
            var readableHeight2 = "7'";
            var readableHeight3 = "6'1" + (char)34;
            var attributeset1 = new CharacterAttributes(100, FitnessLevelEnum.ExtremelyFit, inputHeight1);
            var attributeset2 = new CharacterAttributes(80, FitnessLevelEnum.SomewhatFit, inputHeight2);
            var attributeset3 = new CharacterAttributes(0, FitnessLevelEnum.NotFit, inputHeight3);

            //Act
            var result1 = attributeset1.Height.ReadableHeight;
            var result2 = attributeset2.Height.ReadableHeight;
            var result3 = attributeset3.Height.ReadableHeight;

            //Assert
            Assert.AreEqual(readableHeight1, result1);
            Assert.AreEqual(readableHeight2, result2);
            Assert.AreEqual(readableHeight3, result3);
        }

        //[TestMethod]
        //public void CharacterAttributes_SetRoundnessValidValue_ObjectUpdates()
        //{
        //    //Arrange
        //    var roundness = new HeadRoundness(50);
        //    var expected = 73;

        //    //Act
        //    var result = roundness.SetValue(73);

        //    //Assert
        //    Assert.AreEqual(expected, roundness.Value);
        //    Assert.AreEqual(string.Empty, result.ErrorMessage);
        //    Assert.IsTrue(result.ResultSuccessful);
        //    Assert.AreEqual(roundness, result.Result);

        //}

        //[TestMethod]
        //public void CharacterAttributes_SetRoundnessInvalidValue_ObjectDoesNotUpdate()
        //{
        //    //Arrange
        //    var roundness = new HeadRoundness(70);
        //    var expected = 70;
        //    var invalidInput = 125;

        //    //Act
        //    var result = roundness.SetValue(invalidInput);

        //    //Assert
        //    Assert.AreEqual(expected, roundness.Value);
        //    Assert.AreEqual(roundness.invalidValueError,result.ErrorMessage);
        //    Assert.IsFalse(result.ResultSuccessful);

        //}

        //[TestMethod]
        //public void CharacterAttributes_SetFitnessValidValue_ObjectDoesUpdate()
        //{
        //    //Arrange
        //    var fitness = new FitnessLevel(FitnessLevelEnum.ExtremelyFit);
        //    var expected = FitnessLevelEnum.VeryFit;


        //    //Act
        //    var result = fitness.SetValue(FitnessLevelEnum.VeryFit);

        //    //Assert
        //    Assert.AreEqual(expected, fitness.Value);
        //    Assert.AreEqual(string.Empty, result.ErrorMessage);
        //    Assert.IsTrue(result.ResultSuccessful);
        //    Assert.AreEqual(fitness, result.Result);
        //}

        [TestMethod]
        public void CharacterAttributes_HeightMustBeGreaterThan0()
        {
            //Arrange
            var defaultHeight = new Height().DefaultValue;
            var supportedHeight = 60;
            var TooLow = -1;

            //Act
            var resultTooLow = new Height(TooLow);
            var resultSupported = new Height(supportedHeight);

            //Assert
            Assert.AreEqual(defaultHeight, resultTooLow.Value);
            Assert.AreEqual(supportedHeight, resultSupported.Value);
        }

        [TestMethod]
        public void CharacterAttributes_HeadRoundnessMustBeBetween0And100()
        {
            //Arrange
            var defaultHeadRoundness = new HeadRoundness().DefaultValue;
            var supportedHeadRoundness = 60;
            var TooLow = -1;
            var TooHigh = 101;

            //Act
            var resultTooLow = new HeadRoundness(TooLow);
            var resultTooHigh = new HeadRoundness(TooHigh);
            var resultSupported = new HeadRoundness(supportedHeadRoundness);

            //Assert
            Assert.AreEqual(defaultHeadRoundness, resultTooLow.Value);
            Assert.AreEqual(defaultHeadRoundness, resultTooHigh.Value);
            Assert.AreEqual(supportedHeadRoundness, resultSupported.Value);
        }
    }
}
