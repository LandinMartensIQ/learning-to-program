using FightClub.Code;
using ObjectOrientedProblems.Code.Interfaces;
using System;

namespace ObjectOrientedProblems.Code
{
	public static class FightClubGame
	{
		public static IPowerUp PurchasePowerUp() => new ClassImplementsIPowerUp();

        public static IPotion PurchasePotion() => new ClassImplementsIPotion();

        public static IFighter HireFighter() => new ClassImplementsIFighter();
    }
}