using System;
using NUnit.Framework;
using Characters;
using System.Collections.Generic;



namespace Tests
{
    public class CharacterCreationTests
    {

        [Test]
        public void successfulCharacterCreation()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

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

        [Test]
        public void CharacterHeightUnderOneFoot()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 10;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 10;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 10;

            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 11, abilityPoints);

            Assert.IsTrue(myChar.stringHeight == "11");
        }

        [Test]
        public void CharacterHeightOneFoot()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 10;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 10;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 10;

            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 12, abilityPoints);

            Assert.IsTrue(myChar.stringHeight == "1'");
        }

        [Test]
        public void CharacterHeightOneFootEleven()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 10;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 10;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 10;

            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 23, abilityPoints);

            Assert.IsTrue(myChar.stringHeight == "1'11");
        }

        [Test]
        public void CorrectlyStoredAbilityPoints()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 3;
            abilityPoints.constitution = 12;
            abilityPoints.dexterity = 7;
            abilityPoints.intelligence = 11;
            abilityPoints.strength = 13;
            abilityPoints.wisdom = 14;

            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);

            Assert.IsTrue(myChar.AbilityStats.charisma == 3);
            Assert.IsTrue(myChar.AbilityStats.constitution == 12);
            Assert.IsTrue(myChar.AbilityStats.dexterity == 7);
            Assert.IsTrue(myChar.AbilityStats.intelligence == 11);
            Assert.IsTrue(myChar.AbilityStats.strength == 13);
            Assert.IsTrue(myChar.AbilityStats.wisdom == 14);

            Assert.IsTrue(myChar.fitnessLevel == Characters.FitnessLevel.extremely);
            Assert.IsTrue(myChar.headShape == 100);
            Assert.IsTrue(myChar.stringHeight == "5'");

        }

        [Test]
        public void NegativeCharismaThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = -1;
            abilityPoints.constitution = 20;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 11;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 10;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Charisma must be between 0 and 20.\n");
            }


        }

        [Test]
        public void CharismaOver20ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 21;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 5;
            abilityPoints.strength = 9;
            abilityPoints.wisdom = 5;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Charisma must be between 0 and 20.\n");
            }
        }


        [Test]
        public void IntelligenceBelow5ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 6;
            abilityPoints.constitution = 20;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 4;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 10;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Intelligence must be between 5 and 20.\n");
            }

        }

        [Test]
        public void IntelligenceAbove20ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 5;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 6;
            abilityPoints.intelligence = 21;
            abilityPoints.strength = 8;
            abilityPoints.wisdom = 10;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Intelligence must be between 5 and 20.\n");
            }

        }

        [Test]
        public void WisdomBelow5ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 6;
            abilityPoints.constitution = 20;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 10;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 4;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Wisdom must be between 5 and 20.\n");
            }

        }

        [Test]
        public void WisdomAbove20ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 6;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 7;
            abilityPoints.strength = 6;
            abilityPoints.wisdom = 21;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Wisdom must be between 5 and 20.\n");
            }

        }

        [Test]
        public void DexterityAbove20ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 5;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 21;
            abilityPoints.intelligence = 9;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 5;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Dexterity must be between 1 and 20.\n");
            }

        }

        [Test]
        public void Dexterity0ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 6;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 0;
            abilityPoints.intelligence = 17;
            abilityPoints.strength = 7;
            abilityPoints.wisdom = 20;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Dexterity must be between 1 and 20.\n");
            }

        }

        [Test]
        public void StrengthAbove20ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 5;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 9;
            abilityPoints.strength = 21;
            abilityPoints.wisdom = 5;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Strength must be between 1 and 20.\n");
            }

        }

        [Test]
        public void StrengthBelow1ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 15;
            abilityPoints.constitution = 15;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 10;
            abilityPoints.strength = 0;
            abilityPoints.wisdom = 10;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Strength must be between 1 and 20.\n");
            }

        }

        [Test]
        public void Constitution21ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 6;
            abilityPoints.constitution = 21;
            abilityPoints.dexterity = 7;
            abilityPoints.intelligence = 16;
            abilityPoints.strength = 1;
            abilityPoints.wisdom = 9;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Constitution must be between 10 and 20.\n");
            }

        }

        [Test]
        public void Constitution9ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 6;
            abilityPoints.constitution = 9;
            abilityPoints.dexterity = 8;
            abilityPoints.intelligence = 16;
            abilityPoints.strength = 1;
            abilityPoints.wisdom = 20;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Constitution must be between 10 and 20.\n");
            }

        }

        [Test]
        public void AllErrorsOnAbilityReturnedAtOnce()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 21;
            abilityPoints.constitution = 21;
            abilityPoints.dexterity = 21;
            abilityPoints.intelligence = 21;
            abilityPoints.strength = 21;
            abilityPoints.wisdom = 21;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Total of all ability points was not 60.\n" +
                    "Intelligence must be between 5 and 20.\n" +
                    "Wisdom must be between 5 and 20.\n" +
                    "Dexterity must be between 1 and 20.\n" +
                    "Strength must be between 1 and 20.\n" +
                    "Charisma must be between 0 and 20.\n" +
                    "Constitution must be between 10 and 20.\n");
            }
        }

        [Test]
        public void headRoundnessOver100ThrowsError()
        {

            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 10;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 10;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 10;
            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(101, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Unable to create character headShape should be between 0 and 100.\n");
            }

        }
        [Test]
        public void headRoundnessUnder0ThrowsError()
        {
            AbilityPoints abilityPoints = new Characters.AbilityPoints();

            abilityPoints.charisma = 10;
            abilityPoints.constitution = 10;
            abilityPoints.dexterity = 10;
            abilityPoints.intelligence = 10;
            abilityPoints.strength = 10;
            abilityPoints.wisdom = 10;

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(-1, Characters.FitnessLevel.extremely, 60, abilityPoints);
            }

            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Unable to create character headShape should be between 0 and 100.\n");
            }

        }
    }
}
