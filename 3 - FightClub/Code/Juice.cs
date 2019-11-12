using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code
{
    class Juice : IPowerUp
    {
        public int DamageBuff { get; set; }

        public Juice()
        {
            DamageBuff = 1;
        }
    }
}
