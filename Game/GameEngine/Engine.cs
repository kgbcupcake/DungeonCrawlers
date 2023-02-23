using DungeonCrawlers.Game.Interfaces;
using static System.Console;

namespace DungeonCrawlers.Game.GameEngine
{
	internal class Engine
	{
		private static QuestMenu Questmenu = new QuestMenu();
		private static CharacterCreationMenu CCm = new CharacterCreationMenu();

		public void StartGame()
		{
			try
			{
				CCm.CreationMenu();
				Questmenu.Questmenu();
			}
			catch (Exception e)
			{
				string? ErrorMsg = "Initial Files not Found";
				Clear();
				WriteLine($"KaBoom Orcs did it again something went wrong!!! {ErrorMsg}");
				ReadKey();
			}
		}
	}
}