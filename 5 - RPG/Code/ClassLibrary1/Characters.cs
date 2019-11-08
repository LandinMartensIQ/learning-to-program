using System;
using System.Collections.Generic;

namespace Characters
{

    public enum FitnessLevel { extremely, very, somewhat, not, farfrom }
    public struct AbilityPoints
    {
        public int intelligence;
        public int wisdom;
        public int dexterity;
        public int strength;
        public int charisma;
        public int constitution;
    }


    public class Character
    {
       
        public int headShape { get; }
        public FitnessLevel fitnessLevel { get; }
        public string stringHeight { get; }
        public AbilityPoints AbilityStats { get; }
        
        public Character(int head,FitnessLevel fit, string height, AbilityPoints stats)
        {
            headShape = head;
            fitnessLevel = fit;
            stringHeight = height;
            AbilityStats = stats;
        }
        
    }

    public class CharacterBuilder
    {

        private struct returnValues
        {
            public bool valid;
            public string errorMessage;
        }

        public Character BuildCharacter(int head, FitnessLevel fit, int heightInInches, AbilityPoints distributedPoints)
        {

            if (head < 0 || head > 100)
            {
                throw new Exception("Unable to create character headShape should be between 0 and 100.\n");
            }

            returnValues abilityCheck = validateAbilityPoints(distributedPoints);
            if (!abilityCheck.valid)
            {
                throw new Exception(abilityCheck.errorMessage);
            }

            var height = convertInchestoFeetAndInchString(heightInInches);
            var newCharacter = new Character(head, fit, height, distributedPoints);

            return newCharacter;
        }


        private returnValues validateAbilityPoints(AbilityPoints points)
        {
            returnValues returnValue = new returnValues();
            returnValue.valid = true;

            if (points.intelligence + points.wisdom + points.dexterity + points.strength + points.charisma + points.constitution != 60)
            {
                returnValue.valid = false;
                returnValue.errorMessage += "Total of all ability points was not 60.\n";
            }
            if (points.intelligence < 5 || points.intelligence > 20)
            {
                returnValue.valid = false;
                returnValue.errorMessage += "Intelligence must be between 5 and 20.\n";
            }
            if (points.wisdom < 5 || points.wisdom > 20)
            {
                returnValue.valid = false;
                returnValue.errorMessage += "Wisdom must be between 5 and 20.\n";
            }
            if (points.dexterity < 1 || points.dexterity > 20)
            {
                returnValue.valid = false;
                returnValue.errorMessage += "Dexterity must be between 1 and 20.\n";
            }
            if (points.strength < 1 || points.strength > 20)
            {
                returnValue.valid = false;
                returnValue.errorMessage += "Strength must be between 1 and 20.\n";
            }
            if (points.charisma < 0 || points.charisma > 20)
            {
                returnValue.valid = false;
                returnValue.errorMessage += "Charisma must be between 0 and 20.\n";
            }
            if (points.constitution < 10 || points.constitution > 20)
            {
                returnValue.valid = false;
                returnValue.errorMessage += "Constitution must be between 10 and 20.\n";
            }
            return returnValue;
        }

        private string convertInchestoFeetAndInchString(int inches)
        {
            //may need to account for negatives later, but not listed as a requirement
            var returnValue = "";
            var inchRemainder = 0;
            var feet = Math.DivRem(inches, 12, out inchRemainder);

            if (feet > 0)
            {
                returnValue += feet.ToString() + "'";
            }

            if (inchRemainder > 0)
            {
                returnValue += inchRemainder.ToString();
            }

            return returnValue;
        }

    }
   
}
