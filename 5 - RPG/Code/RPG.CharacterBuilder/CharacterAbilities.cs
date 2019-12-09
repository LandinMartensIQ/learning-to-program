using RPG.CharacterBuilder.CharacterAbilityClasses;

namespace RPG.CharacterBuilder
{
    public class CharacterAbilities
    {
        internal int _totalPoints 
        { 
            get
            {
                return 
                    Intelligence.Value +
                    Wisdom.Value +
                    Dexterity.Value +
                    Strength.Value +
                    Charisma.Value +
                    Constitution.Value;
            }
         }
        public Intelligence Intelligence { get; private set; }
        public Wisdom Wisdom { get; private set; }
        public Dexterity Dexterity { get; private set; }
        public Strength Strength { get; private set; }
        public Charisma Charisma { get; private set; }
        public Constitution Constitution { get; private set; }
        public CharacterAbilities()
        {
            Intelligence = new Intelligence();
            Wisdom = new Wisdom();
            Dexterity = new Dexterity();
            Strength = new Strength();
            Charisma = new Charisma();
            Constitution = new Constitution();
        }
        private CharacterAbilities(int i, int w, int d, int s, int ch, int c)
        {
            Intelligence = new Intelligence(i);
            Wisdom = new Wisdom(w);
            Dexterity = new Dexterity(d);
            Strength = new Strength(s);
            Charisma = new Charisma(ch);
            Constitution = new Constitution(c);
        }
        public static OperationResult<CharacterAbilities> Build(int i, int w, int d, int s, int ch, int c)
        {
            var result = new CharacterAbilities(i, w, d, s, ch, c);
            if (result._totalPoints == 60)
            {
                return new OperationResult<CharacterAbilities>(result);
            }
            else
            {
                return new OperationResult<CharacterAbilities>("Total Character Abilities must be equal to 60");
            } 
        }
    }
}
