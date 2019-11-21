using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code.Objects
{
    public class MagicDrink : IPotion
    {
        public int Healing
        {
            get
            {
                var healing = 0;

                switch (Type)
                {
                    case PotionType.Basic:
                        healing = 2;
                        break;
                    case PotionType.Greater:
                        healing = 5;
                        break;
                }
                return healing;
            }
            // set;
        }
        public PotionType Type { get; private set; }
        public void SetType(PotionType potionType)
        {
            Type = potionType;
        }

        public MagicDrink()
        {
        }
    }
}
