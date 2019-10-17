using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub.Code.Objects
{
    class Potion : IPotion
    {
        public int Healing => _healing;

        public PotionType Type => _type;

        private PotionType _type;
        private int _healing;

        public void SetType(PotionType potionType)
        {
            _type = potionType;
            switch (potionType) {
                case PotionType.Basic:
                    _healing = 2;
                break;
                case PotionType.Greater:
                    _healing = 5;
                    break;
            }
        }

        public Potion()
        {
            SetType(PotionType.Basic);

        }
    }
}
