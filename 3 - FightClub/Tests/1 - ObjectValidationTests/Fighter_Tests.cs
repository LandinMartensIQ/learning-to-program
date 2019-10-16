using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectOrientedProblems.Code;
using ObjectOrientedProblems.Code.Enums;

namespace ObjectOrientedProblems.Tests.ObjectValidationTests
{
	[TestClass]
	public class Fighter_Tests
	{
		[TestMethod]
		public void HireFighter_ShouldReturnObjectWithDefaultValues()
		{
			var fighter = FightClubGame.HireFighter();

			Assert.AreEqual(1, fighter.Damage);
			Assert.AreEqual(10, fighter.Health);
			Assert.AreEqual(FighterState.Healthy, fighter.State);
		}
	}
}