using ObjectOrientedProblems.Code.Interfaces;
using System;
using ObjectOrientedProblems.Tests.ObjectValidationTests;

namespace ObjectOrientedProblems.Code
{

	public static class FightClubGame
	{
		public static IPowerUp PurchasePowerUp()
        {
            return new Juice();
            // throw new NotImplementedException();
        }

        public static IPotion PurchasePotion()
		{
			throw new NotImplementedException();
		}

		public static IFighter HireFighter()
		{
			throw new NotImplementedException();
		}
	}
}