using System;
using System.Collections.Generic;

namespace ListsLogicAndIterations.Code
{
    public static class Dictionarys
    {
        public static Dictionary<Guid, decimal> Build(Guid key, decimal value)
        {
            Dictionary<Guid, decimal> dict = new Dictionary<Guid,decimal>();
            dict.Add(key, value);
            return dict;
        }

        public static decimal GetValue(Dictionary<Guid, decimal> dict, Guid key)
        {
            return dict.GetValueOrDefault(key);
        }

        public static void AddValue(Dictionary<Guid, decimal> dict, Guid key, decimal value)
        {
            if (dict.GetValueOrDefault(key) ==0)
            {
                dict.Add(key, value);
            }
        }
    }
}