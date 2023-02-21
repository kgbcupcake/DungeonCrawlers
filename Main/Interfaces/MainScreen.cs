using DungeonCrawlers.Utilities.GameUtilites;
using Pastel;
using static DungeonCrawlers.Utilities.Functions.MainFunctions;
using static System.Console;
namespace DungeonCrawlers.Main.Interfaces
{
    internal class MainScreen
	{



		private string gameVersion = "Test Version V.1 \n";

		public ConsoleKeyInfo ConsoleKeyInfo { get; private set; }

		public void mainScreen()
		{
			string title = "====DungeonCrawlers====";

			Title = title;
			ForegroundColor = ConsoleColor.Red;
			GameTitle gTitle = new GameTitle();
			gTitle.MainGameTitle();
			WriteOnBottomLine(gameVersion.Pastel("#5A057A"));
			Write(String.Format("{0," + Console.WindowWidth /2 + "}","Plz Enter Your Name:".Pastel("#97151D")));
			//Write("Plz Enter Your Name:");
			ForegroundColor = ConsoleColor.Cyan;
			string? UserName = ReadLine();
			Clear();
			WriteLine($"Welcome {UserName}\n");
			Write("                       Press Enter TO Enter Dungeon: ".Pastel("#8A39A8"));
			ConsoleKeyInfo key = ReadKey();
			Thread.Sleep(500);
			Clear();
			MainMenu.Mainmenu();
		}















	}
}
