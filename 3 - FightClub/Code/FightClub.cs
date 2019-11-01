using FightClub;
using FightClub.Code.Objects;
using ObjectOrientedProblems.Code.Interfaces;
using System;

namespace ObjectOrientedProblems.Code
{
	public static class FightClubGame
	{
		public static IPowerUp PurchasePowerUp()
		{
            return new Steroids();
        }

		public static IPotion PurchasePotion()
		{
            return new EnergyDrink();
		}

		public static IFighter HireFighter()
		{
            return new Boxer();
		}
	}
}