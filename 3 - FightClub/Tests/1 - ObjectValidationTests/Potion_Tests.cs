using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProblems.Code;
using ObjectOrientedProblems.Code.Enums;

namespace ObjectOrientedProblems.Tests.ObjectValidationTests
{
	[TestClass]
	public class Potion_Tests
	{
		[TestMethod]
		public void PurchasePotion_ShouldReturnObjectWithDefaultValues()
		{
			var potion = FightClubGame.PurchasePotion();

			Assert.AreEqual(2, potion.Healing);
			Assert.AreEqual(PotionType.Basic, potion.Type);
		}

		[TestMethod]
		public void Potion_ShouldSupportBasicType()
		{
			var potion = FightClubGame.PurchasePotion();

			potion.SetType(PotionType.Basic);

			Assert.AreEqual(2, potion.Healing);
			Assert.AreEqual(PotionType.Basic, potion.Type);
		}

		[TestMethod]
		public void Potion_ShouldSupportGreaterType()
		{
			var potion = FightClubGame.PurchasePotion();

			potion.SetType(PotionType.Greater);

			Assert.AreEqual(5, potion.Healing);
			Assert.AreEqual(PotionType.Greater, potion.Type);
		}
	}
}