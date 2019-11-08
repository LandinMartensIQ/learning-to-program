using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Dictionarys
	{
		public static Dictionary<Guid, decimal> Build(Guid key, decimal value)
		{
            var Dict = new Dictionary<Guid, decimal>();
            Dict.Add(key, value);
            return Dict;
			throw new NotImplementedException();
		}

		public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
		{
            decimal value;
            try { value = dict[key]; }
            catch (KeyNotFoundException)
            {
                value = 0;
            } 
            return value;
			throw new NotImplementedException();
		}

		public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
		{
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
            }
            return;
			throw new NotImplementedException();
		}
	}
}