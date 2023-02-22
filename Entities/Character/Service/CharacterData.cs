using DungeonCrawlers.Items.Interfaces;

namespace DungeonCrawlers.Entities.Character.Service
{
    public class CharacterData
    {
        public string? GUID { get; set; }
        public string? ClassName { get; set; }
        public int Level { get; set; }
        public string? Abilitie { get; set; }
        public int coins { get; set; }
        public int health { get; set; }
        public int damage { get; set; }
        public int armorValue { get; set; }
        public int potion { get; set; }
        public int weaponVaule { get; set; }
        public int mods { get; set; }
        public List<string>? AdventuresPlayed;
        public List<IItem>? Inventory;

        public class Abilities
        {
            public int Strength;
            public int Dexterity;
            public int Intelligence;
            public int Wisdom;
            public int Charisma;
        }













    }
}
