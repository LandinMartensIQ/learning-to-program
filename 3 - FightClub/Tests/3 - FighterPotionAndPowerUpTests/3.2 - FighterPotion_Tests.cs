using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProblems.Code;
using ObjectOrientedProblems.Code.Enums;

namespace ObjectOrientedProblems.Tests.FighterItemInterationTests
{
	[TestClass]
	public class Fighter_PotionInteration_Tests
	{
		[TestMethod]
		public void DrinkPotion_ShouldNotChangeHealth_WhenHealthIsMax()
		{
			var fighter = FightClubGame.HireFighter();
			var potion = FightClubGame.PurchasePotion();

			fighter.DrinkPotion(potion);

			Assert.AreEqual(10, fighter.Health);
		}

		[TestMethod]
		public void DrinkPotion_ShouldNeverHealBeyondMaxHealth()
		{
			var fighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();
			var potion = FightClubGame.PurchasePotion();

			fighter.TakeDamage(secondFighter);
			fighter.DrinkPotion(potion);

			Assert.AreEqual(10, fighter.Health);
		}

		[TestMethod]
		public void DrinkPotion_ShouldIncreaseHealthBasedUponValueOfPotion_WhenNewValueIsNotBeyondMaximum()
		{
			var fighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();
			var potion = FightClubGame.PurchasePotion();

			for (int i = 1; i <= 5; i++)
			{
				fighter.TakeDamage(secondFighter);
			}

			fighter.DrinkPotion(potion);

			Assert.AreEqual(7, fighter.Health);
		}

		[TestMethod]
		public void DrinkPotion_ShouldNotHeal_WhenHealthIsZero()
		{
			var fighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();
			var potion = FightClubGame.PurchasePotion();

			for (int i = 1; i <= 100; i++)
			{
				fighter.TakeDamage(secondFighter);
			}

			fighter.DrinkPotion(potion);

			Assert.AreEqual(0, fighter.Health);
		}

		[TestMethod]
		public void DrinkPotion_ShouldSetStateToHealthy_WhenHealthHitsMaximum()
		{
			var fighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();
			var potion = FightClubGame.PurchasePotion();

			fighter.TakeDamage(secondFighter);
			fighter.DrinkPotion(potion);

			Assert.AreEqual(FighterState.Healthy, fighter.State);
		}

		[TestMethod]
		public void DrinkPotion_ShouldSetStateToHurtFromKnockedOut()
		{
			var fighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();
			var potion = FightClubGame.PurchasePotion();

			for (int i = 1; i <= 9; i++)
			{
				fighter.TakeDamage(secondFighter);
			}

			fighter.DrinkPotion(potion);

			Assert.AreEqual(FighterState.Hurt, fighter.State);
		}

		[TestMethod]
		public void DrinkPotion_ShouldNotChangeState_WhenHealthIsZero()
		{
			var fighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();
			var potion = FightClubGame.PurchasePotion();

			for (int i = 1; i <= 100; i++)
			{
				fighter.TakeDamage(secondFighter);
			}

			fighter.DrinkPotion(potion);

			Assert.AreEqual(FighterState.Dead, fighter.State);
		}
	}
}