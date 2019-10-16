using ListsLogicAndIterations.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Tests
{
	/*
	 * Class that is tested: Code/Arrays.cs
	 * 
	 * These tests are considered "expected behaviour" and it is your goal to make the class return what is expected.
	 * 
	 * Currently this class does not function and throws exceptions - implement all the static methods so they work.
	 * You will know what you have done works when you run all the tests and they all pass.
	 */
	[TestClass]
	public class Arrays_Tests
	{
		[TestMethod]
		public void BuildIntArray_ShouldReturnArray()
		{
			var actual = Arrays.BuildIntArray(1, 3);

			Assert.AreEqual(2, actual.Length);
			Assert.AreEqual(1, actual.First());
			Assert.AreEqual(3, actual.Last());
		}

		[TestMethod]
		public void GetArrayValue_ShouldReturnFirstValue()
		{
			var actual = Arrays.GetArrayValue(new List<int> {1,2,3}.ToArray(), 0);

			Assert.AreEqual(1, actual);
		}

		[TestMethod]
		public void GetArrayValue_ShouldReturnLastValue()
		{
			var actual = Arrays.GetArrayValue(new List<int> { 1, 2, 3 }.ToArray(), 2);

			Assert.AreEqual(3, actual);
		}

		[TestMethod]
		public void GetArrayValue_ShouldDefaultToZero_WhenPositionToHigh()
		{
			var actual = Arrays.GetArrayValue(new List<int> { 1, 2, 3 }.ToArray(), 3);

			Assert.AreEqual(0, actual);
		}

		[TestMethod]
		public void GetArrayValue_ShouldDefaultToZero_WhenPositionToLow()
		{
			var actual = Arrays.GetArrayValue(new List<int> { 1, 2, 3 }.ToArray(), -1);

			Assert.AreEqual(0, actual);
		}
	}
}