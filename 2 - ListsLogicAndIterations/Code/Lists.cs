using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Lists
	{
		public static List<decimal> BuildList(decimal first, decimal second)
		{
            List<decimal> newlist = new List<decimal> { first, second };
            return newlist;

            //throw new NotImplementedException();
		}

		public static decimal GetValue(List<decimal> list, int position)
		{
            try
            {
                return list[position];
            }
            catch (Exception)
            {
                return 0.0M;
            }

            //throw new NotImplementedException();
		}

		public static void AddValue(List<decimal> list, decimal value)
		{

            list.Add(value);

            //throw new NotImplementedException();
		}

		public static void AddValue(List<decimal> list, List<decimal> value)
		{

            list.AddRange(value);
            //throw new NotImplementedException();
		}

		public static void RemoveValue(List<decimal> list, decimal value)
		{
            try
            {
                list.Remove(value);
            }
            catch {}

            //throw new NotImplementedException();
		}
	}
}