using AnimalShelter.Code.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code.Interfaces
{
    public interface IAnimal
    {
        Guid UniqueAnimalId { get; }
        AnimalType AnimalType { get; }
        bool AnimalCanFly { get; }
    }
}
