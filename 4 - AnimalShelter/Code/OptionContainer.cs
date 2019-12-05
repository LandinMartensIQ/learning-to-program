using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelters.Code
{
    public static class OptionContainer
    {
        public static OptionContainer<TR> Build<TR>(TR value)
        {
            return new OptionContainer<TR>(value);
        }
    }

    public class OptionContainer<T>
    {
        public OptionContainer()
        {
        }

        public OptionContainer (T value)
        {
            _optionApplied = true;
            Value = value;
        }

        public T Value 
        {
            get 
            { 
                return _value;
            } 
            set
            {
                _optionApplied = true;
                _value = value;
            }
        }
        private bool _optionApplied { get; set; }
        private T _value;
        public bool OptionIsApplied()
        {
            return _optionApplied;
        }
        public void RemoveOption()
        {
            _optionApplied = false;
        }
    }
}
