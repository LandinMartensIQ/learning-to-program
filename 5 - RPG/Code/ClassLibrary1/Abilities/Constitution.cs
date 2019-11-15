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

    public class Constitution : AbilityPoints
    {

        public Constitution(int value)
        {
            AbilityName = "Constitution";
            Max = 20;
            Min = 10;
            Value = value;
        }

    }


}
