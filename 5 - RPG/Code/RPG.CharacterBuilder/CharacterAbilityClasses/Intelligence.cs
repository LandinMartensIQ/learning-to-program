namespace RPG.CharacterBuilder.CharacterAbilityClasses
{
    public class Intelligence : CharacterPropertyBase<int>
    {
        private static int _defaultValue = 10;
        public override int DefaultValue { get; internal set; } = _defaultValue;
        public Intelligence() : base (_defaultValue)
        {

        }
        public Intelligence(int value) : base (value)
        {

        }

        public override bool IsValid(int value)
        {
            if (value >= 5 && value <= 20)
                return true;
            else
                return false;
        }
    }
}
