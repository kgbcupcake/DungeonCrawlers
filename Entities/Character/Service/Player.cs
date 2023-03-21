namespace DungeonCrawlers.Entities.Character.Service
{
	public class Player
	{
		Random rand = new Random();

		public string? player;
		public int coins = 30000;
		public int health = 10;
		public int damage = 1;
		public int armorValue = 0;
		public int potion = 5;
		public int weaponVaule = 1;
		public int mods = 0;
		public int Inv = 0;

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
}
