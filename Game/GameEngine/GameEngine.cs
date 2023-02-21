using DungeonCrawlers.Adventures.Quests;
using static System.Console;
namespace DungeonCrawlers.Game.GameEngine
{
	public static class GameEngine
    {

		public static void StartGame()
		{
			//TODO
			/*
			 ~ Make a Quest menu class 
				Will load all Quests.
				 (Maybe)
			 */


			//Load Dukes Quest..
			//Will be loaded from another Quest Menu..



			var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}Adventures";
			var Dukesquest = new DukesQuestData();
			


			Thread.Sleep(200);
			Clear();
			WriteLine("This Game Is Currently Being Worked On ");
			ReadKey();

		}

		public static void CreateCharacter()
		{
			// This is going to be loaded in another class before the game starts.
			WriteLine("You are creating a Character");
		}


	}
}
