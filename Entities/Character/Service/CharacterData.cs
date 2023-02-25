using DungeonCrawlers.Items.Interfaces;

namespace DungeonCrawlers.Entities.Character.Service
{
	public class CharacterData
	{
		Random rand = new Random();
		public string? GUID { get; set; }
	
		public string? player { get; set; }
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
		public CharacterClass Class;
		public enum PlayerClass { Mage, Archer, Warrior}
		public PlayerClass cuurrentClass = PlayerClass.Warrior;
		public class Abilities
		{
			public int Strength;
			public int Dexterity;
			public int Intelligence;
			public int Wisdom;
			public int Charisma;
		}




		public int GetHealth()
		{
			int upper = (2 * mods + 5);
			int lower = (mods + 2);
			return rand.Next(lower, upper);
		}



		public int GetPower()
		{
			int upper = (2 * mods + 3);
			int lower = (mods + 1);
			return rand.Next(lower, upper);
		}

		public int GetCoins()
		{
			int upper = (15 * mods + 50);
			int lower = (10 * mods + 10);
			return rand.Next(lower, upper);
		}







	}


	public enum CharacterClass
	{
		Fighter,
		MagicUser,
		Thief,
		Healer

	}

	


}


