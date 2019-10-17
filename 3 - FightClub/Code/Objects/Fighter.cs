using ObjectOrientedProblems.Code.Enums;
using ObjectOrientedProblems.Code.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightClub.Code.Objects
{
    class Fighter : IFighter
    {
        public int Health => _health;

        public int Damage => _damage;

        public FighterState State => _curStatus;

        const int _maxhealth=10;
        private int _health;
        private int _damage;
        private FighterState _curStatus;

        public void DrinkPotion(IPotion potion)
        {
            if (_curStatus == FighterState.Dead)
            {
                return;
            }
            _health += potion.Healing;
            _health = Math.Min(_health, _maxhealth);
            setStatus();
        }

        public void PowerUp(IPowerUp powerUp)
        {
            _damage += powerUp.DamageBuff;
            _damage = Math.Max(1, _damage);
        }

        public void TakeDamage(IFighter fighter)
        {
            _health -= fighter.Damage;
            _health = Math.Max(_health, 0);
            setStatus();
            
        }   
        
        private void setStatus()
        {
           switch (_health)
            {
                case _maxhealth:
                    _curStatus = FighterState.Healthy;
                    break;
                case 1:
                    _curStatus = FighterState.KnockedOut;
                    break;
                case 0:
                    _curStatus = FighterState.Dead;
                    break;
                default:
                    _curStatus = FighterState.Hurt;
                    break;
            }
        }

        public Fighter()
        {
            _damage = 1;
            _health = 10;
            _curStatus = FighterState.Healthy;
        }
    }
}
