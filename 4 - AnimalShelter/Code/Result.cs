namespace AnimalShelter.Code
{
    public class Result   
    {
        public bool WasAdded { get; set; }
        public Animal Animal { get; set; }
        public string ErrorMessage { get; set; }

        private Result(bool wasAdded, Animal animal, string errorMessage)
        {
            WasAdded = wasAdded;
            Animal = animal;
            ErrorMessage = errorMessage;
        }

        public Result(Animal animal) : this(true, animal, null)
        {

        }

        public Result(string errorMessage) : this(false, null, errorMessage)
        {

        }

    }
}
