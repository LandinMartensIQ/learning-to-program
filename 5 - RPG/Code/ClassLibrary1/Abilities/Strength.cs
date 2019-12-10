using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{

    //    public int intelligence;
    //    public int wisdom;
    //    public int dexterity;
    //    public int strength;
    //    public int charisma;
    //    public int constitution;

    public class Strength : AbilityPoints
    {

        public override AbilityNames AbilityName => AbilityNames.Strength;
        public override int Max => 20;
        public override int Min => 1;
        public Strength(int value)
        {

            Value = value;
        }

    }


}
