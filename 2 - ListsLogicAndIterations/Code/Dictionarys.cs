using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Dictionarys
	{
        public static Dictionary<Guid, decimal> Build(Guid key, decimal value)
        {
            var englishDictionary = new Dictionary<Guid, decimal>();
            englishDictionary.Add(key, value);
            return englishDictionary;
                
        }
		public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
		{
            //if guid does not exist in dictionary return 0
            if (!dict.ContainsKey(key))
            {
                return 0;
            }
            return dict[key]; 
        }

		public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
		{
            //if that key exists do not add value
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
            }
		}
	}
}