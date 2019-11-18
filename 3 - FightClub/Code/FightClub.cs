using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;
using System;

namespace ObjectOrientedProblems.Code
{
	public static class FightClubGame
	{
		public static IPowerUp PurchasePowerUp()
		{
            var powerUp = new PowerUp
            {
                DamageBuff = 1
            };
            return powerUp;
        }




        public static IPotion PurchasePotion()
		{
            var potion = new Potion
            {
                Healing = 2,
                Type = PotionType.Basic
            };
            return potion;
        }

		public static IFighter HireFighter()
		{
            var fighter = new Fighter
            {
                Damage = 1,
                Health = 10
            };
            return fighter;
		}

        class PowerUp : IPowerUp
        {
            public int DamageBuff { get; set; }
        }

        class Potion : IPotion
        {
            public int Healing { get; set; }
            public PotionType Type { get; set; }

            public void SetType(PotionType potionType) 
            {
                if (Enum.Equals(potionType, PotionType.Greater))
                { 
                    Healing = 5; 
                    Type = PotionType.Greater; 
                }
            }
        }

        class Fighter : IFighter
        {
            public int Health { get; set; }
            public int Damage { get; set; }
            public FighterState State { get; set; }

            public void TakeDamage(IFighter fighter) 
            {
                if (Health >0)
                { 
                    Health = Health - fighter.Damage;
                    if (Health < 10 && Health >1) State = FighterState.Hurt;
                    if (Health == 1) State = FighterState.KnockedOut;
                    if (Health == 0) State = FighterState.Dead;
                }
            }
            public void DrinkPotion(IPotion potion) 
            {
                if (Health > 0 & Health < 10)
                {
                    Health += potion.Healing;
                    if (Health > 10) Health = 10;
                }
                if (Health < 10 && Health > 1) State = FighterState.Hurt;
                if (Health==10) State = FighterState.Healthy;
            }
            public void PowerUp(IPowerUp powerUp) 
            {
                Damage += powerUp.DamageBuff;
                if (Damage < 1) Damage = 1;

            }
        }
    }
}