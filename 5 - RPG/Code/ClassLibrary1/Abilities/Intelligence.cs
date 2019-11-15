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

    public class Intelligence:AbilityPoints
    {

        public Intelligence(int value)
        {
            AbilityName = "Intelligence";
            Max = 20;
            Min = 5;
            Value = value;
        }

    }


}
