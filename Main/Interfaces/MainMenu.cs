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
						WriteLine("Loading Game Enjoy...");
						GameEngine.StartGame();

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
						WriteLine("Plz Enter The Right Letter ");
						Mainmenu();
						break;
				}
			}
		}
















	}
}
