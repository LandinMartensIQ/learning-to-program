using ObjectOrientedProblems.Code.Enums;

namespace ObjectOrientedProblems.Code.Interfaces
{
	public interface IFighter
	{
		int Health { get; }
		int Damage { get; }

		FighterState State { get; }

		void TakeDamage(IFighter fighter);
		void DrinkPotion(IPotion potion);
		void PowerUp(IPowerUp powerUp);
	}
}