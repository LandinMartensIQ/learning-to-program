using System;

namespace ListsLogicAndIterations.Code
{
	public static class Arrays
	{
		public static int[] BuildIntArray(int fist, int second)
		{
            int[] result = new int[] { fist, second };

            return result;

            //throw new NotImplementedException();
		}

		public static int GetArrayValue(int[] array, int position)
		{

            try
            {
                return array[position];
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            }
		}
	}
}