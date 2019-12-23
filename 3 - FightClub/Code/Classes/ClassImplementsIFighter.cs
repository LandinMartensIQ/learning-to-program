using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub.Code
{
    class ClassImplementsIFighter : IFighter
    {
        public int Health { get; set; }

        public int Damage { get; set; }

        public FighterState State { get; set; }

        public ClassImplementsIFighter()
        {
            Damage = 1;
            Health = 10;
            State = FighterState.Healthy;
        }

        public void DrinkPotion(IPotion potion)
        {
            if (Health == 0)
                Health = 0;
            if (Health + potion.Healing > 10)
                Health = 10;
            if (Health != 0 && (Health + potion.Healing) <= 10)
                Health += potion.Healing;

            if (Health == 10)
                State = FighterState.Healthy;
            if (Health < 10)
                State = FighterState.Hurt;
            if (Health == 0)
                State = FighterState.Dead;
        }

        public void PowerUp(IPowerUp powerUp)
        {
            Damage += powerUp.DamageBuff;

            if (Damage < 1)
                Damage = 1;
        }

        public void TakeDamage(IFighter fighter)
        {
            this.Health -= fighter.Damage;

            if (this.Health < 0)
                Health = 0;
            if (this.Health >= 2 && Health <= 10)
                State = FighterState.Hurt;
            if (this.Health == 1)
                State = FighterState.KnockedOut;
            if (this.Health == 0)
                State = FighterState.Dead;
        }
    }
}
