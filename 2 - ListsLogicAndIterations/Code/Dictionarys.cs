using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
    public static class Dictionarys
    {
		public static Dictionary<Guid, decimal> Build(Guid key, decimal value)
		{
            Dictionary<Guid, decimal> result = new Dictionary<Guid, decimal>
            {
                { key, value }
            };
            return result;
		}

		public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
		{
            if (dict.TryGetValue(key, out _))
            {
                return dict[key];
            }
            else
            {
                Console.WriteLine("Value does not exist in the Dictionary");
                return 0;
            }
        }
       

		public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
		{
            try
            {
                dict.Add(key, value);
            }
            catch
            {
                Console.WriteLine("Value already exists in the Dictionary");
            }
		}
	}
}