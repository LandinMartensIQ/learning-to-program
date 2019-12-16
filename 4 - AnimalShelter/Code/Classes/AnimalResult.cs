using AnimalShelter.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter.Code.Classes
{
    public class AnimalResult
    {
        public IAnimal Animal { get; set; }
        public bool IsResultSuccessful { get; set; }
        public string Message { get; set; }

        public AnimalResult(bool isResultSuccessful, IAnimal animal, string message)
        {
            IsResultSuccessful = isResultSuccessful;
            Animal = animal;
            Message = message;
        }
    }
}
