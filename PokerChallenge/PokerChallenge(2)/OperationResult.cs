using System;
using System.Collections.Generic;
using System.Text;

namespace PokerChallenge2
{
    class OperationResult<T>
    {
        public bool OperationSuccess { get; set; }
        public T Result { get; set; }
        public string ResultMessage { get; set; }
        public OperationResult(T result)
        {
            Result = result;
            OperationSuccess = true;
            ResultMessage = "Successful";
        }
        public OperationResult(string message)
        {
            OperationSuccess = false;
            ResultMessage = message;
        }
    }
}
