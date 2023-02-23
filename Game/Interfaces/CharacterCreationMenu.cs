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

		public void CreationMenu()
		{
			WriteLine("Plz Select The Character you would like to play as.".Pastel("#125974"));

			WriteLine("Please Chose A Character To Begin".Pastel("#127700"));
			ForegroundColor = ConsoleColor.Blue;
			WriteLine("             |(W)arrior|        |(W)izard|                     ");
			WriteLine("             |(M)onk|			 |()	|					   ");
			WriteLine("														   ");
			WriteLine("                                                        ");

			switch (ReadLine().ToUpper())
			{
				case "W":
					Clear();
					GetWarriorClass.LoadWarrior();

					Clear();

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