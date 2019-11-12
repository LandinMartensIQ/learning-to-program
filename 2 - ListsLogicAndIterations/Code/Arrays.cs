using System;
using System.Linq;

namespace ListsLogicAndIterations.Code
{
	public static class Arrays
	{
		public static int[] BuildIntArray(int fist, int second)
        {

            var intArray1 = new int[]{ fist, second};

            return intArray1;

            //throw new NotImplementedException();
        }

		public static int GetArrayValue(int[] array, int position)
        {
            var maxValue = array.Max();
            var maxIndex = array.ToList().IndexOf(maxValue);
            var minValue = array.Min();
            var minIndex = array.ToList().IndexOf(minValue);

            if (position > maxIndex)
            {
                return 0;
            }
            else if (position < minIndex)
            {
                return 0;
            }

            return array[position];

            //throw new NotImplementedException();
        }
	}
}