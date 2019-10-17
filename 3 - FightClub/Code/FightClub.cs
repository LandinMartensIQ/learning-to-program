using FightClub.Code.Objects;
using ObjectOrientedProblems.Code.Interfaces;
using System;

namespace ObjectOrientedProblems.Code
{
	public static class FightClubGame
	{
		public static IPowerUp PurchasePowerUp()
		{			            
            return new PowerUp(); 
            
		}

		public static IPotion PurchasePotion()
		{
            return new Potion();
		}

		public static IFighter HireFighter()
		{
            return new Fighter();
		}
	}
}