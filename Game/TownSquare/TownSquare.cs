using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Game.Interfaces;
using DungeonCrawlers.Utilities.Functions;
using DungeonCrawlers.Utilities.GameUtilites;
using static System.Console;
using Pastel;
namespace DungeonCrawlers.Game.TownSquare
{
	internal class TownSquare
	{

		private static GameArt gameArt = new GameArt();
		public static Player currentPlayer = new  Player ();
		private static QuestMenu Questmenu = new QuestMenu();
		private static Store store = new Store ();
		



		public static void MainTownsquare()
		{
			
			WriteLine($"Welcome to the Town Square {MainScreen.currentPlayer.Name}\n There's a store to upgrade your gear");
			MainFunctions.LineBreak();
			gameArt.Townsquare();

			WriteLine("		      ==============================================".Pastel("#125874"));
			WriteLine("			        |(S)tore|      |(Q)uests|	\n                                     ");
			WriteLine("			     |(B)lack Smith|  |(M)ed Clinic|	\n                                 ");
			WriteLine("			             |(P)layer Stat's|                                             ");
			WriteLine("		      ==============================================".Pastel("#125874"));

			switch(ReadLine().ToUpper())
			{
				case "S":
					MainFunctions.Runstore();
					break;

				case "Q":
					WriteLine("Loading Quest's");
					Thread.Sleep(1000);
					Questmenu.Questmenu();
					break;

				case "P":
					WriteLine("Loading Player Stat's");
					Thread.Sleep(1000);
					Store.PlayerStats();
					break;

				case "B":
					Clear();
					WriteLine("Coming Soon");
					Thread.Sleep(1000);
					MainTownsquare();
					break;

				case "M":
					Clear();
					WriteLine("Coming Soon");
					Thread.Sleep(1000);
					MainTownsquare();
					break;


				default:
					Clear();
					WriteLine("Plz Enter The Right Letter".Pastel("#72071C"));
					MainTownsquare();
					break;
			}
		}
	}
}
