namespace AnimalShelters.Code
{
    public class FilterObject
    {
        public AnimalType ? Type { get; set; }

        public bool ? CanFly { get; set; }

        //Previously, I was attempting to verify that the variable was set to determine whether to use it.  Nullables accomplish this more concisely.
        //public AnimalType Type
        //{
        //get { return _type; }
        //set
        //{
        //    _typeSet = true;
        //    _type = value;
        //}
        //}
        //public bool CanFly
        //{ 
        //    get { return _canFly;  }
        //    set
        //    {
        //        _canFlySet = true;
        //        _canFly = value;
        //    }
        //}
        //public bool TypeSet { get { return _typeSet; } }
        //public bool CanFlySet { get { return _canFlySet; } }

        //private AnimalType _type;
        //private bool _typeSet;

        //private bool _canFly;
        //private bool _canFlySet;
    }
}
