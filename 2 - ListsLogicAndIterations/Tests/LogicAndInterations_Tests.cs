using ListsLogicAndIterations.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Tests
{
	/*
	 * Class that is tested: Code/LogicAndInterations.cs
	 * 
	 * I know tests should not expect a certain implementation...but I am testing you , not the code haha!
	 * 
	 * These tests are considered "expected behaviour & Implementation" and it is your goal to make the class return what is expected.
	 * 
	 * Currently this class does not function and throws exceptions - implement all the static methods so they work.
	 * You will know what you have done works when you run all the tests and they all pass.
	 */
	[TestClass]
	public class LogicAndInterations_Tests
	{
		[TestMethod]
		public void For_SumTwoListsAndAllValueThatAreNotFour_ShouldEqual9()
		{
			// Arrange
            var array = new int[] { 4, 1, 2 };
			var list = new List<int> { 1, 2, 3 };
			var expected = 9;

            // Act 
			var actual = LogicAndInterations.For_SumTwoListsAndAllValueThatAreNotFour(array, list);


            // Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ForEach_SumTwoListsAndAllValueThatAreNotFour_ShouldEqual9()
		{
			var list = new List<int> { 4, 1, 2, 3 };
			var expected = 6;

			var actual = LogicAndInterations.ForEach_SumTwoListsAndAllValueThatAreNotFour(list);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop_ShouldStopAfterOnePass()
		{
			var list = new List<int> { 4, 1, 2, 3 };
			var expected = 4;

			var actual = LogicAndInterations.DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(list);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop_ShouldNotStopUntilLastValue()
		{
			var list = new List<int> { 1, 2, 3, 4 };
			var expected = 10;

			var actual = LogicAndInterations.DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(list);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop_ShouldFinishAllIterations()
		{
			var list = new List<int> { 1, 2, 3 };
			var expected = 6;

			var actual = LogicAndInterations.DoWhile_SumValuesWhileCurrentValueIsNot4_ThenStop(list);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void While_SumValuesWhileCurrentValueIsNot4_ThenStop_ShouldStopAfterOnePass()
		{
			var list = new List<int> { 4, 1, 2, 3 };
			var expected = 4;

			var actual = LogicAndInterations.While_SumValuesWhileCurrentValueIsNot4_ThenStop(list);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void While_SumValuesWhileCurrentValueIsNot4_ThenStop_ShouldNotStopUntilLastValue()
		{
			var list = new List<int> { 1, 2, 3, 4 };
			var expected = 10;

			var actual = LogicAndInterations.While_SumValuesWhileCurrentValueIsNot4_ThenStop(list);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void While_SumValuesWhileCurrentValueIsNot4_ThenStop_ShouldFinishAllIterations()
		{
			var list = new List<int> { 1, 2, 3 };
			var expected = 6;

			var actual = LogicAndInterations.While_SumValuesWhileCurrentValueIsNot4_ThenStop(list);

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Linq_SumTwoListsAndAllValueThatAreNotFour_ShouldSumAllValues()
		{
			var list = new List<int> { 4, 1, 2, 3 };
			var expected = 6;

			var actual = LogicAndInterations.Linq_SumTwoListsAndAllValueThatAreNotFour(list);

			Assert.AreEqual(expected, actual);
		}
	}
}