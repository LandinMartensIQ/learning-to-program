using ListsLogicAndIterations.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsLogicAndIterations.Tests
{
	/*
	 * Class that is tested: Code/Dictionarys.cs
	 * 
	 * These tests are considered "expected behaviour" and it is your goal to make the class return what is expected.
	 * 
	 * Currently this class does not function and throws exceptions - implement all the static methods so they work.
	 * You will know what you have done works when you run all the tests and they all pass.
	 */
	[TestClass]
	public class Dictionarys_Tests
	{
		[TestMethod]
		public void Build_ShouldBuild()
		{
			var actual = Dictionarys.Build(Guid.Empty, 1);

			Assert.AreEqual(1, actual.Count);
			Assert.AreEqual(Guid.Empty, actual.First().Key);
			Assert.AreEqual(1, actual.First().Value);
		}

		[TestMethod]
		public void GetValue_ShouldGetValueForMatchingkey()
		{
			var actual = Dictionarys.GetValue(new Dictionary<Guid, decimal>
			{
				{ Guid.Empty, 1}
			}, Guid.Empty);

			Assert.AreEqual(1, actual);
		}

		[TestMethod]
		public void GetValue_ShouldGetZero_WhenKeyDoesNotExist()
		{
			var actual = Dictionarys.GetValue(new Dictionary<Guid, decimal>
			{
				{ Guid.Empty, 1}
			}, Guid.NewGuid());

			Assert.AreEqual(0, actual);
		}

		[TestMethod]
		public void AddValue_ShouldAddKeyValuePair()
		{
			var dict = new Dictionary<Guid, decimal>
			{
				{ Guid.Empty, 1}
			};

			var newValue = Guid.NewGuid();

			Dictionarys.AddValue(dict, newValue, 2);

			Assert.AreEqual(2, dict[newValue]);
		}

		[TestMethod]
		public void AddValue_ShouldDoNothing_WhenKeyAlreadyExists()
		{
			var dict = new Dictionary<Guid, decimal>
			{
				{ Guid.Empty, 1}
			};

			Dictionarys.AddValue(dict, Guid.Empty, 2);

			Assert.AreEqual(1, dict.Count);
			Assert.AreEqual(1, dict[Guid.Empty]);
		}
	}
}