namespace RPG.CharacterBuilder.CharacterAttributeClasses
{
    public class Height : CharacterPropertyBase<int>
    {
        private static int _defaultValue = 70;
        public override int DefaultValue { get; internal set; } = _defaultValue;
        public override string invalidValueError { get; set; } = "Height must be an integer greater than 0";
        public string ReadableHeight
        {
            get
            {
                return ConvertToReadableHeight(Value);
            }
        }
        public Height() : base(_defaultValue)
        {

        }
        public Height(int HeightInches) : base(HeightInches)
        {

        }

        public override bool IsValid(int value)
        {
            if (value > 0)
                return true;
            else
                return false;
        }
        private string ConvertToReadableHeight(int inches)
        {
            var Feet = inches / 12;
            var RemainingInches = inches % 12;
            if (RemainingInches == 0)
            {
                return ($"{Feet}'");
            }
            else
            {
                return ($"{Feet}'{RemainingInches}" + (char)34);
            }
        }
    }
}
