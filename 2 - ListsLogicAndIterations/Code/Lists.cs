using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Lists
	{
		public static List<decimal> BuildList(decimal first, decimal second)
		{
            var newList = new List<decimal>();
            newList.Add(first);
            newList.Add(second);
            return newList;
        }

		public static decimal GetValue(List<decimal> list, int position)
		{
            if (position < 0)
                return 0;
            if (position > list.Count - 1)
                return 0;
            else
                return list[position];
        }

		public static void AddValue(List<decimal> list, decimal value) => list.Add(value);

        public static void AddValue(List<decimal> list, List<decimal> value) => list.AddRange(new List<decimal>(value));

        public static void RemoveValue(List<decimal> list, decimal value) => list.Remove(value);
    }
}