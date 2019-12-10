using System;
using NUnit.Framework;
using Characters;
using System.Collections.Generic;
using System.Linq;



namespace Tests
{
    public class CharacterCreationTests
    {

        public List<AbilityPoints> defaultabilityPoints()
        {
            var abilities = new List<AbilityPoints>();
            abilities.Add(new Charisma(10));
            abilities.Add(new Constitution(10));
            abilities.Add(new Dexterity(10));
            abilities.Add(new Intelligence(10));
            abilities.Add(new Strength(10));
            abilities.Add(new Wisdom(10));

            return abilities;
        }


        [Test]
        public void SuccessfulCharacterCreation()
        {
            var abilities = new List<AbilityPoints>();
            abilities.Add(new Charisma(10));
            abilities.Add(new Constitution(10));
            abilities.Add(new Dexterity(10));
            abilities.Add(new Intelligence(10));
            abilities.Add(new Strength(10));
            abilities.Add(new Wisdom(10));

            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.Extremely, 60, abilities);

            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Charisma) == 10);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Constitution) == 10);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Dexterity) == 10);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Intelligence) == 10);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Strength) == 10);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Wisdom) == 10);

            Assert.IsTrue(myChar.FitnessLevel == Characters.FitnessLevel.Extremely);
            Assert.IsTrue(myChar.HeadShape == 100);
            Assert.IsTrue(myChar.Height == "5'");

        }

        [Test]
        public void CharacterHeightUnderOneFoot()
        {



            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.Extremely, 11, defaultabilityPoints());

            Assert.IsTrue(myChar.Height == "11");
        }

        [Test]
        public void CharacterHeightOneFoot()
        {

            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.Extremely, 12, defaultabilityPoints());

            Assert.IsTrue(myChar.Height == "1'");
        }

        [Test]
        public void CharacterHeightOneFootEleven()
        {
            

            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.Somewhat, 23, defaultabilityPoints());

            Assert.IsTrue(myChar.Height == "1'11");
        }

        [Test]
        public void CorrectlyStoredAbilityPoints()
        {
            var abilities = new List<AbilityPoints>();
            abilities.Add(new Charisma(3));
            abilities.Add(new Constitution(12));
            abilities.Add(new Dexterity(7));
            abilities.Add(new Intelligence(11));
            abilities.Add(new Strength(13));
            abilities.Add(new Wisdom(14));


            var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.Extremely, 60, abilities);

            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Charisma) == 3);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Constitution) == 12);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Dexterity) == 7);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Intelligence) == 11);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Strength) == 13);
            Assert.IsTrue(myChar.getAbilityValue(AbilityNames.Wisdom) == 14);

            Assert.IsTrue(myChar.FitnessLevel == Characters.FitnessLevel.Extremely);
            Assert.IsTrue(myChar.HeadShape == 100);
            Assert.IsTrue(myChar.Height == "5'");

        }

        [Test]
        public void UnableToCreateCharacterWithInvalidAbilityScore()
        {

            var attributes = new List<AbilityPoints>();
            attributes.Add(new Charisma(22));

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.Extremely, 60, attributes);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Equals("Charisma was above the maximum of 20\nTotal of all ability points was not 60.\n"));
            }


        }

        [Test]
        public void CharismaOver20ThrowsError()
        {
            var charisma = new Charisma(21);

            Assert.AreEqual("Charisma was above the maximum of 20\n", charisma.GetValidationFailureMessage());
            
        }

        [Test]
        public void CharismaAt20Acceptable()
        {
            var charisma = new Charisma(20);

            Assert.IsTrue(charisma.IsValid());

        }

        [Test]
        public void CharismaAt0Acceptable()
        {
            var charisma = new Charisma(0);

            Assert.IsTrue(charisma.IsValid());

        }

        [Test]
        public void IntelligenceBelow5ThrowsError()
        {
            var intelligence = new Intelligence(4);

            Assert.AreEqual("Intelligence was below the minimum of 5\n", intelligence.GetValidationFailureMessage());

        }
        [Test]
        public void IntelligenceAbove20ThrowsError()
        {
            var intelligence = new Intelligence(21);

            Assert.AreEqual("Intelligence was above the maximum of 20\n", intelligence.GetValidationFailureMessage());

        }

        [Test]
        public void IntelligenceAt5Acceptable()
        {
            var intelligence = new Intelligence(5);

            Assert.IsTrue((intelligence.IsValid()));

        }
        [Test]
        public void IntelligenceAt20Acceptable()
        {
            var intelligence = new Intelligence(20);

            Assert.IsTrue((intelligence.IsValid()));

        }

        [Test]
        public void WisdomBelow5ThrowsError()
        {
            var wisdom = new Wisdom(4);

            Assert.AreEqual("Wisdom was below the minimum of 5\n", wisdom.GetValidationFailureMessage());

        }
        [Test]
        public void WisdomAbove20ThrowsError()
        {
            var wisdom = new Wisdom(21);

            Assert.AreEqual("Wisdom was above the maximum of 20\n", wisdom.GetValidationFailureMessage());

        }

        [Test]
        public void WisdomAt5Acceptable()
        {
            var wisdom = new Wisdom(5);

            Assert.IsTrue((wisdom.IsValid()));

        }
        [Test]
        public void WisdomAt20Acceptable()
        {
            var wisdom = new Wisdom(20);

            Assert.IsTrue((wisdom.IsValid()));

        }


        [Test]
        public void DexterityBelow1ThrowsError()
        {
            var dexterity = new Dexterity(0);

            Assert.AreEqual("Dexterity was below the minimum of 1\n", dexterity.GetValidationFailureMessage());

        }
        [Test]
        public void DexterityAbove20ThrowsError()
        {
            var dexterity = new Dexterity(21);

            Assert.AreEqual("Dexterity was above the maximum of 20\n", dexterity.GetValidationFailureMessage());

        }

        [Test]
        public void DexterityAt1Acceptable()
        {
            var dexterity = new Dexterity(1);

            Assert.IsTrue((dexterity.IsValid()));

        }
        [Test]
        public void DexterityAt20Acceptable()
        {
            var dexterity = new Dexterity(20);

            Assert.IsTrue((dexterity.IsValid()));

        }

        [Test]
        public void StrengthBelow1ThrowsError()
        {
            var att = new Strength(0);

            Assert.AreEqual("Strength was below the minimum of 1\n", att.GetValidationFailureMessage());

        }
        [Test]
        public void StrengthAbove20ThrowsError()
        {
            var att = new Strength(21);

            Assert.AreEqual("Strength was above the maximum of 20\n", att.GetValidationFailureMessage());

        }

        [Test]
        public void StrengthAt1Acceptable()
        {
            var att = new Strength(1);

            Assert.IsTrue((att.IsValid()));

        }
        [Test]
        public void StrengthAt20Acceptable()
        {
            var att = new Strength(20);

            Assert.IsTrue((att.IsValid()));

        }

        [Test]
        public void ConstitutionBelow10ThrowsError()
        {
            var att = new Constitution(9);

            Assert.AreEqual("Constitution was below the minimum of 10\n", att.GetValidationFailureMessage());

        }
        [Test]
        public void ConstitutionAbove20ThrowsError()
        {
            var att = new Constitution(21);

            Assert.AreEqual("Constitution was above the maximum of 20\n", att.GetValidationFailureMessage());

        }

        [Test]
        public void ConstitutionAt10Acceptable()
        {
            var att = new Constitution(10);

            Assert.IsTrue((att.IsValid()));

        }
        [Test]
        public void ConstitutionAt20Acceptable()
        {
            var att = new Constitution(20);

            Assert.IsTrue((att.IsValid()));

        }

        [Test]
        public void AllErrorsOnAbilityReturnedAtOnce()
        {
            var allAbilities = new List<AbilityPoints>();

            allAbilities.Add(new Charisma(21));
            allAbilities.Add(new Constitution(21));
            allAbilities.Add(new Dexterity(21));
            allAbilities.Add(new Intelligence(21));
            allAbilities.Add(new Strength(21));
            allAbilities.Add(new Wisdom(21));

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.Extremely, 60, allAbilities);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Charisma was above the maximum of 20\n" +
                    "Constitution was above the maximum of 20\n" +
                    "Dexterity was above the maximum of 20\n" +
                    "Intelligence was above the maximum of 20\n" +
                    "Strength was above the maximum of 20\n" +
                    "Wisdom was above the maximum of 20\n" +
                    "Total of all ability points was not 60.\n");
            }
        }


        [Test]
        public void HeadRoundnessOver100ThrowsError()
        {

            
            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(101, Characters.FitnessLevel.Extremely, 60, defaultabilityPoints());
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Unable to create character headShape should be between 0 and 100.\n");
            }

        }


        [Test]
        public void HeadRoundnessUnder0ThrowsError()
        {
          
            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(-1, Characters.FitnessLevel.Extremely, 60, defaultabilityPoints());
            }

            catch (Exception e)
            {
                Assert.IsTrue(e.Message == "Unable to create character headShape should be between 0 and 100.\n");
            }

        }

        //[Test]
        //public void UnabletoRetriveUnknownAbility()
        //{

        //    var myChar = new Characters.CharacterBuilder().BuildCharacter(10, Characters.FitnessLevel.Extremely, 60, defaultabilityPoints());

        //    Assert.AreEqual(-1,myChar.getAbilityValue(AbilityNames.Stupidness));
        //}

        [Test]
        public void UnabletoAddMultipleOfSameAbility()
        {

            var abils = defaultabilityPoints();
            abils.RemoveAt(0);
            abils.Add(new Wisdom(10));

            try
            {
                var myChar = new Characters.CharacterBuilder().BuildCharacter(10, Characters.FitnessLevel.Extremely, 60, abils);
            }
            catch (Exception e)
            {
                Assert.AreEqual($"Wisdom has multiple entries please only include one.\n", e.Message);
            }
            

        }

    }
}
