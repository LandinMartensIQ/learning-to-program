using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProblems.Code;

namespace ObjectOrientedProblems.Tests.ObjectValidationTests
{
	[TestClass]
	public class PowerUp_Tests
	{
		[TestMethod]
		public void PurchasePowerUp_ShouldReturnObjectWithDefaultValues()
		{
			var powerUp = FightClubGame.PurchasePowerUp();

			Assert.AreEqual(1, powerUp.DamageBuff);
		}

		[TestMethod]
		public void PowerUp_ShouldAllowExternalPropertyChanges()
		{
			var powerUp = FightClubGame.PurchasePowerUp();

			powerUp.DamageBuff = 5;

			Assert.AreEqual(5, powerUp.DamageBuff);
		}
	}
}