using DungeonCrawlers.Entities.Interfaces;
using Newtonsoft.Json;

namespace DungeonCrawlers.Entities.Character.Service
{
	public class CharacterService : ICharacterService
	{
		public CharacterData GetLoadWarriorClass()
		{
			var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}PlayerData";
			var Warriorc = new CharacterData();

			if (File.Exists($"{basePath}\\Warrior.json"))
			{
				var directory = new DirectoryInfo(basePath);
				var WarriorJson = directory.GetFiles("Warrior.json");

				using StreamReader fi = File.OpenText(WarriorJson[0].FullName);
				Warriorc = JsonConvert.DeserializeObject<CharacterData>(fi.ReadToEnd());
			}
			else
			{
				throw new Exception("No Character found");
			}

			return Warriorc;
		}
	}
}