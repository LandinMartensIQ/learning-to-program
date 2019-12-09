namespace RPG.CharacterBuilder.CharacterAttributeClasses
{
    public enum FitnessLevelEnum
    {
        ExtremelyFit,
        VeryFit,
        SomewhatFit,
        NotFit,
        FarFromFit
    }
    public class FitnessLevel : CharacterPropertyBase<FitnessLevelEnum>
    {
        private static FitnessLevelEnum _defaultValue = FitnessLevelEnum.SomewhatFit;
        public override FitnessLevelEnum DefaultValue { get; internal set; } = _defaultValue;
        public FitnessLevel() : base(_defaultValue)
        {

        }
        public FitnessLevel(FitnessLevelEnum value) : base(value)
        {

        }

        public override bool IsValid(FitnessLevelEnum value)
        {
            return true;
        }
    }
}
