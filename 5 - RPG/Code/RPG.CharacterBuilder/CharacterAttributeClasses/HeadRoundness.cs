namespace RPG.CharacterBuilder.CharacterAttributeClasses
{
    public class HeadRoundness : CharacterPropertyBase<int>
    {
        private static int _defaultValue = 60;
        public override int DefaultValue { get; internal set; } = _defaultValue;
        public override string invalidValueError { get; set; } = "Head Roundness must be an integer between 0 and 100";
        public HeadRoundness() : base(_defaultValue)
        {

        }
        public HeadRoundness(int roundness) : base(roundness)
        {

        }
        public override bool IsValid(int value)
        {
            if (value >= 0 && value <= 100)
                return true;
            else
                return false;
        }
    }
}
