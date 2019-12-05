using System;

namespace AnimalShelters.Code
{
    public class AnimalFilter
    {
        public OptionContainer<string> Name { get; set; } = new OptionContainer<string>();
        public OptionContainer<AnimalSex> Sex { get; set; } = new OptionContainer<AnimalSex>();
        public OptionContainer<bool> CanFly { get; set; } = new OptionContainer<bool>();
        public OptionContainer<bool> Neutered { get; set; } = new OptionContainer<bool>();
        public OptionContainer<bool> Domesticated { get; set; } = new OptionContainer<bool>();
        public OptionContainer<AnimalType> Type { get; set; } = new OptionContainer<AnimalType>();
    }
}
