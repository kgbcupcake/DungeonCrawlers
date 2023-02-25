using DungeonCrawlers.Adventures.Interfaces;
using DungeonCrawlers.Adventures.Quests;
using DungeonCrawlers.Adventures.Services;
using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Entities.Character.Warrior;
using DungeonCrawlers.Entities.Interfaces;
using DungeonCrawlers.Game.Interfaces;
using static System.Console;

namespace DungeonCrawlers.Game.GameEngine
{
	internal class Engine
	{
		private static QuestMenu Questmenu = new QuestMenu();
		//private static CharacterCreationMenu CCm = new CharacterCreationMenu();
		//private static CharacterService characterService = new CharacterService();
		//private static WarriorClass GetWarriorClass = new WarriorClass(characterService);
		//private static AdventureService adventureService = new AdventureService();
		//private static AdventureService LoadAdventure = new AdventureService();
		//private static DukesQuest LoadDukesQuest = new DukesQuest(adventureService);
		//private IAdventureService adventureService;
		

		//public Engine(IAdventureService AdventureService, ICharacterService CharacterService) 
		//{
			//adventureService = AdventureService;
		
		
		//}	

		
		public static void StartGame()
		{
			//var loadDukesQuest = adventureService.GetLoadDukesquest();
			//var Warriorc = characterService.GetLoadWarriorClass();
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