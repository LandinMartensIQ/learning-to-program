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
        public override AbilityNames AbilityName => AbilityNames.Constitution;

        public override int Max => 20;
        public override int Min => 10;

        public Constitution(int value)
        {
            Value = value;
        }

    }


}
