using AnimalShelterCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelterCode
{
    public class OperationResult
    {
        public OperationResult(Animal animal)
        {
            Animal = animal;
            OperationSuccess = true;
        }
        public OperationResult(string error)
        {
            Error = error;
            OperationSuccess = false;
        }
        internal Animal Animal { get; private set; }
        internal string Error { get; private set; }
        internal bool OperationSuccess { get; private set; }

    }
}
