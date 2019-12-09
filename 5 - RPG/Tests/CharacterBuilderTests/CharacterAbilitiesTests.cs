using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPG.CharacterBuilder;
using RPG.CharacterBuilder.CharacterAbilityClasses;

namespace CharacterBuilderTests
{
    [TestClass]
    public class CharacterAbilitiesTests
    {
        [TestMethod]
        public void CharacterAbilities_BlankConstructor_DefaultValuesInitialized()
        {
            //Arrange
            var expected = 10;

            //Act
            var result = new CharacterAbilities();

            //Assert
            Assert.AreEqual(expected, result.Intelligence.Value);
            Assert.AreEqual(expected, result.Wisdom.Value);
            Assert.AreEqual(expected, result.Dexterity.Value);
            Assert.AreEqual(expected, result.Strength.Value);
            Assert.AreEqual(expected, result.Charisma.Value);
            Assert.AreEqual(expected, result.Constitution.Value);

        }

        [TestMethod]
        public void CharacterAbilities_BuildMethodWithExactly60Points_ReturnsCorrespondingAbilities()
        {
            //Arrange
            var inputIntelligence = 5;
            var inputWisdom = 15;
            var inputDexterity = 12;
            var inputStrength = 8;
            var inputCharisma = 0;
            var inputConstitution = 20;

            //Act            
            var result = CharacterAbilities.Build(  inputIntelligence,
                                                    inputWisdom,
                                                    inputDexterity,
                                                    inputStrength,
                                                    inputCharisma,
                                                    inputConstitution);

            //Assert
            Assert.AreEqual(inputIntelligence, result.Result.Intelligence.Value);
            Assert.AreEqual(inputWisdom, result.Result.Wisdom.Value);
            Assert.AreEqual(inputDexterity, result.Result.Dexterity.Value);
            Assert.AreEqual(inputStrength, result.Result.Strength.Value);
            Assert.AreEqual(inputCharisma, result.Result.Charisma.Value);
            Assert.AreEqual(inputConstitution,result.Result.Constitution.Value);
            Assert.AreEqual(string.Empty, result.ErrorMessage);
            Assert.IsTrue(result.ResultSuccessful);
        }

        [TestMethod]
        public void CharacterAbilities_BuildMethodWithGreaterThan60Points_ReturnsErrorResult()
        {
            //Arrange
            var inputIntelligence = 6;
            var inputWisdom = 15;
            var inputDexterity = 12;
            var inputStrength = 8;
            var inputCharisma = 0;
            var inputConstitution = 20;

            //Act            
            var result = CharacterAbilities.Build(inputIntelligence,
                                                    inputWisdom,
                                                    inputDexterity,
                                                    inputStrength,
                                                    inputCharisma,
                                                    inputConstitution);

            //Assert
            Assert.IsNull(result.Result);
            Assert.IsNotNull(result.ErrorMessage);
            Assert.AreNotEqual(string.Empty, result.ErrorMessage);
            Assert.IsFalse(result.ResultSuccessful);
        }

        [TestMethod]
        public void CharacterAbilities_BuildMethodWithLessThan60Points_ReturnsErrorResult()
        {
            //Arrange
            var inputIntelligence = 4;
            var inputWisdom = 15;
            var inputDexterity = 12;
            var inputStrength = 8;
            var inputCharisma = 0;
            var inputConstitution = 20;

            //Act            
            var result = CharacterAbilities.Build(inputIntelligence,
                                                    inputWisdom,
                                                    inputDexterity,
                                                    inputStrength,
                                                    inputCharisma,
                                                    inputConstitution);

            //Assert
            Assert.IsNull(result.Result);
            Assert.IsNotNull(result.ErrorMessage);
            Assert.AreNotEqual(string.Empty, result.ErrorMessage);
            Assert.IsFalse(result.ResultSuccessful);
        }

        [TestMethod]
        public void CharacterAbilities_IntelligenceMustBeBetween5And20()
        {
            //Arrange
            var defaultIntelligence = new Intelligence().DefaultValue;
            var supportedIntelligence = 15;
            var TooHigh = 21;
            var TooLow = 4;

            //Act
            var resultTooHigh = new Intelligence(TooHigh);
            var resultTooLow = new Intelligence(TooLow);
            var resultSupported = new Intelligence(supportedIntelligence);

            //Assert
            Assert.AreEqual(defaultIntelligence, resultTooHigh.Value);
            Assert.AreEqual(defaultIntelligence, resultTooLow.Value);
            Assert.AreEqual(supportedIntelligence, resultSupported.Value);
        }

        [TestMethod]
        public void CharacterAbilities_WisdomMustBeBetween5And20()
        {
            //Arrange
            var defaultWisdom = new Wisdom().DefaultValue;
            var supportedWisdom = 15;
            var TooHigh = 21;
            var TooLow = 4;

            //Act
            var resultTooHigh = new Wisdom(TooHigh);
            var resultTooLow = new Wisdom(TooLow);
            var resultSupported = new Wisdom(supportedWisdom);

            //Assert
            Assert.AreEqual(defaultWisdom, resultTooHigh.Value);
            Assert.AreEqual(defaultWisdom, resultTooLow.Value);
            Assert.AreEqual(supportedWisdom, resultSupported.Value);
        }

        [TestMethod]
        public void CharacterAbilities_DexterityMustBeBetween1And20()
        {
            //Arrange
            var defaultDexterity = new Dexterity().DefaultValue;
            var supportedDexterity = 15;
            var TooHigh = 21;
            var TooLow = 0;

            //Act
            var resultTooHigh = new Dexterity(TooHigh);
            var resultTooLow = new Dexterity(TooLow);
            var resultSupported = new Dexterity(supportedDexterity);

            //Assert
            Assert.AreEqual(defaultDexterity, resultTooHigh.Value);
            Assert.AreEqual(defaultDexterity, resultTooLow.Value);
            Assert.AreEqual(supportedDexterity, resultSupported.Value);
        }

        [TestMethod]
        public void CharacterAbilities_StrengthMustBeBetween1And20()
        {
            //Arrange
            var defaultStrength = new Strength().DefaultValue;
            var supportedStrength = 15;
            var TooHigh = 21;
            var TooLow = 0;

            //Act
            var resultTooHigh = new Strength(TooHigh);
            var resultTooLow = new Strength(TooLow);
            var resultSupported = new Strength(supportedStrength);

            //Assert
            Assert.AreEqual(defaultStrength, resultTooHigh.Value);
            Assert.AreEqual(defaultStrength, resultTooLow.Value);
            Assert.AreEqual(supportedStrength, resultSupported.Value);
        }

        [TestMethod]
        public void CharacterAbilities_CharismaMustBeBetween0And20()
        {
            //Arrange
            var defaultCharisma = new Charisma().DefaultValue;
            var supportedCharisma = 15;
            var TooHigh = 21;
            var TooLow = -1;

            //Act
            var resultTooHigh = new Charisma(TooHigh);
            var resultTooLow = new Charisma(TooLow);
            var resultSupported = new Charisma(supportedCharisma);

            //Assert
            Assert.AreEqual(defaultCharisma, resultTooHigh.Value);
            Assert.AreEqual(defaultCharisma, resultTooLow.Value);
            Assert.AreEqual(supportedCharisma, resultSupported.Value);
        }

        [TestMethod]
        public void CharacterAbilities_ConstitutionMustBeBetween10And20()
        {
            //Arrange
            var defaultConstitution = new Constitution().DefaultValue;
            var supportedConstitution = 15;
            var TooHigh = 21;
            var TooLow = 9;

            //Act
            var resultTooHigh = new Constitution(TooHigh);
            var resultTooLow = new Constitution(TooLow);
            var resultSupported = new Constitution(supportedConstitution);

            //Assert
            Assert.AreEqual(defaultConstitution, resultTooHigh.Value);
            Assert.AreEqual(defaultConstitution, resultTooLow.Value);
            Assert.AreEqual(supportedConstitution, resultSupported.Value);
        }
    }
}
