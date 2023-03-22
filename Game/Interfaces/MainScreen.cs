using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Entities.Character.Warrior;
using DungeonCrawlers.Utilities.GameUtilites;
using DungeonCrawlers.Utilities.GameUtilites.GameDoc;
using Pastel;
using static DungeonCrawlers.Utilities.Functions.MainFunctions;
using static System.Console;

namespace DungeonCrawlers.Game.Interfaces
{
	internal class MainScreen
	{
		private string gameVersion = "Test Version V.1 \n";
		public static Player currentPlayer = new Player();
		public ConsoleKeyInfo ConsoleKeyInfo { get; private set; }
		private static CharacterService characterService = new CharacterService();
		private static WarriorClass GetWarriorClass = new WarriorClass(characterService);




		public void mainScreen()
		{
			string title = "====DungeonCrawlers====";

			Title = title;
			ForegroundColor = ConsoleColor.Red;
			GameArt gTitle = new GameArt();
			gTitle.MainGameTitle();
			WriteOnBottomLine(gameVersion.Pastel("#5A057A"));
			Thread.Sleep(1500);
			//Write(string.Format("{0," + WindowWidth / 2 + "}", "Plz Enter Your Name:".Pastel("#97151D")));
			ForegroundColor = ConsoleColor.Cyan;
			//currentPlayer.player = ReadLine();
			Clear();
			//WriteLine($"Welcome {currentPlayer.player}\n");
			GameInfoService.MainGameInfo();
			Write("                       Press Enter TO Enter Dungeon: ".Pastel("#8A39A8"));
			ConsoleKeyInfo key = ReadKey();
			Thread.Sleep(500);
			Clear();
			MainMenu.Mainmenu();
		}
	}
}