using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Game.Interfaces;
using DungeonCrawlers.Utilities.Functions;
using DungeonCrawlers.Utilities.GameUtilites;
using static System.Console;
namespace DungeonCrawlers.Game.TownSquare
{
	internal class TownSquare
	{

		private static GameArt gameArt = new GameArt();
		public static Player currentPlayer = new  Player ();

		public static void MainTownsquare()
		{
			
			WriteLine($"Welcome to the Town Square {MainScreen.currentPlayer.player}\n");
			//gameArt.TownSquareTilte();
			MainFunctions.LineBreak();


			gameArt.Townsquare();
			//WriteLine(MainScreen.currentPlayer.player);
		
			
		


			ReadKey();


		}













	}
}
