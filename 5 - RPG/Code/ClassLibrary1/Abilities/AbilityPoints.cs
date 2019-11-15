using System;
using System.Collections.Generic;
using System.Text;

namespace Characters
{
    public abstract class AbilityPoints
    {

            public string AbilityName { get; set; }
            public int Min { get; set; }
            public int Max { get; set; }
            public int Value { get; set; }

            public string Validate()
            {
                if (Value>Max)
                {
                return $"{AbilityName} was above the maximum of {Max}\n";
                }
                if (Value<Min)
                {
                    return $"{AbilityName} was below the minimum of {Min}\n";
                }
            return "";

            }        
    }
}
