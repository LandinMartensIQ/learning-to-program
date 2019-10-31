using System;

namespace DataTypes.Code
{
	public static class WeirdCalculator
	{
		public static long SimpleWholeNumberAdd(int firstValue, long secondValue)
		{
            return firstValue + secondValue;
        }

        public static decimal SimpleDecimalAdd(float firstValue, double secondValue, decimal thirdValue)
		{

            return Convert.ToDecimal(firstValue) + Convert.ToDecimal(secondValue) + thirdValue;
           
		}

		public static decimal ComplexDecimalAdd(float firstValue, double secondValue, decimal thirdValue)
		{
            try
            {
                var firstValDec = (decimal)firstValue;
                var secondValDec = (decimal)secondValue;

                return firstValDec + secondValDec + thirdValue;
            }
            catch (Exception)
            {
                return 0;
            }
            
		}

		public static decimal ComplexAdd(char firstValue, string secondValue)
		{
            var myString = firstValue + "";
            var decimalVal = System.Convert.ToDecimal(myString);
            var decimalVal1 = System.Convert.ToDecimal(secondValue);

            return decimalVal + decimalVal1;

        }

		public static decimal ConditionalMath(int firstValue, int secondValue, bool returnNegative)
		{
			var actual = firstValue + secondValue;

			if (returnNegative == true)
			{
				actual = actual * -1;
			}
            else if (returnNegative == false && firstValue < 0 && secondValue < 0)
            {
                actual = actual * -1;
            }

			return actual;
		}
	}
}