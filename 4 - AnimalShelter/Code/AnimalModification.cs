using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelters.Code
{
    public class AnimalModification
    {
        public OptionContainer<string> Name { get; set; } = new OptionContainer<string>();
        public OptionContainer<AnimalSex> Sex { get; set; } = new OptionContainer<AnimalSex>();
        public OptionContainer<bool> CanFly { get; set; } = new OptionContainer<bool>();
        public OptionContainer<bool> Neutered { get; set; } = new OptionContainer<bool>();
        public OptionContainer<bool> Domesticated { get; set; } = new OptionContainer<bool>();
    }
}
