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

    public class Dexterity : AbilityPoints
    {
        public override AbilityNames AbilityName => AbilityNames.Dexterity;
        public override int Max => 20;
        public override int Min => 1;

        public Dexterity(int value)
        {
 
            Value = value;
        }

    }


}
