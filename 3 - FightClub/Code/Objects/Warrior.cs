using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code.Objects

{
    class Warrior : IFighter
    {
        public Warrior()
        {
            Damage = 1;
            Health = 10;
        }

        public int Health { get; set; }

        public int Damage { get; set; }

        public FighterState State { get; set; }

        public void TakeDamage(IFighter fighter)
        {
            Health -= Damage;

            if (Health < 0)
            {
                Health = 0;
            }

            switch (Health)
            {
                case 0:
                    State = FighterState.Dead;
                    break;
                case 1:
                    State = FighterState.KnockedOut;
                    break;
                default:
                    State = FighterState.Hurt;
                    break;
            }
        }

        public void DrinkPotion(IPotion potion)
        {
            Health += potion.Healing;

            if (Health >= 10)
            {
                Health = 10;
                State = FighterState.Healthy;
            }
            else if (Health == 3)
            {
                State = FighterState.Hurt;
            }
            else if (Health <= 2)
            {
                Health = 0;
            }
        }

        public void PowerUp(IPowerUp powerUp)
        {
            var newDamage = powerUp.DamageBuff;

            if (newDamage < 1 && Damage > 1 || newDamage > 1)
            {
                Damage += newDamage;
            }
            else if (newDamage < 1)
            {
                newDamage = 0;
            }
        }
    }
}
