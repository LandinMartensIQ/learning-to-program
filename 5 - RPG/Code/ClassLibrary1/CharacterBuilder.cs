using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    public class CharacterBuilder
    {


            public Character BuildCharacter(int head, FitnessLevel fit, int heightInInches, List<AbilityPoints> distributedPoints)
            {

            int expectedAbilityPointTotal = 60;

                if (head < 0 || head > 100)
                {
                    throw new Exception("Unable to create character headShape should be between 0 and 100.\n");
                }

                Dictionary<string, AbilityPoints> validatedAbilities = new Dictionary<string, AbilityPoints>();

                string errormessages = "";
                var total = 0;
                foreach (AbilityPoints ability in distributedPoints)
                {
                    total += ability.Value;
                    errormessages += ability.Validate();
                    if (validatedAbilities.ContainsKey(ability.AbilityName))
                    {
                        errormessages += $"{ability.AbilityName} already added when asked to add it again";
                    }
                    else
                    {
                        validatedAbilities.Add(ability.AbilityName, ability);
                    }                    

                }

                if (total != expectedAbilityPointTotal)

                {
                    errormessages += $"Total of all ability points was not {expectedAbilityPointTotal}.\n";
                }

                if (!string.IsNullOrEmpty(errormessages))
                {
                    throw new Exception(errormessages);
                }

                var height = Utilities.convertInchestoFeetAndInchString(heightInInches);
                var newCharacter = new Character(head, fit, height, validatedAbilities);

                return newCharacter;
            }

    }
}
