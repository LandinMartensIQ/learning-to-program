using System;

namespace ListsLogicAndIterations.Code
{
	public static class Arrays
	{
		public static int[] BuildIntArray(int fist, int second)
		{
            int[] Array = new int[] { fist, second};
            return Array;
			throw new NotImplementedException();
		}

		public static int GetArrayValue(int[] array, int position)
		{
            int result;
            try
            {
                result = array[position];
            }
            catch (IndexOutOfRangeException)
            {
                result = 0;
            }
            return result;
			throw new NotImplementedException();
		}
	}
}