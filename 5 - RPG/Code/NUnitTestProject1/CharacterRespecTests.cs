using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using Characters;

namespace Tests
{
    class CharacterRespecTests
    {

        public Character defaultCharacter()
        {
            List<AbilityPoints> abilityPoints = defaultAbilityPoints();
            return new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.Extremely, 60, abilityPoints);
        }
        public List<AbilityPoints> defaultAbilityPoints()
        {
            List<AbilityPoints> abilityPoints = new List<AbilityPoints>();

            abilityPoints.Add(new Charisma(10));
            abilityPoints.Add(new Constitution(10));
            abilityPoints.Add(new Dexterity(10));
            abilityPoints.Add(new Intelligence(10));
            abilityPoints.Add(new Strength(10));
            abilityPoints.Add(new Wisdom(10));

            return abilityPoints;
        }

        [Test]
        public void successfulCharacterRespec()
        {
            var myChar = defaultCharacter();

            List<AbilityPoints> abilityPoints = defaultAbilityPoints();

            abilityPoints.Find(x=>x.AbilityName.Equals(AbilityNames.Charisma)).Value=11;
            abilityPoints.Find(x => x.AbilityName.Equals(AbilityNames.Dexterity)).Value = 9;

            var modifiedChar = new CharacterBuilder().ReSpec(myChar, abilityPoints);

            Assert.IsTrue(modifiedChar.getAbilityValue(AbilityNames.Charisma) == 11);
            Assert.IsTrue(modifiedChar.getAbilityValue(AbilityNames.Constitution) == 10);
            Assert.IsTrue(modifiedChar.getAbilityValue(AbilityNames.Dexterity) == 9);
            Assert.IsTrue(modifiedChar.getAbilityValue(AbilityNames.Intelligence) == 10);
            Assert.IsTrue(modifiedChar.getAbilityValue(AbilityNames.Strength) == 10);
            Assert.IsTrue(modifiedChar.getAbilityValue(AbilityNames.Wisdom) == 10);

            Assert.IsTrue(modifiedChar.FitnessLevel == Characters.FitnessLevel.Extremely);
            Assert.IsTrue(modifiedChar.HeadShape == 100);
            Assert.IsTrue(modifiedChar.Height == "5'");

        }

        [Test]
        public void CharacterRespecThrowsErrorOnInvalidStat()
        {
            var myChar = defaultCharacter();

            List<AbilityPoints> abilityPoints = defaultAbilityPoints();

            abilityPoints.Find(x => x.AbilityName.Equals(AbilityNames.Constitution)).Value = 9;
            abilityPoints.Find(x => x.AbilityName.Equals(AbilityNames.Dexterity)).Value = 11;
            try
            {
                var modifiedChar = new CharacterBuilder().ReSpec(myChar, abilityPoints);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e.Message.Equals("Constitution was below the minimum of 10\n"));
            }

        }
    }
}
