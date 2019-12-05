using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelters.Code
{
    public class Bird : Animal
    {
        public bool WingsIntact { get;  set; }
        public override bool CanFly { get { return WingsIntact; } }
        public Bird(string name) : base(name, AnimalType.Bird)
        {
            WingsIntact = true;
        }
        public Bird() : base(AnimalType.Bird)
        {
            WingsIntact = true;
        }
    }
}
