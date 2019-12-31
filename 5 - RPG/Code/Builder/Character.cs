using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Builder
{
    public class Character : ICharacter
    {
        public int HeadRoundness { get; private set; }
        public string FitnessLevel { get; private set; }
        public Height Height { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Dexterity { get; private set; }
        public int Strength { get; private set; }
        public int Charisma { get; private set; }
        public int Constitution { get; private set; }

        public Character(ValidateCharacter newCharacter)
        {
            HeadRoundness = newCharacter.HeadRoundness;
            FitnessLevel = newCharacter.FitnessLevel;
            Height = newCharacter.Height;
            Intelligence = newCharacter.Intelligence;
            Wisdom = newCharacter.Wisdom;
            Dexterity = newCharacter.Dexterity;
            Strength = newCharacter.Strength;
            Charisma = newCharacter.Charisma;
            Constitution = newCharacter.Constitution;
        }
    }


}
