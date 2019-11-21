using FightClub.Code.Objects;
using ObjectOrientedProblems.Code.Interfaces;

namespace ObjectOrientedProblems.Code
{

    public static class FightClubGame
    {
        public static IPowerUp PurchasePowerUp()
        {
            return new Juice();
        }

        public static IPotion PurchasePotion()
        {
            return new MagicDrink();
        }

        public static IFighter HireFighter()
        {
            return new Warrior();
        }
    }

}