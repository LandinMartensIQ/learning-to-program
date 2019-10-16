using ListsLogicAndIterations.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Tests
{
	/*
	 * Class that is tested: Code/Lists.cs
	 * 
	 * These tests are considered "expected behaviour" and it is your goal to make the class return what is expected.
	 * 
	 * Currently this class does not function and throws exceptions - implement all the static methods so they work.
	 * You will know what you have done works when you run all the tests and they all pass.
	 */
	[TestClass]
	public class Lists_Test
	{
		[TestMethod]
		public void BuildList_ShouldBuildList()
		{
			var actual = Lists.BuildList(1, 3);

			Assert.AreEqual(2, actual.Count);
			Assert.AreEqual(1, actual.First());
			Assert.AreEqual(3, actual.Last());
		}

		[TestMethod]
		public void GetValue_ShouldReturnFirstValue()
		{
			var actual = Lists.GetValue(new List<decimal> {1,2,3}, 0);

			Assert.AreEqual(1, actual);
		}

		[TestMethod]
		public void GetValue_ShouldReturnLastValue()
		{
			var actual = Lists.GetValue(new List<decimal> { 1, 2, 3 }, 2);

			Assert.AreEqual(3, actual);
		}

		[TestMethod]
		public void GetValue_ShouldDefaultToZero_WhenPositionToHigh()
		{
			var actual = Lists.GetValue(new List<decimal> { 1, 2, 3 }, 3);

			Assert.AreEqual(0, actual);
		}

		[TestMethod]
		public void GetValue_ShouldDefaultToZero_WhenPositionToLow()
		{
			var actual = Lists.GetValue(new List<decimal> { 1, 2, 3 }, -1);

			Assert.AreEqual(0, actual);
		}

		[TestMethod]
		public void AddValue_ShouldAdd()
		{
			var list = new List<decimal> { 1, 2, 3 };

			Lists.AddValue(list, -1);

			Assert.AreEqual(-1, list.Last());
		}

		[TestMethod]
		public void AddValue_ShouldAddMultipleValues()
		{
			var list = new List<decimal> { 1, 2, 3 };

			Lists.AddValue(list, new List<decimal> { -1 });

			Assert.AreEqual(-1, list.Last());
		}

		[TestMethod]
		public void RemoveValue_ShouldRemoveValue()
		{
			var list = new List<decimal> { 1, 2, 3 };

			Lists.RemoveValue(list, 3);

			Assert.AreEqual(2, list.Last());
		}

		[TestMethod]
		public void RemoveValue_ShouldNotFail_WhenValueToRemoveDoesNotExist()
		{
			var list = new List<decimal> { 1, 2, 3 };

			Lists.RemoveValue(list, 4);

			Assert.AreEqual(3, list.Last());
		}
	}
}