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
		public static void MainTownsquare()
		{
			
			WriteLine($"Welcome to the Town Square {MainScreen.currentPlayer.player}\n There's a store to upgrade your gear");
			MainFunctions.LineBreak();
			gameArt.Townsquare();

			WriteLine("		      ==============================================".Pastel("#125874"));
			WriteLine("			     |(S)tore|  |(Q)uests|	\n                                 ");
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

				default:
					Clear();
					WriteLine("Plz Enter The Right Letter".Pastel("#72071C"));
					MainTownsquare();
					break;
			}
		}
	}
}
