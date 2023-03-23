using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Game.Interfaces;
using Pastel;
using static DungeonCrawlers.Utilities.Functions.MainFunctions;
using static System.Console;

namespace DungeonCrawlers.Game.TownSquare

{



	public class Store
    {
       public static Player currentPlayer = new Player();
	  

        static int armorMod;
        static int weaponMod;
        static int difMod;
        static int Lockpick;

        public static void LoadShop(Player p)
        {
            armorMod = p.armorValue;
            weaponMod = p.weaponVaule;
            difMod = p.mods;
            Lockpick = p.Inv;
            RunShop(p);
        }

        public static void RunShop(Player p)
        {
            int potionP;
            int armorP;
            int weaponP;
            int difP;
            int Lockpickp;
            while (true)
            {
                //Shop Menu
                potionP = 20 + 10 * p.mods;
                armorP = 100 * (p.armorValue + 1);
                weaponP = 100 * p.weaponVaule;
                difP = 300 + 100 * p.mods;
                Lockpickp = 50 + 10 * p.Inv;
                Clear();
                WriteLine("         ===Shop===           ");
                WriteLine("========================".Pastel("#125874"));
                WriteLine("(W)eapon:	 $" + weaponP);
                WriteLine("(A)rmor:          $" + armorP);
                WriteLine("(P)otions:        $" + potionP);
                WriteLine("(D)ifficulty Mod: $" + difP);
				WriteLine("(L)ock Picks: $" + Lockpickp);
                WriteLine("========================".Pastel("#125874"));
                WriteLine("(E)exit");
                WriteLine();
                WriteLine();

                switch (ReadLine().ToUpper())
                {
                    case "P":
                        TryBuy("potion", potionP, p);


                        break;

                    case "W":
                        TryBuy("weapon", weaponP, p);
                        break;


                    case "A":
                        TryBuy("armor", armorP, p);
                        break;

                    case "D":
                        TryBuy("dif", difP, p);

                        break;

                    case "L":
                        TryBuy("Lockpick", Lockpickp, p);
                        break;

                    case "E":
                        Clear();
                        Thread.Sleep(1000);
                        TownSquare.MainTownsquare();
                        break;
                }
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
                    else if (item == "Lockpick")
                        p.Inv++;
					p.coins -= cost;
                }
                else
                {
                    WriteLine("Your Broke get your money up");
                    WaitForAnyKeyPress();
                }
            }
		}

		public static void PlayerStats()
		{
            Clear();
            WriteLine();
			WriteLine(MainScreen.currentPlayer.player + "'s Stats");
			WriteLine("========================".Pastel("#125874"));
			WriteLine("Current Health " + currentPlayer.health);
			WriteLine("Player Coin's " + MainScreen.currentPlayer.coins);
			WriteLine("Weapon Strength " + MainScreen.currentPlayer.weaponVaule);
			WriteLine("Armor Toughness " + MainScreen.currentPlayer.armorValue);
			WriteLine("Potion's " + MainScreen.currentPlayer.potion);
			WriteLine("Difficulty Mod's " + MainScreen.currentPlayer.mods);
			WriteLine("Lock Pick's" + MainScreen.currentPlayer.Inv);
			WriteLine("========================".Pastel("#125874"));
			WaitForAnyKeyPress();
            Clear();
            TownSquare.MainTownsquare();
		}

	}
}