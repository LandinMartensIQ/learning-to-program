using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Lists
	{
		public static List<decimal> BuildList(decimal first, decimal second)
		{
			List<decimal> decList = new List<decimal>
            {
                first,
                second
            }
            ;
            return decList;

        }

		public static decimal GetValue(List<decimal> list, int position)
        {
            try
            {
                return list[position];
            }
            catch (ArgumentOutOfRangeException)
            {
                return 0;
            }


        }

		public static void AddValue(List<decimal> list, decimal value)
		{
			list.Add(value);
		}

		public static void AddValue(List<decimal> list, List<decimal> value)
		{
			list.AddRange(value);
		}

		public static void RemoveValue(List<decimal> list, decimal value)
        {
            list.Remove(value);
        }
	}
}