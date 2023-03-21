using static System.Console;

namespace DungeonCrawlers.Game.GameEngine
{
	internal class Engine
	{
		
		

		
		public static void StartGame()
		{

			try
			{
				//GetWarriorClass.LoadWarrior();
				//LoadDukesQuest.DukesMainQuest();


				//CCm.CreationMenu();




				// Town Square
				TownSquare.TownSquare.MainTownsquare();

				
				


				



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