using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Dictionarys
	{
		public static Dictionary<Guid, decimal> Build(Guid key, decimal value)
		{
			var newDict = new Dictionary<Guid, decimal>();
			newDict.Add(key, value);
			return newDict;
		}

		public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
		{
			if (dict.ContainsKey(key))
				return dict.Count;
			else
				return 0;
		}

		public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
		{
			if (!dict.ContainsKey(key))
				dict.Add(key, value);
			return;
		}
	}
}