using System;

namespace ListsLogicAndIterations.Code
{
	public static class Arrays
	{
		public static int[] BuildIntArray(int fist, int second)
		{
            int[] array = { fist, second };
            return array;
        }

		public static int GetArrayValue(int[] array, int position)
		{
            try
            {
                return array[position];
            }
            catch
            {
                return 0;
            }
        }
	}
}