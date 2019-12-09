namespace RPG.CharacterBuilder.CharacterAbilityClasses
{
    public class Dexterity : CharacterPropertyBase<int>
    {
        private static int _defaultValue = 10;
        public override int DefaultValue { get; internal set; } = _defaultValue;
        public Dexterity() : base(_defaultValue)
        {

        }
        public Dexterity(int value) : base(value)
        {

        }

        public override bool IsValid(int value)
        {
            if (value >= 1 && value <= 20)
                return true;
            else
                return false;
        }
    }
}
