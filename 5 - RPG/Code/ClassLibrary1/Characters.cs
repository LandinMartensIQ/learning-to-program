using System;
using System.Collections.Generic;

namespace Characters
{

    public enum FitnessLevel { Extremely, Very, Somewhat, Not, FarFrom }

    public class Character
    {
       
        public int HeadShape { get; }
        public FitnessLevel FitnessLevel { get; }
        public string Height { get; }
        private Dictionary<string, AbilityPoints> Abilities { get; set; }

        //private Dictionary<string, AbilityPoints> _abilities;

        public Character(int head,FitnessLevel fit, string height, Dictionary<string, AbilityPoints> stats)
        {
            HeadShape = head;
            FitnessLevel = fit;
            Height = height;
            Abilities = stats;
        }

        public int getAbilityValue(string abilityName)
        {
            try
            {
                return Abilities.GetValueOrDefault(abilityName).Value;
            }
            catch
            {
                return -1;
            }
        }
        
    }

   
}
