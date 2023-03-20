using DungeonCrawlers.Game.Interfaces;
using static System.Console;

namespace DungeonCrawlers.Game.GameEngine
{
	internal class Engine
	{
		private static QuestMenu Questmenu = new QuestMenu();


		
		public static void StartGame()
		{

			try
			{
				//GetWarriorClass.LoadWarrior();
				//LoadDukesQuest.DukesMainQuest();

				//CCm.CreationMenu();
				Questmenu.Questmenu();


				



			}
			catch (Exception)
			{
				string? ErrorMsg = "Initial Files not Found";
				Clear();
				WriteLine($"KaBoom Orcs did it again something went wrong!!! {ErrorMsg}");
				ReadKey();
			}
		}
	}
}