using DungeonCrawlers.Utilities.GameUtilites;
using Pastel;
using static System.Console;
using DungeonCrawlers.Game.GameEngine;
using DungeonCrawlers.Utilities.GameUtilites.Credits;

namespace DungeonCrawlers.Main.Interfaces
{
	internal class MainMenu
	{
		public static void Mainmenu()
		{
			Menu();
			static void Menu()
			{
				GameTitle gTitle = new GameTitle();
				gTitle.MainGameTitle();

				WriteLine("		      ==============================================".Pastel("#125874"));
				WriteLine("			     |(S)tart Game  (L)oad (G)ame|\n                                 ");
				WriteLine("					|(C)redit's|												");
				WriteLine("		      ==============================================".Pastel("#125874"));

				switch (ReadLine().ToUpper())
				{
					//Start Game
					case "S":
						Clear();
						WriteLine("Loading Game Plz Wait...");
						Thread.Sleep(2500);
						StartGame();
						break;

					// Load Game
					case "L":
						break;
					//Credits
					case "C":
						Clear();
						WriteLine("Loading Credit's...");
						Thread.Sleep(1500);
						Clear();
						CreditService.loadCredits();
						break;
					default:
						Clear();
						WriteLine("Plz Enter The Right Letter".Pastel("#72071C"));
						Mainmenu();
						break;
				}
			}

			



		}

		private static void StartGame()
		{
			GameEngine.StartGame();
			//Will go into CreateCharacter Menu..
		

		}

		private static void CreateCharacter()
		{
			GameEngine.CreateCharacter();
		}













	}
}
