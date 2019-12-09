namespace RPG.CharacterBuilder.CharacterAbilityClasses
{
    public class Charisma : CharacterPropertyBase<int>
    {
        private static int _defaultValue = 10;
        public override int DefaultValue { get; internal set; } = _defaultValue;
        public Charisma() : base(_defaultValue)
        {

        }
        public Charisma(int value) : base(value)
        {

        }

        public override bool IsValid(int value)
        {
            if (value >= 0 && value <= 20)
                return true;
            else
                return false;
        }
    }
}
