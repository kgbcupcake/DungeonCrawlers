namespace DungeonCrawlers.Entities.Character.Service
{
		
	public class CharacterData
	{
		Random rand = new Random();
		public string? GUID { get; set; }
		public string? Name { get; set; }
		public int Level { get; set; }
		public string? Abilities { get; set; }
		public int coins { get; set; }
		public int health { get; set; }
		public int damage { get; set; }
		public int armorValue { get; set; }
		public int potion { get; set; }
		public int weaponVaule { get; set; }
		public int mods { get; set; }

	


		public List<string>? AdventuresPlayed;



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










		//public string? Background;
		//public Abilities? Abilities;
		//public string? Name;
		//public string? Level;
		//public int coins;
		//public int mods;
		//public int potion;
		//public int damage;
		//public bool IsAslive;
		//public int ArmorClass;
		//public int armorValue;
		//public int weaponVaule;
		//public int HitPoints;
		//public List<string>? AdventuresPlayed;
		//public List<IItem>? Inventory;





	}

	public class Abilities
		{
			public int Strenght;
			public int Dexerity;
			public int Wisdom;
			public int Inelligence;
			public int Charisma;

		}







}


