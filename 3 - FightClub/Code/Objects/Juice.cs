using ObjectOrientedProblems.Code.Interfaces;

namespace FightClub.Code.Objects
{
    public class Juice : IPowerUp
    {
        public int DamageBuff { get; set; }

        public Juice()
        {
            DamageBuff = 1;
        }

    }
}
