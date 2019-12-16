using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub.Code
{
    public class ClassImplementsIPowerUp : IPowerUp
    {
        public int DamageBuff { get; set; }

        public ClassImplementsIPowerUp()
        {
            DamageBuff = 1;
        }
    }
}
