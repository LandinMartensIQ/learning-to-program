using DataTypes.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataTypes.Tests
{
	/*
	 * Below are TDD (Test Driven Design) AAA Tests (Arrange, Act, Assert).
	 * 
	 * These tests are considered "expected behaviour" and it is your goal to make the WeirdCalculator class return what is expected.
	 * The purpose of TDD is to "teach" you what the code should do, which can you help understand the system even if the system is not built.
	 * Do *NOT* modify any code in existing testing unit methods, you may however *ADD* tests if you would like to help write our your code and validate it works.
	 * 
	 * Currently this class (`WeirdCalculator` located in the `Code` folder) does not function and throws exceptions - implement all the static methods so they work.
	 * You will know what you have done works when you run all the tests and they all pass.
	 * 
	 * I am *NOT* looking for "above and beyond" - this is just to confirm your understanding of data types and to test your ability to change from one type to another (a classic carrier service use case!)
	 * You may have to google some things "C# how do you ...." - this is normal and we do it all the time - this does not mean you have failed!
	 * 
	 * Good luck!
	 */
	[TestClass]
	public class WeirdCalculator_Tests
	{
		[TestMethod]
		public void SimpleWholeNumberAdd_ShouldAdd()
		{
			//Arrange
			int firstValue = 1;
			long secondValue = 21474836470;
			var expected = 21474836471;

			//Act
			var actual = WeirdCalculator.SimpleWholeNumberAdd(firstValue, secondValue);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SimpleDecimalAdd_ShouldAddValuesAndAssumeNoDataLossWillHappen()
		{
			//Arrange
			var firstValue = 1.1f;
			var secondValue = 1.2d;
			var thirdValue = 1.3m;
			var expected = 3.6m;

			//Act
			var actual = WeirdCalculator.SimpleDecimalAdd(firstValue, secondValue, thirdValue);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ComplexDecimalAdd_WhenGivenDifferentFloatingTypes_ShouldAddIfTheyCanAllFitIntoDecimals()
		{
			//Arrange
			var firstValue = 1.1f;
			var secondValue = 1.2d;
			var thirdValue = 1.3m;
			var expected = 3.6m;

			//Act
			var actual = WeirdCalculator.ComplexDecimalAdd(firstValue, secondValue, thirdValue);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ComplexDecimalAdd_WhenGivenDifferentFloatingTypes_ShouldReturnZeroWhenDoubleIsBeyondDecimal()
		{
			//Arrange
			var firstValue = 1.1f;
			var secondValue = double.MaxValue;
			var thirdValue = 1.3m;
			var expected = 0m;

			//Act
			var actual = WeirdCalculator.ComplexDecimalAdd(firstValue, secondValue, thirdValue);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ComplexDecimalAdd_WhenGivenDifferentFloatingTypes_ShouldReturnZeroWhenFloatIsBeyondDecimal()
		{
			//Arrange
			var firstValue = float.MaxValue;
			var secondValue = 1.2d;
			var thirdValue = 1.3m;
			var expected = 0m;

			//Act
			var actual = WeirdCalculator.ComplexDecimalAdd(firstValue, secondValue, thirdValue);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ComplexAdd_ShouldAdd()
		{
			//Arrange
			var firstValue = '1';
			var secondValue = "3.3";
			var expected = 4.3m;

			//Act
			var actual = WeirdCalculator.ComplexAdd(firstValue, secondValue);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConditionalMath_ShouldAddAndReturnPositiveValue_WhenReturnNegativeIsFalse()
		{
			//Arrange
			var firstValue = 1;
			var secondValue = 2;
			var returnNegative = false;
			var expected = 3m;

			//Act
			var actual = WeirdCalculator.ConditionalMath(firstValue, secondValue, returnNegative);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConditionalMath_ShouldAddAndReturnNegativeValue_WhenReturnNegativeIsTrue()
		{
			//Arrange
			var firstValue = 1;
			var secondValue = 2;
			var returnNegative = true;
			var expected = -3m;

			//Act
			var actual = WeirdCalculator.ConditionalMath(firstValue, secondValue, returnNegative);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConditionalMath_ShouldAddAndReturnPositiveValue_WhenValuesAreNegativeAndReturnNegativeIsFalse()
		{
			//Arrange
			var firstValue = -1;
			var secondValue = -2;
			var returnNegative = false;
			var expected = 3m;

			//Act
			var actual = WeirdCalculator.ConditionalMath(firstValue, secondValue, returnNegative);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void ConditionalMath_ShouldAddAndReturnNegativeValue_WhenValuesAreNegativeAndReturnNegativeIsTrue()
		{
			//Arrange
			var firstValue = -1;
			var secondValue = -2;
			var returnNegative = true;
			var expected = -3m;

			//Act
			var actual = WeirdCalculator.ConditionalMath(firstValue, secondValue, returnNegative);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
