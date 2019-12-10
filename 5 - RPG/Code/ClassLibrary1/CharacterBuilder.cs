using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    public class CharacterBuilder
    {


        public Character BuildCharacter(int head, FitnessLevel fit, int heightInInches, List<AbilityPoints> distributedPoints)
        {

            
            Dictionary<AbilityNames, AbilityPoints> validatedAbilities = new Dictionary<AbilityNames, AbilityPoints>();

            if (head < 0 || head > 100)
            {
                throw new Exception("Unable to create character headShape should be between 0 and 100.\n");
            }

            var errors = CheckForErrorsOnAbilityValues(distributedPoints);

            if (string.IsNullOrEmpty(errors))
            {
                validatedAbilities = distributedPoints.ToDictionary(k => k.AbilityName, a => a);
            }
            else
            {
                throw new Exception(errors);
            }

            var height = Utilities.ConvertInchestoFeetAndInchString(heightInInches);
            var newCharacter = new Character(head, fit, height, validatedAbilities);

            return newCharacter;
        }


        private string CheckForErrorsOnAbilityValues (List<AbilityPoints> distributedPoints)
        {
            int expectedAbilityPointTotal = 60;

            string errormessages = "";

            if (distributedPoints.All(x => x.IsValid()))
            {
                var test = distributedPoints.GroupBy(x => x.AbilityName).Where(g => g.Count() > 1).ToList();
                if (test.Count() > 0)
                {
                    errormessages += $"{test.First().Key} has multiple entries please only include one.\n";
                }
 
            }
            else
            {
                errormessages += distributedPoints.Aggregate("", (current, next) => current + next.GetValidationFailureMessage());
            }


            if (distributedPoints.Sum(x => x.Value) != expectedAbilityPointTotal)

            {
                errormessages += $"Total of all ability points was not {expectedAbilityPointTotal}.\n";
            }

            if (!string.IsNullOrEmpty(errormessages))
            {
                throw new Exception(errormessages);
            }
            return errormessages;

        }

        public Character ReSpec(Character currentCharacter, List<AbilityPoints> distributedPoints)
        {

            Dictionary<AbilityNames, AbilityPoints> validatedAbilities = new Dictionary<AbilityNames, AbilityPoints>();
            var errors = CheckForErrorsOnAbilityValues(distributedPoints);

            if (string.IsNullOrEmpty(errors))
            {
                validatedAbilities = distributedPoints.ToDictionary(k => k.AbilityName, a => a);
            }
            else
            {
                throw new Exception(errors);
            }

            return new Character(currentCharacter.HeadShape, currentCharacter.FitnessLevel,
                currentCharacter.Height, validatedAbilities);

        }

    }
}
