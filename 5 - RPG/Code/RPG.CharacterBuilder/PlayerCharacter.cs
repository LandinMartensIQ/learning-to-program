namespace RPG.CharacterBuilder
{
    class PlayerCharacter
    {
        public CharacterAbilities Abilities { get; internal set; }
        public CharacterAttributes Attributes { get; internal set; }
        public PlayerCharacter()
        {
            Abilities = new CharacterAbilities();
            Attributes = new CharacterAttributes();
        }
        public PlayerCharacter(CharacterAbilities abilties, CharacterAttributes attributes)
        {
            Abilities = abilties;
            Attributes = attributes;
        }
        public PlayerCharacter(CharacterAbilities abilities)
        {
            Abilities = abilities;
            Attributes = new CharacterAttributes();
        }
        public PlayerCharacter(CharacterAttributes attributes)
        {
            Abilities = new CharacterAbilities();
            Attributes = attributes;
        }
    }
}
