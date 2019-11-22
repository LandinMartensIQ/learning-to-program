namespace AnimalShelters.Code
{
    public class OperationResult
    {
        public OperationResult(Animal animal)
        {
            Animal = animal;
        }
        public OperationResult(string error)
        {
            Error = error;
        }
        public Animal Animal { get; private set; }
        public string Error { get; private set; }
        public bool OperationSuccess { get { return Animal != null && Error == null; } }

    }
}
