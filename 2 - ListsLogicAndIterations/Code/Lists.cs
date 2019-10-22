using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Lists
	{
		public static List<decimal> BuildList(decimal first, decimal second)
		{
            var result = new List<decimal> { first, second };
            return result;
		}

		public static decimal GetValue(List<decimal> list, int position)
		{
            try
            {
                return list[position];
            }
            catch
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
			foreach(decimal number in value)
            {
                list.Add(number);
            }
		}

		public static void RemoveValue(List<decimal> list, decimal value)
		{
            list.Remove(value);
		}
	}
}