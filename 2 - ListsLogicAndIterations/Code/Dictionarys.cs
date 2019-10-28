using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
	public static class Dictionarys
	{
        public static Dictionary<Guid, decimal> Build(Guid key, decimal value)
        {
            Dictionary<Guid, decimal> dict = new Dictionary<Guid, decimal>
            {
                { key, value }
            };

            return dict;


            //throw new NotImplementedException();
		}

		public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
		{
            decimal result = 0.0m;

            try
            {
                result = dict[key];
            }
            catch (KeyNotFoundException) { };

            return result;

            //throw new NotImplementedException();
		}

		public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
		{
            if (!dict.ContainsKey(key))
                dict.Add(key, value);
            
            //throw new NotImplementedException();
		}
	}
}