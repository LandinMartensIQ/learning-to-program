using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Arrays
	{
    
		public static int[] BuildIntArray(int first, int second)
		{
            int[] array1 = new int[] { first, second };
            return array1;
		}

		public static int GetArrayValue(int[] array, int position)
		{
            if (position >= 0 && position < array.Length)
            {
                return array[position];
            }
            else
            {
                return 0;
            }
		}
	}
}