using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;

namespace ObjectOrientedProblems.Code
{
    internal class Boxer : IFighter
    {
        public Boxer()
        {
            Damage = 1;
            Health = 10;
            State = FighterState.Healthy;
        }
        public int Health { get; set; }

        public int Damage { get; set; }

        public FighterState State { get; set; }

        public void DrinkPotion(IPotion potion)
        {
            if(Health != 0) { Health += potion.Healing; }

            if(Health >10) { Health = 10; }

            if (Health >= 10) { State = FighterState.Healthy; }
            else if (Health >=2) { State = FighterState.Hurt; }
            else if (Health ==1) { State = FighterState.KnockedOut; }
            else { State = FighterState.Dead; }
            
            /*
             * FIRST WORKING VERSION OF THIS CODE
             *var newHealth = Health + potion.Healing;
             *
             *if (Health != 0)
             *{
             *   if (newHealth >= 10)
             *   {
             *       Health = 10;
             *   }
             *   else
             *   {
             *       Health = newHealth;
             *   }
             *}
             * 
             *if (Health == 10)
             *{
             *   State = FighterState.Healthy;
             *}
             *else if (Health >= 2)
             *{
             *   State = FighterState.Hurt;
             *}
             */
        }

        public void PowerUp(IPowerUp powerUp)
        {
            Damage += powerUp.DamageBuff;
            if(Damage <= 0) { Damage = 1; }

            /* 
             * FIRST WORKING VERSION OF THIS CODE
             * var newDamage = Damage + powerUp.DamageBuff;
             * if(newDamage > 0)
             *{
             *   Damage = newDamage;
             *}
             *else
             *{
             *   Damage = 1;
             *}
             */
        }

        public void TakeDamage(IFighter fighter)
        {
            Health -= fighter.Damage;

            if (Health <0) { Health = 0;  }

            //if (Health == 0) { State = FighterState.Dead; }
            //if (Health == 1) { State = FighterState.KnockedOut; }
            //if (Health >= 2) { State = FighterState.Hurt; }
            //if (Health == 10) { State = FighterState.Healthy; }

            if (Health >= 10) { State = FighterState.Healthy; }
            else if (Health >= 2) { State = FighterState.Hurt; }
            else if (Health == 1) { State = FighterState.KnockedOut; }
            else { State = FighterState.Dead; }
        }
    }
}