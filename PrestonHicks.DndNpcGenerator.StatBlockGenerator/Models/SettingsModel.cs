namespace PH.DndNpcGenerator.StatBlockGenerator.Models
{
    public class SettingsModel
    {
        private int _challengeRating;
        private string _ancestry;
        private string _combatArchetype;
        private string _abilityStyle;
        private string _magicType;
        private bool _usesTraditionalSpellcasting;
        private string _attackMode;
        private bool _hasElementalTheme;
        private string _elementalTheme;
        private bool _isLeader;
        private bool _isLegendary;
        private bool _isActionOriented;
        private bool _hasMagicItems;
        private int _magicItemsAmount;
        private int _magicItemsRarity;
        public int ChallengeRating { get; set; }
        public string Ancestry { get; set; }
        public string CombatArchetype { get; set; }
        public string AbilityStyle { get; set; }
        public string MagicType { get; set; }
        public bool UsesTraditionalSpellcasting { get; set; }
        public string AttackMode { get; set; }
        public bool HasElementalTheme { get; set; }
        public string ElementalTheme { get; set; }
        public bool IsLeader { get; set; }
        public bool IsLegendary { get; set; }
        public bool IsActionOriented { get; set; }
        public bool HasMagicItems { get; set; }
        public int MagicItemsAmount { get; set; }
        public int MagicItemsRarity { get; set; }


    }
}
