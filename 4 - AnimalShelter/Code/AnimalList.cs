using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelters.Code
{
    public class AnimalList : List<Animal>
    {
        public AnimalList(IEnumerable<Animal> animals)
        {
            this.AddRange(animals);
        }
        public AnimalList()
        {
        }

        public AnimalList Filter<T>(OptionContainer<T> filterProp, Func<Animal, T, bool> filterfunc)
        {
            if (filterProp.OptionIsApplied())
            {
                return new AnimalList(this.Where(a => filterfunc(a, filterProp.Value)));

                //var filteredanimalist = new AnimalList();

                //foreach(var animal in this)
                //{
                //    if(filterfunc(animal, filter.Value))
                //    {
                //        filteredanimalist.Add(animal);
                //    }
                //}
            }
            return this;

        }
    }
}
