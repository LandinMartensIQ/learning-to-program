using RPG.CharacterBuilder.CharacterAttributeClasses;

namespace RPG.CharacterBuilder
{
    public class CharacterAttributes
    {
        public HeadRoundness Roundness;
        public Height Height;
        public FitnessLevel Fitness;   
        
        public CharacterAttributes()
        {
            Roundness = new HeadRoundness();
            Fitness = new FitnessLevel();
            Height = new Height();
        }
        public CharacterAttributes(int roundness, FitnessLevelEnum fitnessLevel, int heightInches)
        {
            Roundness = new HeadRoundness(roundness);
            Fitness = new FitnessLevel(fitnessLevel);
            Height = new Height(heightInches);
        }
    }
}
