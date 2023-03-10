using DungeonCrawlers.Entities.Character.Service;
using Pastel;
using static DungeonCrawlers.Utilities.Functions.MainFunctions;
using static System.Console;

namespace CupCakesAdventure

{

	public class Store
	{
		static int armorMod;
		static int weaponMod;
		static int difMod;

		public static void LoadShop(Player p)
		{
			armorMod = p.armorValue;
			weaponMod = p.weaponVaule;
			difMod = p.mods;

			RunShop(p);
		}

		public static void RunShop(Player p)
		{
			int potionP;
			int armorP;
			int weaponP;
			int difP;
			while (true)
			{
				//Shop Menu
				potionP = 20 + 10 * p.mods;
				armorP = 100 * (p.armorValue + 1);
				weaponP = 100 * p.weaponVaule;
				difP = 300 + 100 * p.mods;
				Clear();
				WriteLine("         ===Shop===           ");
				WriteLine("========================".Pastel("#125874"));
				WriteLine("(W)eapon:	 $" + weaponP);
				WriteLine("(A)rmor:          $" + armorP);
				WriteLine("(P)otions:        $" + potionP);
				WriteLine("(D)ifficulty Mod: $" + difP);
				WriteLine("========================".Pastel("#125874"));
				WriteLine("(E)exit");
				WriteLine();
				WriteLine();

				//Player Stats Menu
				WriteLine(p.player + "'s Stats");
				WriteLine("========================".Pastel("#125874"));
				WriteLine("Current Health " + p.health);
				WriteLine("Player Coin's " + p.coins);
				WriteLine("Weapon Strength " + p.weaponVaule);
				WriteLine("Armor Toughness " + p.armorValue);
				WriteLine("Potion's " + p.potion);
				WriteLine("Difficulty Mod's " + p.mods);
				WriteLine("========================".Pastel("#125874"));









				//Input Section
				string input = ReadLine().ToLower();
				if (input == "p" || input == "potion")
				{
					TryBuy("potion", potionP, p);
				}
				else if (input == "w" || input == "weapon")
				{
					TryBuy("weapon", weaponP, p);
				}
				else if (input == "a" || input == "armor")
				{
					TryBuy("armor", armorP, p);
				}
				else if (input == "d" || input == "difficulty mod")
				{
					TryBuy("dif", difP, p);
				}
				else if (input == "e" || input == "exit")
					break;

			}

			static void TryBuy(string item, int cost, Player p)
			{
				if (p.coins >= cost)
				{
					if (item == "potion")
						p.potion++;
					else if (item == "weapon")
						p.weaponVaule++;
					else if (item == "armor")
						p.armorValue++;
					else if (item == "dif")
						p.mods++;


					p.coins -= cost;
				}
				else
				{
					WriteLine("Your Broke get your money up");
					WaitForAnyKeyPress();
				}
			}


		}


	}
}