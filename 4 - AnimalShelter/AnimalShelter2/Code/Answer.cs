using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter2
{
    public class Answer
    {
        public bool isFound;
        public IEnumerable<Animal> enumResult;
        public object p1;

        public bool IsFoundAddedOrRemoved { get; set; }
        public Animal Animal { get; set; }
        public string ErrorMsg { get; set; }

        public Answer(bool isAdded, Animal animal, string errorMsg)
        {
            IsFoundAddedOrRemoved = isAdded;
            Animal = animal;
            ErrorMsg = errorMsg;
        }

        public Answer(Animal animal) : this(true, animal, null)
        {

        }
        public Answer(string errorMsg) : this(false, null, errorMsg)
        {

        }
    }
}
