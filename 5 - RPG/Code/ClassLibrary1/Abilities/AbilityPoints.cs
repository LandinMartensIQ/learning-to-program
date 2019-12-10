using System;
using System.Collections.Generic;
using System.Text;


namespace Characters
{
    public abstract class AbilityPoints
    {


            public abstract AbilityNames AbilityName { get; }        
            public abstract int Min { get; }
            public abstract int Max { get; }
            public int Value { get; set; }

            public bool IsValid()
            {
                if (Value>Max || Value < Min)
                {
                return false;
                }
            
            return true;

            }

        public string GetValidationFailureMessage()
        {
            if (Value > Max)
            {
                return $"{AbilityName} was above the maximum of {Max}\n";
            }
            if (Value < Min)
            {
                return $"{AbilityName} was below the minimum of {Min}\n";
            }
            return "";

        }
    }
}
