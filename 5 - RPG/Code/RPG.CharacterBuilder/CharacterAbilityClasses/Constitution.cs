namespace RPG.CharacterBuilder.CharacterAbilityClasses
{
    public class Constitution : CharacterPropertyBase<int>
    {
        private static int _defaultValue = 10;
        public override int DefaultValue { get; internal set; } = _defaultValue;
        public Constitution() : base(_defaultValue)
        {

        }
        public Constitution(int value) : base(value)
        {

        }

        public override bool IsValid(int value)
        {
            if (value >= 10 && value <= 20)
                return true;
            else
                return false;
        }
    }
}
