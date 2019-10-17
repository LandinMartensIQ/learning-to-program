using System;

namespace ListsLogicAndIterations.Code
{
	public static class Arrays
	{
		public static int[] BuildIntArray(int fist, int second)
		{
            int[] returnArray = new int[2] { fist, second };
            return returnArray;
		}

		public static int GetArrayValue(int[] array, int position)
		{
            if (position >= array.Length || position<0)
            {
                return 0;
            }
            return array[position];

		}
	}
}