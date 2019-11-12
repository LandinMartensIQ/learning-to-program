using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Dictionarys
	{
		public static Dictionary<Guid, decimal> Build(Guid key, decimal value)
        {
            Dictionary<Guid, decimal> storageKeyDictionary = new Dictionary<Guid, decimal>();
            storageKeyDictionary.Add(key, value);

            return storageKeyDictionary;
            //throw new NotImplementedException();
        }

		public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
        {
            do
            {
                return dict.GetValueOrDefault(key);

            } while (dict.ContainsKey(key));
        }

        public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
        {
            try
            {
                dict.Add(key, value);
            }
            catch (System.ArgumentException)
            {
            }
        }
	}
}