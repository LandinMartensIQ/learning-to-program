using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Lists
	{
		public static List<decimal> BuildList(decimal first, decimal second)
		{
            var buildList = new List<decimal>();
            buildList.Add(first);
            buildList.Add(second);
            return buildList;
		}

		public static decimal GetValue(List<decimal> list, int position)
		{

            if (position >= list.Count || position < 0)
            {
                return 0;
            } 
           return list[position];
        
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