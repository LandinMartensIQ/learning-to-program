using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;
using System;

namespace ObjectOrientedProblems.Code
{
    public static class FightClubGame
    {
        public class Powerup : IPowerUp
        {
            public int DamageBuff { get; set; } = 1;
        }

        public class Potion : IPotion
        {
            private int _Healing = 2;
            private PotionType _PotionType = PotionType.Basic;

            public int Healing => _Healing;

            public PotionType Type => _PotionType;

            public void SetType(PotionType potionType) 
            {
                if (potionType == PotionType.Greater)
                {
                    _Healing = 5;
                    _PotionType = PotionType.Greater;
                }
                else
                {
                    _Healing = 2;
                    _PotionType = PotionType.Basic;
                }
            }
        }

        public class Fighter : IFighter
        {
            private int _Health = 10;
            private int _Damage = 1;
            private FighterState _State = FighterState.Healthy;
            public int Health => _Health;

            public int Damage => _Damage;

            public FighterState State => _State;

            public void DrinkPotion(IPotion potion)
            {
                if (_Health + potion.Healing >= 10)
                {
                    _Health = 10;
                    _State = FighterState.Healthy;
                }
                else if (_Health > 0)
                {
                    _Health += potion.Healing;
                    _State = FighterState.Hurt;
                }
            }

            public void PowerUp(IPowerUp powerUp)
            {
                _Damage += powerUp.DamageBuff;
                if (_Damage <= 0)
                    _Damage = 1;
            }

            public void TakeDamage(IFighter fighter)
            {
                if (_Health > 0)
                {
                    _Health -= fighter.Damage;
                }
                if (_Health == 0)
                    _State = FighterState.Dead;
                else if (_Health == 1)
                    _State = FighterState.KnockedOut;
                else if (_Health >= 2 && _Health <= 9)
                    _State = FighterState.Hurt;
                else
                    _State = FighterState.Healthy;
            }
        }

        public static IPowerUp PurchasePowerUp()
        {
            return new Powerup();
        }

		public static IPotion PurchasePotion()
		{
            return new Potion();
		}

		public static IFighter HireFighter()
		{
            return new Fighter();
		}
	}
}