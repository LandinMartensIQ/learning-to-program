using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub
{
    class Steroids : IPowerUp
    {
        public int DamageBuff { get; set; }

        public Steroids()
        {
            DamageBuff = 1;
        }
    }

}
