namespace AnimalShelters.Code
{
    public class Dog : Animal
    {
        public double WeightKg {get; set;}
        public DogSize Size => GetDogSize();

        public Dog (string name) : base(name, AnimalType.Dog)
        {
        }
        public Dog () : base (AnimalType.Dog)
        {
        }
        private DogSize GetDogSize()
        {            
            if (WeightKg < (int)DogSize.Small)
                return DogSize.Small;
            else if (WeightKg < (int)DogSize.Medium)
                return DogSize.Medium;
            else if (WeightKg < (int)DogSize.Large)
                return DogSize.Large;
            else
                return DogSize.Giant;
        }
    }
}
