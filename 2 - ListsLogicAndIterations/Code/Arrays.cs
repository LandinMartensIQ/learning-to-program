using System;

namespace ListsLogicAndIterations.Code
{
	public static class Arrays
	{
		public static int[] BuildIntArray(int fist, int second)
		{
                     
                int[] intArray;
                intArray = new int[2];
                intArray[0] = fist;
                intArray[1] = second;
                return intArray;
            
        }

		public static int GetArrayValue(int[] array, int position)
		{
            if (position >= array.Length || position < 0)
            {
                return 0;
            }
            return array[position]; 

		}
	}
}