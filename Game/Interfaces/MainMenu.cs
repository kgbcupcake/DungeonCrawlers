using DungeonCrawlers.Adventures.Services;
using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Game.GameEngine;
using DungeonCrawlers.Utilities.GameUtilites;
using DungeonCrawlers.Utilities.GameUtilites.Credits;
using Pastel;
using static System.Console;

namespace DungeonCrawlers.Game.Interfaces
{
	internal class MainMenu
	{
		private static AdventureService adventureService = new AdventureService();
		private static CharacterService characterService = new CharacterService();
		//private static Engine gameEngine = new Engine(adventureService,characterService);

		public static void Mainmenu()
		{
			Menu();
			static void Menu()
			{
				GameArt gTitle = new GameArt();
				gTitle.MainGameTitle();

				WriteLine("		      ==============================================".Pastel("#125874"));
				WriteLine("			     |(S)tart Game|  |(L)oadGame|\n                                 ");
				WriteLine("					|(C)redit's|												");
				WriteLine("		      ==============================================".Pastel("#125874"));

				switch (ReadLine().ToUpper())
				{
					//Start Game
					case "S":
						Clear();
						WriteLine("Loading Game Plz Wait...");
						Thread.Sleep(2500);
						Clear();

						Engine.StartGame();
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

		private static void LoadGame()
		{
		}

		private static void SaveGame()
		{
		}
	}
}