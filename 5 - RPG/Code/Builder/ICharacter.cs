using System;

namespace Builder
{
    interface ICharacter
    {
         int HeadRoundness { get;}
         string FitnessLevel { get;}
         Height Height { get;}
         int Intelligence { get;}
         int Wisdom { get;}
         int Dexterity { get;}
         int Strength { get;}
         int Charisma { get;}
         int Constitution { get; }
    }
}
