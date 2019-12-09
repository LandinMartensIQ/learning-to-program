namespace RPG.CharacterBuilder
{
    public class OperationResult <T> where T : class
    {
        public T Result;
        public string ErrorMessage;
        public bool ResultSuccessful;

        public OperationResult (T result)
        {
            Result = result;
            ErrorMessage = string.Empty;
            ResultSuccessful = true;
        }

        public OperationResult(string error)
        {
            ErrorMessage = error;
            ResultSuccessful = false;
        }
    }
}
