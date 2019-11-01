using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text; 

namespace FightClub.Code.Objects
{
    class EnergyDrink : IPotion
    {
        public int Healing { get; set; }
        public PotionType Type { get; set; }
        public EnergyDrink()
        {
            Healing = 2;
            Type = PotionType.Basic;
        }
        public void SetType(PotionType potionType)
        {
            Type = potionType;
            if (potionType == PotionType.Greater) { Healing = 5; }
            else { Healing = 2; }
        }
    }
}