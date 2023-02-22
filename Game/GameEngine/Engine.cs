using DungeonCrawlers.Game.Interfaces;

namespace DungeonCrawlers.Game.GameEngine
{
	public class Engine
    {
		
		private static QuestMenu  Questmenu = new QuestMenu();
		private static CharacterCreationMenu CCm= new CharacterCreationMenu();
		public void StartGame()
		{
			CCm.CreationMenu();
			

			//Will go into CreateCharacter Menu.. first then load quest menu..
			//Still have to build CharacterCreationMenu...
			//CharacterCreationMenu CCm = new CharacterCreationMenu();
			//CCm.CreationMenu();


			Questmenu.Questmenu();

		}
	}
}
