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

        public override AbilityNames AbilityName => AbilityNames.Intelligence;
        public override int Max => 20;
        public override int Min => 5;

        public Intelligence(int value)
        {

            Value = value;
        }

    }


}
