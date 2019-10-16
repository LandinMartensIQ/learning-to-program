using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProblems.Code;
using ObjectOrientedProblems.Code.Enums;

namespace ObjectOrientedProblems.Tests.BasicFighterTests
{
	[TestClass]
	public class BasicFighter_Tests
	{
		[TestMethod]
		public void TakeDamage_ShouldReduceHealthByFightersDamage()
		{
			var firstFighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();

			firstFighter.TakeDamage(secondFighter);

			Assert.AreEqual(9, firstFighter.Health);
			Assert.AreEqual(10, secondFighter.Health);
		}

		[TestMethod]
		public void TakeDamage_ShouldNotDropHealthBelowZero()
		{
			var firstFighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();

			for (int i = 0; i < 100; i++)
			{
				firstFighter.TakeDamage(secondFighter);
			}

			Assert.AreEqual(0, firstFighter.Health);
		}

		[TestMethod]
		public void TakeDamage_WillSetStateToHurt_WhenHealthIsTwoToAndIncludingTen()
		{
			var firstFighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();

			for (int i = 1; i <= 8; i++)
			{
				firstFighter.TakeDamage(secondFighter);

				Assert.AreEqual(FighterState.Hurt, firstFighter.State);
			}
		}

		[TestMethod]
		public void TakeDamage_WillSetStateToKnockedOut_WhenHealthIsOne()
		{
			var firstFighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();

			for (int i = 1; i <= 9; i++)
			{
				firstFighter.TakeDamage(secondFighter);
			}

			Assert.AreEqual(FighterState.KnockedOut, firstFighter.State);
		}

		[TestMethod]
		public void TakeDamage_WillSetStateToDead_WhenHealthIsZero()
		{
			var firstFighter = FightClubGame.HireFighter();
			var secondFighter = FightClubGame.HireFighter();

			for (int i = 1; i <= 10; i++)
			{
				firstFighter.TakeDamage(secondFighter);
			}

			Assert.AreEqual(FighterState.Dead, firstFighter.State);
		}
	}
}