using CupCakesAdventure;
using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Game.Interfaces;
using Pastel;
using static DungeonCrawlers.Utilities.Functions.MainFunctions;
using static System.Console;
namespace DungeonCrawlers.Entities.Encounters
{
	internal class MainEncounter
	{
		static readonly Random rand = new Random();
		public static Player currentPlayer = new Player();
		public static void FirstEncounter()
		{



		}

		public static void Combat(bool random, string name, int power, int health)
		{

			string n = "";
			string w = "";
			string z = "";
			int p = 0;
			int h = 0;

			if (random)
			{

				//w = GetWizard();
				//n = GetName();
				//z = GetZombie();
				p = MainScreen.currentPlayer.GetPower();
				h = MainScreen.currentPlayer.GetHealth();

			}
			else
			{
				n = name;
				p = power;
				h = health;




			}
			while (h > 0)
			{
				Clear();
				WriteLine(n);
				WriteLine(p + "/" + h);
				WriteLine("====================".Pastel("#125874"));
				WriteLine("| (A)ttack (D)enfend |");
				WriteLine("|  (R)un    (H)eal |");
				WriteLine("====================".Pastel("#125874"));
				WriteLine(" Potions: " + MainScreen.currentPlayer.potion + "  Health: " + MainScreen.currentPlayer.health);
				string? input = ReadLine();
				Clear();
				if (input.ToLower() == "a" || input.ToLower() == "attack")
				{
					//Attack
					WriteLine("With hast you surge forth, you sword flying in your hand's! the " + n + " string you as you pass");
					int damage = p - MainScreen.currentPlayer.armorValue;
					if (damage < 0)
						damage = 0;
					int attack = rand.Next(1, MainScreen.currentPlayer.weaponVaule) + rand.Next(1, 4);
					WriteLine("You lose " + damage + " health and deal " + attack + " damage");
					//ReadKey();
					WaitForAnyKeyPress();
					MainScreen.currentPlayer.health -= damage;
					h -= attack;
				}
				else if (input.ToLower() == "d" || input.ToLower() == "defend")
				{
					//Defend
					WriteLine("As the  " + n + " prepares to string, you ready your sword in defensive stance");
					int damage = (p / 4) - MainScreen.currentPlayer.armorValue;
					if (damage < 0)
						damage = 0;
					int attack = rand.Next(1, MainScreen.currentPlayer.weaponVaule) / 2;
					WriteLine("You lose " + damage + " health and deal " + attack + " damage");
					WaitForAnyKeyPress();
					MainScreen.currentPlayer.health -= damage;
					h -= attack;
				}
				else if (input.ToLower() == "r" || input.ToLower() == "run")
				{
					//Run
					if (rand.Next(0, 2) == 0)
					{
						WriteLine("As you sprint aways for the " + n + ", its strikes catches you in the back \n sending you sprawling to the ground");
						int damage = p - MainScreen.currentPlayer.armorValue;
						if (damage < 0)
							damage = 0;
						WriteLine("You lose" + damage + " health and are unable to escape");
						WaitForAnyKeyPress();
					}
					else
					{
						WriteLine("You use your crazy ninja moves to evade " + n + " and you successfully escape!!");
						WaitForAnyKeyPress();
						//Go to store
						Store.LoadShop(currentPlayer);

					}
				}
				else if (input.ToLower() == "h" || input.ToLower() == "heal")
				{
					//Heal
					if (MainScreen.currentPlayer.potion == 0)
					{
						WriteLine("As you Desperately grasp for a potion in her bag, all that you feel are empty glass flasks ");
						int damage = p - MainScreen.currentPlayer.armorValue;
						if (damage < 0)
							damage = 0;
						WriteLine("The " + n + " strikes you with a mighty blow and you lose " + damage + "health");
						WaitForAnyKeyPress();
					}
					else
					{
						WriteLine("You reach into your bag and pull out a glowing, blue flask.and Gulp it down ");
						int potionV = 5;
						WriteLine("You gain " + potionV + " health");
						MainScreen.currentPlayer.health += potionV;
						MainScreen.currentPlayer.potion -= 1;
						WriteLine("As you were occupied, the " + n + " advanced and struck");
						int damage = (p / 2) - MainScreen.currentPlayer.armorValue;
						if (damage < 0)
							damage = 0;
						WriteLine("You lose " + damage + " health");
						WaitForAnyKeyPress();
					}
				}

				//Death Code
				if (MainScreen.currentPlayer.health <= 0)
				{
					//Death code
					Clear();
					WriteLine("as the" + n + " stands tall and comes down to strikes. You have been Slayn by the mighty " + n);
					//ReadKey();

					Exit myExit = new Exit();
					myExit.mainExit();
				}
			}

			int c =		MainScreen.currentPlayer.GetCoins();
			Clear();
			WriteLine("As you stand victorious over the ".Pastel("#712D02") + n + ", its body dissolves into ".Pastel("#0BCECE"));
			MainScreen.currentPlayer.coins += c;
			WriteLine(+c + "coins!!".Pastel("#E7DE14"));
			WaitForAnyKeyPress();
			Clear();
		}



	}
}
