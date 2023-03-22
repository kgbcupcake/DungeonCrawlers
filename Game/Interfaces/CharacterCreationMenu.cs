using DungeonCrawlers.Adventures.Quests;
using DungeonCrawlers.Adventures.Services;
using DungeonCrawlers.Entities.Character.Service;
using DungeonCrawlers.Entities.Character.Warrior;
using Pastel;
using static System.Console;

namespace DungeonCrawlers.Game.Interfaces
{
	public class CharacterCreationMenu
	{	
		private static CharacterService characterService = new CharacterService();
		private static WarriorClass GetWarriorClass = new WarriorClass(characterService);

		private static AdventureService adventureService = new AdventureService();
		private static DukesQuest LoadDukesQuest = new DukesQuest(adventureService);

	




		public void CreationMenu()
		{
			Clear();
			Player p = new Player();
			//WriteLine("Plz Select The Character you would like to play as.".Pastel("#125974"));

			WriteLine("Please Chose A Character To Begin".Pastel("#127700"));
			ForegroundColor = ConsoleColor.Blue;
			WriteLine("             |(K)night|        |(W)izard|               ");
			WriteLine("             |(M)onk|								   ");
			WriteLine("														   ");
			WriteLine("                                                        ");

			switch (ReadLine().ToUpper())
			{
				case "K":
					Clear();
					GetWarriorClass.LoadWarrior();

					

					break;

				case "M":
					Clear();
					WriteLine("No Character Found ");

					break;

				case "B":
					WriteLine("No Character Found ");
					break;

				default:
					Clear();
					WriteLine("Plz Enter The Right Letter ");
					CreationMenu();
					break;
			}
		}
	}
}