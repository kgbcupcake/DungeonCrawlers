using DungeonCrawlers.Entities.Interfaces;
using Newtonsoft.Json;
using static System.Console;
namespace DungeonCrawlers.Entities.Character.Service
{
	public class CharacterService : ICharacterService
	{
		

		public CharacterData GetLoadWarriorClass()
		{
			var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}PlayerData";
			var character = new CharacterData();

			if (File.Exists($"{basePath}\\Warrior.json"))
			{
				var directory = new DirectoryInfo(basePath);
				var WarriorJson = directory.GetFiles("Warrior.json");

				using StreamReader fi = File.OpenText(WarriorJson[0].FullName);
				character = JsonConvert.DeserializeObject<CharacterData>(fi.ReadToEnd());
			}
			else
			{
				throw new Exception("No Character found");
			}
			
			return character;
		}

		public List<CharacterData> GetCharactersInRange(int minLevel = 0, int maxLevel = 20)
		{
			var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}PlayerData";
			var charactersInRange = new List<CharacterData>();

			 
			try
			{
				var directory = new DirectoryInfo(basePath);
				foreach (var file in directory.GetFiles($"*.json"))
				{
					using StreamReader fi = File.OpenText(file.FullName);
					var pCIR = JsonConvert.DeserializeObject<CharacterData>(fi.ReadToEnd());
					if(pCIR.health >0 && (pCIR.Level >= minLevel && pCIR.Level <= maxLevel))
					{
						charactersInRange.Add(pCIR);
					}

				}
			}
			catch (Exception)
			{
				string? ErrorMsg = "Initial Files not Found";
				Clear();
				WriteLine($"KaBoom Orcs did it again something went wrong!!! {ErrorMsg}");
			}
			return charactersInRange;
			
		}
	}
}