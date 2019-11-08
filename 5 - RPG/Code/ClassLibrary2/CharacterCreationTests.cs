using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests
{
    [TestClass]
    public class CharacterCreationTests
    {

        [TestMethod]
        public void successfulCharacterCreation()
        {
            Characters.AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 10;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 10;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 10;

            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);

            Assert.IsTrue(myChar.AbilityStats.charisma == 10);
            Assert.IsTrue(myChar.AbilityStats.constitution == 10);
            Assert.IsTrue(myChar.AbilityStats.dexterity == 10);
            Assert.IsTrue(myChar.AbilityStats.intelligence == 10);
            Assert.IsTrue(myChar.AbilityStats.strength == 10);
            Assert.IsTrue(myChar.AbilityStats.wisdom == 10);

            Assert.IsTrue(myChar.fitnessLevel == Characters.FitnessLevel.extremely);
            Assert.IsTrue(myChar.headShape == 100);
            Assert.IsTrue(myChar.stringHeight == "5'");

        }
    }
}
