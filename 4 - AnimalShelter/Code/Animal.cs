using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code
{
    public class Animal
    {
        private string _Type = "";
        
        public string Type { get => _Type;
            set
            {
                _Type = value.ToLower().Trim();
                //using a IF for now as the only requirement is to fliter by flight.
                //Needs refactor if it expands
                if (_Type == nameof(KnownAnimals.bird))
                    Feature = nameof(AnimalFeatures.flight);
            }
            }
        public string Feature { get; set; } = "";

    }
}
