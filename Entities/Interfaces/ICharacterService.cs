using DungeonCrawlers.Entities.Character.Service;

namespace DungeonCrawlers.Entities.Interfaces
{
	public interface ICharacterService
	{
		public CharacterData GetLoadWarriorClass();

		public List<CharacterData> GetCharactersInRange(int minLevel =0,int maxLevel =20 );
	}
}