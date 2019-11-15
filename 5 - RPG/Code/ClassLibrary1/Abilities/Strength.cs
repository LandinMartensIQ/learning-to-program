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

        public Strength(int value)
        {
            AbilityName = "Strength";
            Max = 20;
            Min = 1;
            Value = value;
        }

    }


}
