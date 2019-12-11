using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalShelter.Code.Enums;

namespace AnimalShelter.Code.Objects

{
    public class Animal 
    {

        //private string _type;
        //public string Type 
        //{
        //    get
        //    {
        //        return _type;
        //    }
        //    set
        //    {
        //        _type = value;
        //    } 
        //}

        public string Feature { get; set; }
        public SupportedAnimals AnimalType { get; set; }
        public bool CanFly { get; }
        //public bool IsSupported { get; }

        private Guid _UniqueAnimalId;
        public Guid UniqueAnimalId { get { return _UniqueAnimalId; } }

        public Animal(SupportedAnimals type)
        {
            AnimalType = type;
        }
        public void MarkUniqueId()
        {
            if (_UniqueAnimalId == Guid.Empty)
            {
                _UniqueAnimalId = Guid.NewGuid();
            }
        }
    }
}
