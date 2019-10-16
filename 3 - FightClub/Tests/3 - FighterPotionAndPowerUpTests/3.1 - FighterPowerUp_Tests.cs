using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProblems.Code;

namespace ObjectOrientedProblems.Tests.FighterItemInterationTests
{
	[TestClass]
	public class FighterPowerUp_Tests
	{
		[TestMethod]
		public void PowerUp_ShouldIncreasePower()
		{
			var fighter = FightClubGame.HireFighter();
			var powerUp = FightClubGame.PurchasePowerUp();

			powerUp.DamageBuff = 5;

			fighter.PowerUp(powerUp);

			Assert.AreEqual(6, fighter.Damage);
		}

		[TestMethod]
		public void PowerUp_ShouldNeverSetDamageBelowOne()
		{
			var fighter = FightClubGame.HireFighter();
			var powerUp = FightClubGame.PurchasePowerUp();

			powerUp.DamageBuff = -1;

			fighter.PowerUp(powerUp);

			Assert.AreEqual(1, fighter.Damage);
		}

		[TestMethod]
		public void PowerUp_ShouldReducePowerIfNegative()
		{
			var fighter = FightClubGame.HireFighter();
			var powerUp = FightClubGame.PurchasePowerUp();

			powerUp.DamageBuff = 1;

			fighter.PowerUp(powerUp);

			powerUp.DamageBuff = -1;

			fighter.PowerUp(powerUp);

			Assert.AreEqual(1, fighter.Damage);
		}
	}
}