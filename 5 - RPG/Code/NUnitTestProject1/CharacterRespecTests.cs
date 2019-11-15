using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using Characters;

namespace Tests
{
    class CharacterRespecTests
    {

        //public Character defaultCharacter()
        //{
        //    AbilityPoints abilityPoints = defaultAbilityPoints();
        //    return new Characters.CharacterBuilder().BuildCharacter(100, Characters.FitnessLevel.extremely, 60, abilityPoints);
        //}
        //public AbilityPoints defaultAbilityPoints()
        //{
        //    AbilityPoints abilityPoints = new Characters.AbilityPoints();

        //    abilityPoints.charisma = 10;
        //    abilityPoints.constitution = 10;
        //    abilityPoints.dexterity = 10;
        //    abilityPoints.intelligence = 10;
        //    abilityPoints.strength = 10;
        //    abilityPoints.wisdom = 10;

        //    return abilityPoints;
        //}

        //[Test]
        //public void successfulCharacterRespec()
        //{
        //    var myChar = defaultCharacter();

        //    AbilityPoints abilityPoints = defaultAbilityPoints();
        //    abilityPoints.charisma = 11;
        //    abilityPoints.dexterity = 9;

        //    var modifiedChar = new CharacterBuilder().ReSpec(myChar, abilityPoints);

        //    Assert.IsTrue(modifiedChar.AbilityStats.charisma == 11);
        //    Assert.IsTrue(modifiedChar.AbilityStats.constitution == 10);
        //    Assert.IsTrue(modifiedChar.AbilityStats.dexterity == 9);
        //    Assert.IsTrue(modifiedChar.AbilityStats.intelligence == 10);
        //    Assert.IsTrue(modifiedChar.AbilityStats.strength == 10);
        //    Assert.IsTrue(modifiedChar.AbilityStats.wisdom == 10);

        //    Assert.IsTrue(modifiedChar.fitnessLevel == Characters.FitnessLevel.extremely);
        //    Assert.IsTrue(modifiedChar.headShape == 100);
        //    Assert.IsTrue(modifiedChar.stringHeight == "5'");

        //}
    }
}
