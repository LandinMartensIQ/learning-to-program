using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using Characters;

namespace Tests
{
    class CharacterSaveLoadTests
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
        //public void successfulCharacterSave()
        //{
        //    var myChar = defaultCharacter();
        //    var response=DiskOperations.Character.Save(myChar);
        //    Assert.IsTrue(response);

        //}

        //[Test]
        //public void successfulCharacterLoad()
        //{
        //    var myChar = defaultCharacter();
        //    var response = DiskOperations.Character.Save(myChar);
        //    var loadedCharacter = DiskOperations.Character.Load();

        //    Assert.IsNotNull(loadedCharacter);
        //}

        //[Test]
        //public void verifySavedCharacterStatsAreLoaded()
        //{
        //    var myAttributes = defaultAbilityPoints();
        //    myAttributes.charisma = 9;
        //    myAttributes.intelligence = 11;
        //    var myChar = new Characters.CharacterBuilder().BuildCharacter(50, FitnessLevel.not, 13, myAttributes);
        //    var response = DiskOperations.Character.Save(myChar);
        //    var loadedCharacter = DiskOperations.Character.Load();

        //    Assert.IsNotNull(loadedCharacter);
        //    Assert.AreEqual(myAttributes, myChar.AbilityStats);
        //    Assert.AreEqual("1'1", myChar.stringHeight);
        //    Assert.AreEqual(50, myChar.headShape);
        //    Assert.AreEqual(FitnessLevel.not, myChar.fitnessLevel);
        //}

    }
}
