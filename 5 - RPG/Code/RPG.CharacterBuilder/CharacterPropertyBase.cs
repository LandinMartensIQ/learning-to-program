namespace RPG.CharacterBuilder
{
    public abstract class CharacterPropertyBase<T>
    {
        public virtual T Value { get; internal set; }
        public abstract T DefaultValue { get; internal set; }
        public virtual string invalidValueError { get; set; } = "Input Value is invalid";
        public CharacterPropertyBase(T value)
        {
            if (IsValid(value))
                Value = value;
            else
                Value = DefaultValue;
        }
        internal virtual OperationResult<CharacterPropertyBase<T>> SetValue(T value)
        {
            if (IsValid(value))
            {
                Value = value;
                return new OperationResult<CharacterPropertyBase<T>>(this);
            }
            else
            {
                return new OperationResult<CharacterPropertyBase<T>>(invalidValueError);
            }
        }
        public abstract bool IsValid(T value);
    }
}
