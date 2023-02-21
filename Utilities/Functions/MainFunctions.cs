using Pastel;
using static System.Console;
namespace DungeonCrawlers.Utilities.Functions
{
	public class MainFunctions
	{
		public static Random rand = new Random();
		//public static Player currentPlayer = new Player();

		public static void WaitForAnyKeyPress()
		{
			Write("\nPress any key to continue....".Pastel("#210487"));
			ReadKey(true);
		}

		public static void ConsoleSize()
		{
			
			SetWindowSize(100, 25);
			BufferHeight = 25;
			BufferWidth = 100;



		}




		public static void WriteOnBottomLine(string Hello)
		{
			int x = CursorLeft;
			int y = CursorTop;
			CursorTop = WindowTop + WindowHeight - 1;
			Write(Hello);
			// Restore previous position
			SetCursorPosition(12, 12);
		}

		public static void Print(string text, int speed = 40)
		{
			foreach (char c in text)
			{
				WriteLine("c");
				Thread.Sleep(speed);
			}

			WriteLine();
		}
	}
}
