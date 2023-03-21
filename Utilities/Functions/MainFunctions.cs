using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Game.Interfaces;
using DungeonCrawlers.Game.TownSquare;
using Pastel;
using static System.Console;

namespace DungeonCrawlers.Utilities.Functions
{
    public class MainFunctions
	{
		private static QuestMenu Questmenu = new QuestMenu();
		public static readonly Player currentPlayer = new Player();
		public static void WaitForAnyKeyPress()
		{
			Write("\nPress any key to continue....".Pastel("#210487"));
			ReadKey(true);
		}

		/// <summary>
		/// LineBreak
		/// </summary>
		public static void LineBreak()
		{
			WriteLine();
			WriteLine();
			WriteLine();
		}

		/// <summary>
		/// Yes/No Option for Torch....
		/// </summary>
		public static void YesNo()
		{
			Clear();
			WriteLine("Are you sure you don't want the torch? You wont be able to see a thing!!");
			Write("Yes/No?");
			switch (ReadLine().ToUpper())
			{
				case "Y":
					Clear();
					WriteLine("you're a animal!!! Okay");
					break;

				case "N":
					Clear();
					WriteLine("You have successfully taken the torch off of the wall");
					break;

				default:

					WriteLine("Plz Put Yes Or No");
					YesNo();
					break;
			}
		}

		/// <summary>
		/// Yes No Option for Starting Quest
		/// </summary>
		public static void YesNoTwo()
		{

			switch (ReadLine().ToUpper())
			{
				case "Y":
					Clear();
					WriteLine("      You are about to start your first quest will You survive?");
					break;

				case "N":
					Clear();
					WriteLine(" Returning back to Quest Menu Plz Wait ");
					Thread.Sleep(1500);
					Clear();
					Questmenu.Questmenu();
					break;

				default:

					WriteLine("Plz Put Yes Or No");
					YesNoTwo();
					break;
			}
		}

		/// <summary>
		/// COnsole Size
		/// </summary>
		public static void ConsoleSize()
		{
			SetWindowSize(100, 25);
			BufferHeight = 25;
			BufferWidth = 100;
		}

		/// <summary>
		/// Writes Text At bottom of screen
		/// </summary>
		public static void WriteOnBottomLine(string Hello)
		{
			int x = CursorLeft;
			int y = CursorTop;
			CursorTop = WindowTop + WindowHeight - 1;
			Write(Hello);
			// Restore previous position
			SetCursorPosition(12, 12);
		}

		/// <summary>
		/// Print Text
		/// </summary>
		public static void Print(string text, int speed = 40)
		{
			foreach (char c in text)
			{
				WriteLine("c");
				Thread.Sleep(speed);
			}

			WriteLine();
		}

		/// <summary>
		/// This Method Loads the Store...
		/// </summary>
		public static void Runstore()

		{

			WriteLine("Loading Store");
			Thread.Sleep(1000);
			Store.LoadShop(currentPlayer);




			//if (MainScreen.currentPlayer.health > 0)
			//{
			//	WriteLine(" You've won!!! would you like to go to Return to the town square and upgrade your gear?");
			//	Write("Yes/No:");
			//	switch (ReadLine().ToUpper())
			//	{
			//		case "Y":
			//			WriteLine("Loading Store");
			//			Store.LoadShop(currentPlayer);
			//			break;
			//		case "N":
			//			break;
			//	}

			//}



		}





	}

}