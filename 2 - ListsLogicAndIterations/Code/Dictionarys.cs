using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Dictionarys
	{
		public static Dictionary<Guid, decimal> Build(Guid key, decimal value) => new Dictionary<Guid, decimal>() { { key, value } };

		public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
		{
			if (!dict.ContainsKey(key))
				return 0;
			else
				return dict.Count;
		}

		public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
		{
			if (!dict.ContainsKey(key))
				dict.Add(key, value);
		}
	}
}