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

    public class Wisdom:AbilityPoints
    {

        public Wisdom(int value)
        {
            AbilityName = "Wisdom";
            Max = 20;
            Min = 5;
            Value = value;
        }

    }


}
