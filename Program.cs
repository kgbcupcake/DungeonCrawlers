using DungeonCrawlers.Game.Interfaces;
using DungeonCrawlers.Utilities.Functions;

namespace DungeonCrawler
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			MainFunctions.ConsoleSize();
			MainScreen screen = new MainScreen();
			screen.mainScreen();
		}
	}
}