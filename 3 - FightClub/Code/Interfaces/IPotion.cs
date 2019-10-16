using ObjectOrientedProblems.Code.Enums;

namespace ObjectOrientedProblems.Code.Interfaces
{
	public interface IPotion
	{
		int Healing { get; }
		PotionType Type { get; }

		void SetType(PotionType potionType);
	}
}